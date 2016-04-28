using System;
using System.Collections.Generic;
using System.Threading;
using Model;
using View;
using View.Events;

namespace Presenters
{
    public class MainPresenter
    {
        IMainView _view;
        IModel _model;
        private List<Questions> CurrentSession;
        private delegate void ProgWork(int a);
        public MainPresenter(IMainView View, IModel Model)
        {
            _view = View;
            _view.ActivateAnswers += new EventHandler<ActivateAnswersEvent>(ActivateAnswers);
            _view.MakeMiddle += new EventHandler<MiddleTipEvent>(MakeMiddle);
            _view.StartChoice += new EventHandler<StartChoiceEvent>(StartChoice);
            _view.ENewGame += new EventHandler<NewGameEvent>(NewGame);
            _view.EActivatePlayer += new EventHandler<ActivatePlayerEvent>(ActivatePlayer);
            _view.PhoneCallString += new EventHandler<PhoneCallStringEvent>(PhoneCallString);
            _view.StartPhoneCall += new EventHandler<StartPhoneCallEvent>(StartPhoneCall);
            _view.EHighLight += new EventHandler<HighLightEvent>(HighLight);
            _view.StartAudience += new EventHandler<StartAudienceEvent>(StartAudience);
            _model = Model;
            CurrentStep = 0;
            GameOn = false;
            CurrentSession = new List<Questions>();
        }
        private int CurrentStep { get; set; }
        private bool GameOn { get; set; }
        private Questions CurrentQuestion { get; set; }
      
        private void ActivateAnswers(object sender, ActivateAnswersEvent e)
        {
            _view.RightLabelNumber = CurrentQuestion.Index() + 1;
            if (e.Activate)
            {
                for (int i = 1; i < 5; i++)
                    _view.ActivateAnswer(i, true);
            }
            else
            {
                for (int i = 1; i < 5; i++)
                    _view.ActivateAnswer(i, false);
            }
        }
        private void ActivatePlayer(object sender, ActivatePlayerEvent e)
        {
            _view.ActivatePlayer(e.Activate);
        }
        private void MakeVote()
        {
            int[] ValueArray = new int[4];
            int total = 100;
            int value = 100;
            Random rnd = new Random();
            Action Act = delegate
            {
                value = rnd.Next(40, 65);
                total -= value;
                ValueArray[CurrentQuestion.Index()] = value;
                for (int i = 0; i < 4; i++)
                {
                    if (i == CurrentQuestion.Index())
                        continue;
                    value = rnd.Next(0, total);
                    total -= value;
                    ValueArray[i] = value;
                }
            };
            _view.InvokeAction(Act);

            ProgWork IW = delegate(int a)
            {
                if (a > ValueArray[0])
                    return;
                _view.Prog1.Value = a;
            };

            IW += delegate(int a)
            {
                if (a > ValueArray[1])
                    return;
                _view.Prog2.Value = a;
            };
            IW += delegate(int a)
            {
                if (a > ValueArray[2])
                    return;
                _view.Prog3.Value = a;
            };
            IW += delegate(int a)
            {
                if (a > ValueArray[3])
                    return;
                _view.Prog4.Value = a;
            };
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                
                _view.InvokeAction(IW, i);
            }
            Thread.Sleep(3000);
            Act = delegate
            {
                _view.ShowAudienceVote(false);
            };
            _view.InvokeAction(Act);
        }
        private void StartAudience(object sender, StartAudienceEvent e)
        {
            _view.ShowAudienceVote(true);
            _view.PlaySound(Media.AudienceSoundFilename);
            Thread thread = new Thread(() => MakeVote());
            thread.IsBackground = true;
            thread.Start();
        }
        private void PhoneCallString(object sender, PhoneCallStringEvent e)
        {
            _view.SetProfessorsTip("Я думаю, что это "+((Questions.Position)CurrentQuestion.Index()).ToString());
        }
        private void MakePhoneCall()
        {
            Action Act = delegate
            {
                _view.ActivatePhoneCall(true);
            };
            Thread.Sleep(2000);
            _view.InvokeAction(Act);
            Thread.Sleep(3000);
            Act = delegate
            {
                _view.ActivatePhoneCall(false);
            };
            _view.InvokeAction(Act);
        }
        private void StartPhoneCall(object sender, StartPhoneCallEvent e)
        {
            _view.PlaySound(Media.PhonecallSoundFilename);
            Thread thread = new Thread(() => MakePhoneCall());
            thread.IsBackground = true;
            thread.Start();
        }
        private void MakeMiddle(object sender, MiddleTipEvent e)
        {
            if (CurrentQuestion.Index() == 0 || CurrentQuestion.Index() == 3)
            {
                _view.EnableAnswer(2, false);
                _view.EnableAnswer(3, false);
            }
            else if (CurrentQuestion.Index() == 1 || CurrentQuestion.Index() == 2)
            {
                _view.EnableAnswer(1, false);
                _view.EnableAnswer(4, false);
            }
        }
        private void NextQuestion()
        {
            CurrentQuestion = new Questions();
            CurrentQuestion = GetRandomQuestion();
            _view.RightLabelNumber = CurrentQuestion.Index() + 1;
            _view.ShowQuestion(CurrentQuestion.Text, CurrentQuestion.Answers());
        }
        private Questions GetRandomQuestion()
        {
            Questions result;
            while (true)
            {
                try
                {
                    bool bHelp = false;
                    Random rnd = new Random();
                    result = _model[rnd.Next(0, _model.Count)];
                    for (int i = 0; i < CurrentSession.Count; i++)
                    {
                        if (result.Text == CurrentSession[i].Text)
                        {
                            bHelp = true;
                            break;
                        }
                    }
                    if (bHelp == false)
                        break;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            CurrentSession.Add(result);
            return result;
        }
        private bool NextStep()
        {
            _view.RefreshSteps();
            CurrentStep++;
            _view.ActivateStep(CurrentStep);
            if (CurrentStep == 15)
            {
                GameOn = false;
                _view.ClearField();
                _view.InitWin();
                _view.PlaySound(Media.WinSoundFilename);
                return false;
            }
            else if (CurrentStep == 10 || CurrentStep == 5)
            {
                bool res = _view.MakeQuestion("Вы можете забрать деньги, или продолжить игру. Забрать деньги?");
                if (res == true)
                {
                    GameOn = false;
                    _view.ClearField();
                    _view.InitWin();
                    return false;
                }
            }
            return true;
        }
        private void FalseChoice(object label)
        {
            Action Act = delegate
            {
                _view.HighLightAnswer(label, false);
                _view.PlaySound(Media.FalseSoundFilename);
            };
            Thread.Sleep(2000);
            _view.InvokeAction(Act);
            for (int i = 0; i < 3; i++)
                _view.HighLight(CurrentQuestion.Index() + 1);
            Thread.Sleep(1000);
            Act = delegate
            {
                _view.ClearField();
                _view.RefreshSteps();
                _view.RestoreHelpButtons();
                _view.ShowLooseImage(true);
            };
            _view.InvokeAction(Act);
            GameOn = false;
            Thread.Sleep(4000);
            Act = delegate
            {
                _view.ShowLooseImage(false);
            };
            _view.InvokeAction(Act);
        }
        private void TrueChoice(object label)
        {
            Action Act = delegate
            {
                _view.HighLightAnswer(label, true);
                _view.PlaySound(Media.TrueSoundFilename);
            };
            Thread.Sleep(2000);
            _view.InvokeAction(Act);
            for (int i = 0; i < 3; i++)
                _view.HighLight(CurrentQuestion.Index() + 1);
            Thread.Sleep(1000);
            Act = delegate
            {
                _view.ClearField();
            };
            _view.InvokeAction(Act);
            Thread.Sleep(1000);
            Act = delegate
            {
                if (NextStep())
                    NextQuestion();
            };
            _view.InvokeAction(Act);
        }

        private void StartChoice(object sender, StartChoiceEvent e)
        {
            if (e.Right)
            {
                Thread thread = new Thread(() => TrueChoice(sender));
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                Thread thread = new Thread(() => FalseChoice(sender));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void NewGame(object sender, NewGameEvent e)
        {
            if (GameOn)
            {
                bool res = _view.MakeQuestion("Вы хотите потерять данные и начать новую игру?");
                if (res == true)
                    StartNewGame();
                else
                    return;
            }
            else
                StartNewGame();
        }
        private void StartNewGame()
        {
            CurrentStep = 0;
            _view.RefreshSteps();
            NextQuestion();
            GameOn = true;
            _view.PlaySound(Media.GongSoundFilename);
            _view.NewGame();
        }

        private void HighLight(object sender, HighLightEvent e)
        {
            _view.HighLight(e.Label);
        }
    }
}
