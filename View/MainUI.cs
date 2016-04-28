using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using WMPLib;
using AxWMPLib;
using View.Events;

namespace View
{
    public partial class MainUI : Form, IMainView
    {
        private IManager QManager;
        private SoundPlayer soundplayer;
        public MainUI()
        {
            InitializeComponent();
            soundplayer = new SoundPlayer();
        }
        public enum Position { A, B, C, D };
        #region IMainView Implementation
        public event EventHandler<ActivateAnswersEvent> ActivateAnswers;
        public event EventHandler<MiddleTipEvent> MakeMiddle;
        public event EventHandler<StartChoiceEvent> StartChoice;
        public event EventHandler<NewGameEvent> ENewGame;
        public event EventHandler<ActivatePlayerEvent> EActivatePlayer;
        public event EventHandler<PhoneCallStringEvent> PhoneCallString;
        public event EventHandler<StartPhoneCallEvent> StartPhoneCall;
        public event EventHandler<StartAudienceEvent> StartAudience;
        public event EventHandler<HighLightEvent> EHighLight;
        public ProgressBar Prog4 { get; set; }
        public ProgressBar Prog3 { get; set; }
        public ProgressBar Prog2 { get; set; }
        public ProgressBar Prog1 { get; set; }
        public int RightLabelNumber { get; set; }
        public void SetManager(IManager manager)
        {
            QManager = manager;
        }
        public void InvokeAction(Action act)
        {
            this.Invoke(act);
        }
        public void InvokeAction(Delegate act, int param)
        {
            this.Invoke(act, param);
        }
        public void SetVoteLabel(string Text)
        {
            this.AudiVoteLabel.Text = Text;
        }
        public void ShowAudienceVote(bool flag)
        {
            if(flag==false)
            {
                this.groupBox2.Visible = false;
                this.LettersLabel.Visible = false;
                this.Prog1.Visible = false;
                this.Prog2.Visible = false;
                this.Prog3.Visible = false;
                this.Prog4.Visible = false;
                this.AudiVoteLabel.Visible = false;
                this.NewGameMenuButton.Enabled = true;
                this.ExitButton.Enabled = true;
                this.NewGameButton.Enabled = true;
            }
            else
            {
                this.NewGameMenuButton.Enabled = false;
                this.ExitButton.Enabled = false;
                this.NewGameButton.Enabled = false;
                this.groupBox2.Visible = true;
                this.LettersLabel.Visible = true;
                this.Prog1.Visible = true;
                this.Prog2.Visible = true;
                this.Prog3.Visible = true;
                this.Prog4.Visible = true;
                this.AudiVoteLabel.Visible = true;
            }
        }
        public void ActivatePlayer(bool flag)
        {
            if(flag==false)
            {
                this.axWindowsMediaPlayer1.Visible = false;
                this.axWindowsMediaPlayer1.close();
                this.menuStrip1.Enabled = true;
                this.ExitButton.Enabled = true;
                this.NewGameButton.Enabled = true;
                this.SpaceButtonLabel.Visible = false;
            }
            else
            {
                this.axWindowsMediaPlayer1.URL=Media.IntroFilename;
                this.axWindowsMediaPlayer1.settings.autoStart = true;
                this.axWindowsMediaPlayer1.stretchToFit = true;
                this.axWindowsMediaPlayer1.uiMode = "none";
                this.axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
                this.axWindowsMediaPlayer1.ErrorEvent += player_ErrorEvent;
                this.menuStrip1.Enabled = false;
                this.ExitButton.Enabled = false;
                this.NewGameButton.Enabled = false;
            }
        }
        public void NewGame()
        {
            this.Help50Button.Enabled = true;
            this.HelpAudiButton.Enabled = true;
            this.HelpCallButton.Enabled = true;
            this.Help50Button.BackgroundImage = Resource1._1;
            this.HelpCallButton.BackgroundImage = Resource1._2;
            this.HelpAudiButton.BackgroundImage = Resource1._3;
            this.WinImage.Visible = false;
            this.WinLabel.Visible = false;
            this.LooseLabel.Visible = false;
            this.LooseImage.Visible = false;
        }
        public void ActivateAnswer(int index, bool flag)
        {
            if(flag==false)
            {
                this.Controls["Answer" + index].MouseEnter -= _MouseEnterAnswer;
                this.Controls["Answer" + index].MouseLeave -= _MouseLeaveAnswer;
                this.Controls["Answer" + index].MouseClick -= _MouseClickAnswer;
                this.Controls["Answer" + index].Cursor = Cursors.Default;
            }
            else
            {
                this.Controls["Answer" + index].BackColor = Color.Black;
                this.Controls["Answer" + index].MouseEnter += _MouseEnterAnswer;
                this.Controls["Answer" + index].MouseLeave += _MouseLeaveAnswer;
                this.Controls["Answer" + index].MouseClick += _MouseClickAnswer;
                this.Controls["Answer" + index].Cursor = Cursors.Hand;
                this.Controls["Answer" + index].Enabled = true;
            }
        }
   
        public void PlaySound(string Filename)
        {
            soundplayer.SoundLocation = Filename;
            soundplayer.Play();
        }
        public bool MakeQuestion(string Text)
        {
            DialogResult res = MessageBox.Show(Text, "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public void ClearField()
        {
            for (int i = 1; i < 5; i++)
                this.Controls["Answer" + i].Visible = false;
            this.QuestionLabel.Visible = false;
            this.GalkinFalse.Visible = false;
            this.TitleFalse.Visible = false;
            this.GalkinTrue.Visible = false;
            this.TitleTrue.Visible = false;
            this.ProfessorSay.Visible = false;
            this.Professor.Visible = false;
        }
        public void ActivateStep(int index)
        {
            this.Controls["step" + index].BackColor = Color.OrangeRed;
        }
        public void RefreshSteps()
        {
            for (int i = 1; i <= 15; i++)
                this.Controls["step" + i].BackColor = Color.Black;
        }
        public void InitWin()
        {
            this.WinImage.Visible = true;
            this.WinLabel.Visible = true;
        }
        public void ShowQuestion(string Text, string[] Answers)
        {
            Help50Button.Enabled = true;
            HelpAudiButton.Enabled = true;
            HelpCallButton.Enabled = true;
            QuestionLabel.Text = Text;
            QuestionLabel.Visible = true;
            for (int i = 1; i < 5; i++)
            {
                this.Controls["Answer" + i].Text = ((Position)(i - 1)).ToString() + ": " + Answers[i - 1];
                this.Controls["Answer" + i].Visible = true;
            }
            ActivateAnswers(this, new ActivateAnswersEvent(true));
        }
        public void RestoreHelpButtons()
        {
            this.Help50Button.Enabled = false;
            this.HelpAudiButton.Enabled = false;
            this.HelpCallButton.Enabled = false;
            this.Help50Button.BackgroundImage = Resource1._1;
            this.HelpCallButton.BackgroundImage = Resource1._2;
            this.HelpAudiButton.BackgroundImage = Resource1._3;
        }
        public void ShowLooseImage(bool flag)
        {
            this.LooseImage.Visible = flag;
            this.LooseLabel.Visible = flag;
        }
        public void HighLight(object label)
        {
            (label as Label).BackColor = Color.Green;
            Thread.Sleep(500);
            (label as Label).BackColor = Color.Black;
            Thread.Sleep(500);
        }
        public void HighLight(int LabelIndex)
        {
            EHighLight(this, new HighLightEvent(this.Controls["Answer" + LabelIndex]));
        }
        public void HighLightAnswer(object label, bool AnswerStatus)
        {
            if(AnswerStatus==true)
            {
                this.GalkinTrue.Visible = true;
                this.TitleTrue.Visible = true;
                (label as Label).BackColor = Color.Green;
            }
            else
            {
                this.GalkinFalse.Visible = true;
                this.TitleFalse.Visible = true;
                (label as Label).BackColor = Color.Red;
            }
        }
        public void EnableAnswer(int index, bool flag)
        {
            this.Controls["Answer" + index.ToString()].Enabled = flag;
        }
        public void ActivatePhoneCall(bool flag)
        {
            if(flag==false)
            {
                this.Professor.Visible = false;
                this.ProfessorSay.Visible = false;
                this.NewGameMenuButton.Enabled = true;
                this.ExitButton.Enabled = true;
                this.NewGameButton.Enabled = true;
            }
            else
            {
                this.ProfessorSay.Visible = true;
                PhoneCallString(this, new PhoneCallStringEvent());
            }
        }

        public void SetProfessorsTip(string Text)
        {
            ProfessorSay.Text = Text;
        }
        #endregion
        private void HelpCallButton_Click(object sender, EventArgs e)
        {
            this.HelpCallButton.BackgroundImage = Resource1._5;
            this.HelpCallButton.Enabled = false;
            this.Professor.Visible = true;
            this.NewGameMenuButton.Enabled = false;
            this.ExitButton.Enabled = false;
            this.NewGameButton.Enabled = false;
            StartPhoneCall(this, new StartPhoneCallEvent());
        }
        private void HelpAudiButton_Click(object sender, EventArgs e)
        {
            this.HelpAudiButton.BackgroundImage = Resource1._6;
            this.HelpAudiButton.Enabled = false;
            StartAudience(this, new StartAudienceEvent());
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            EActivatePlayer(this, new ActivatePlayerEvent(true));
        }
        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
           
            if (e.nKeyCode == (short)Keys.Space)
            {
                Thread.Sleep(500);
                EActivatePlayer(this, new ActivatePlayerEvent(false));
            }
        }
        private void QManagerMenuButton_Click(object sender, EventArgs e)
        {
            ((QuestionManager)QManager).Show();
        }
        private void AboutMenuButton_Click(object sender, EventArgs e)
        {
            soundplayer.SoundLocation = Media.AboutSoundFilename;
            soundplayer.Play();
            MessageBox.Show("Программу разработал студент \nКомпьютерной Академии \"ШАГ\"\n" +
                    "Одесского Национального Политехнического Универститета\n" +
                    "Восточно-баварского Технического Института города Регенсбург\n" +
                    "Морозов Дмитрий Александрович \nПриятного прослушивания Rammstein - Ich will.");
            soundplayer.Stop();
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
                EActivatePlayer(this, new ActivatePlayerEvent(false));
        }
        private void player_ErrorEvent(object sender, System.EventArgs e)
        {
            EActivatePlayer(this, new ActivatePlayerEvent(false));
        }
        private void NewGameMenuButton_Click(object sender, EventArgs e)
        {
            ENewGame(this, new NewGameEvent());
        }
        private void _MouseClickAnswer(object sender, EventArgs e)
        {
            Label Lsender = sender as Label;
            Lsender.BackColor = Color.DarkBlue;
            ActivateAnswers(sender, new ActivateAnswersEvent(false));
            Help50Button.Enabled = false;
            HelpAudiButton.Enabled = false;
            HelpCallButton.Enabled = false;
            if (this.Controls["Answer"+Convert.ToString(RightLabelNumber)] == Lsender)
                StartChoice(sender, new StartChoiceEvent(true));
            else
                StartChoice(sender, new StartChoiceEvent(false));
        }
        private void _MouseEnterAnswer(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.DarkBlue;
        }
        private void _MouseLeaveAnswer(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.Black;
        }
        private void ExitMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _MouseDownButton(object sender, MouseEventArgs e)
        {
            (sender as Button).FlatStyle = FlatStyle.Popup;
        }
        private void _MouseUpButton(object sender, MouseEventArgs e)
        {
            (sender as Button).FlatStyle = FlatStyle.Flat;
        }
        private void Help50Button_Click(object sender, EventArgs e)
        {
            this.Help50Button.BackgroundImage = Resource1._4;
            this.Help50Button.Enabled = false;
            MakeMiddle(this, new MiddleTipEvent());
        }
    }
}
