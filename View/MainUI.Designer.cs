using System.Windows.Forms;
namespace View
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            soundplayer.Stop();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QManagerMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.step15 = new System.Windows.Forms.Label();
            this.step14 = new System.Windows.Forms.Label();
            this.step13 = new System.Windows.Forms.Label();
            this.step12 = new System.Windows.Forms.Label();
            this.step11 = new System.Windows.Forms.Label();
            this.step10 = new System.Windows.Forms.Label();
            this.step9 = new System.Windows.Forms.Label();
            this.step8 = new System.Windows.Forms.Label();
            this.step7 = new System.Windows.Forms.Label();
            this.step6 = new System.Windows.Forms.Label();
            this.step5 = new System.Windows.Forms.Label();
            this.step4 = new System.Windows.Forms.Label();
            this.step3 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HelpAudiButton = new System.Windows.Forms.Button();
            this.HelpCallButton = new System.Windows.Forms.Button();
            this.Help50Button = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.Answer3 = new System.Windows.Forms.Label();
            this.Answer4 = new System.Windows.Forms.Label();
            this.TitleFalse = new System.Windows.Forms.Label();
            this.TitleTrue = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.SpaceButtonLabel = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.ToolTip(this.components);
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProfessorSay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Prog4 = new System.Windows.Forms.ProgressBar();
            this.Prog3 = new System.Windows.Forms.ProgressBar();
            this.Prog2 = new System.Windows.Forms.ProgressBar();
            this.Prog1 = new System.Windows.Forms.ProgressBar();
            this.AudiVoteLabel = new System.Windows.Forms.Label();
            this.LettersLabel = new System.Windows.Forms.Label();
            this.LooseLabel = new System.Windows.Forms.Label();
            this.WinLabel = new System.Windows.Forms.Label();
            this.WinImage = new System.Windows.Forms.PictureBox();
            this.LooseImage = new System.Windows.Forms.PictureBox();
            this.Professor = new System.Windows.Forms.PictureBox();
            this.GalkinFalse = new System.Windows.Forms.Label();
            this.GalkinTrue = new System.Windows.Forms.Label();
            this.BackGroundImage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LooseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Professor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenuButton,
            this.администрированиеToolStripMenuItem,
            this.AboutMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GameMenuButton
            // 
            this.GameMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenuButton,
            this.ExitMenuButton});
            this.GameMenuButton.Name = "GameMenuButton";
            this.GameMenuButton.Size = new System.Drawing.Size(46, 20);
            this.GameMenuButton.Text = "Игра";
            // 
            // NewGameMenuButton
            // 
            this.NewGameMenuButton.Name = "NewGameMenuButton";
            this.NewGameMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewGameMenuButton.Size = new System.Drawing.Size(179, 22);
            this.NewGameMenuButton.Text = "Новая игра";
            this.NewGameMenuButton.Click += new System.EventHandler(this.NewGameMenuButton_Click);
            // 
            // ExitMenuButton
            // 
            this.ExitMenuButton.Name = "ExitMenuButton";
            this.ExitMenuButton.Size = new System.Drawing.Size(179, 22);
            this.ExitMenuButton.Text = "Выход";
            this.ExitMenuButton.Click += new System.EventHandler(this.ExitMenuButton_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QManagerMenuButton});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // QManagerMenuButton
            // 
            this.QManagerMenuButton.Name = "QManagerMenuButton";
            this.QManagerMenuButton.Size = new System.Drawing.Size(188, 22);
            this.QManagerMenuButton.Text = "Менеджер вопросов";
            this.QManagerMenuButton.Click += new System.EventHandler(this.QManagerMenuButton_Click);
            // 
            // AboutMenuButton
            // 
            this.AboutMenuButton.Name = "AboutMenuButton";
            this.AboutMenuButton.Size = new System.Drawing.Size(94, 20);
            this.AboutMenuButton.Text = "О программе";
            this.AboutMenuButton.Click += new System.EventHandler(this.AboutMenuButton_Click);
            // 
            // step15
            // 
            this.step15.AutoSize = true;
            this.step15.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step15.ForeColor = System.Drawing.Color.Chocolate;
            this.step15.Location = new System.Drawing.Point(836, 124);
            this.step15.Name = "step15";
            this.step15.Size = new System.Drawing.Size(166, 29);
            this.step15.TabIndex = 2;
            this.step15.Text = "15 - 1 000 000";
            // 
            // step14
            // 
            this.step14.AutoSize = true;
            this.step14.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step14.ForeColor = System.Drawing.Color.DarkOrange;
            this.step14.Location = new System.Drawing.Point(836, 153);
            this.step14.Name = "step14";
            this.step14.Size = new System.Drawing.Size(167, 29);
            this.step14.TabIndex = 3;
            this.step14.Text = "14 -    500 000";
            // 
            // step13
            // 
            this.step13.AutoSize = true;
            this.step13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step13.ForeColor = System.Drawing.Color.DarkOrange;
            this.step13.Location = new System.Drawing.Point(836, 182);
            this.step13.Name = "step13";
            this.step13.Size = new System.Drawing.Size(167, 29);
            this.step13.TabIndex = 4;
            this.step13.Text = "13 -    250 000";
            // 
            // step12
            // 
            this.step12.AutoSize = true;
            this.step12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step12.ForeColor = System.Drawing.Color.DarkOrange;
            this.step12.Location = new System.Drawing.Point(836, 211);
            this.step12.Name = "step12";
            this.step12.Size = new System.Drawing.Size(167, 29);
            this.step12.TabIndex = 5;
            this.step12.Text = "12 -    125 000";
            // 
            // step11
            // 
            this.step11.AutoSize = true;
            this.step11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step11.ForeColor = System.Drawing.Color.DarkOrange;
            this.step11.Location = new System.Drawing.Point(836, 240);
            this.step11.Name = "step11";
            this.step11.Size = new System.Drawing.Size(167, 29);
            this.step11.TabIndex = 6;
            this.step11.Text = "11 -      64 000";
            // 
            // step10
            // 
            this.step10.AutoSize = true;
            this.step10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step10.ForeColor = System.Drawing.Color.Chocolate;
            this.step10.Location = new System.Drawing.Point(836, 269);
            this.step10.Name = "step10";
            this.step10.Size = new System.Drawing.Size(168, 29);
            this.step10.TabIndex = 7;
            this.step10.Text = "10 -      32 000";
            // 
            // step9
            // 
            this.step9.AutoSize = true;
            this.step9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step9.ForeColor = System.Drawing.Color.DarkOrange;
            this.step9.Location = new System.Drawing.Point(833, 298);
            this.step9.Name = "step9";
            this.step9.Size = new System.Drawing.Size(169, 29);
            this.step9.TabIndex = 8;
            this.step9.Text = "  9 -      16 000";
            this.step9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step8
            // 
            this.step8.AutoSize = true;
            this.step8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step8.ForeColor = System.Drawing.Color.DarkOrange;
            this.step8.Location = new System.Drawing.Point(832, 327);
            this.step8.Name = "step8";
            this.step8.Size = new System.Drawing.Size(170, 29);
            this.step8.TabIndex = 9;
            this.step8.Text = "  8 -        8 000";
            this.step8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step7
            // 
            this.step7.AutoSize = true;
            this.step7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step7.ForeColor = System.Drawing.Color.DarkOrange;
            this.step7.Location = new System.Drawing.Point(832, 356);
            this.step7.Name = "step7";
            this.step7.Size = new System.Drawing.Size(170, 29);
            this.step7.TabIndex = 10;
            this.step7.Text = "  7 -        4 000";
            this.step7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step6
            // 
            this.step6.AutoSize = true;
            this.step6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step6.ForeColor = System.Drawing.Color.DarkOrange;
            this.step6.Location = new System.Drawing.Point(832, 385);
            this.step6.Name = "step6";
            this.step6.Size = new System.Drawing.Size(170, 29);
            this.step6.TabIndex = 11;
            this.step6.Text = "  6 -        2 000";
            this.step6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step5
            // 
            this.step5.AutoSize = true;
            this.step5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step5.ForeColor = System.Drawing.Color.Chocolate;
            this.step5.Location = new System.Drawing.Point(832, 414);
            this.step5.Name = "step5";
            this.step5.Size = new System.Drawing.Size(170, 29);
            this.step5.TabIndex = 12;
            this.step5.Text = "  5 -        1 000";
            this.step5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step4
            // 
            this.step4.AutoSize = true;
            this.step4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step4.ForeColor = System.Drawing.Color.DarkOrange;
            this.step4.Location = new System.Drawing.Point(831, 443);
            this.step4.Name = "step4";
            this.step4.Size = new System.Drawing.Size(171, 29);
            this.step4.TabIndex = 13;
            this.step4.Text = "  4 -           500";
            this.step4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step3
            // 
            this.step3.AutoSize = true;
            this.step3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step3.ForeColor = System.Drawing.Color.DarkOrange;
            this.step3.Location = new System.Drawing.Point(831, 472);
            this.step3.Name = "step3";
            this.step3.Size = new System.Drawing.Size(171, 29);
            this.step3.TabIndex = 14;
            this.step3.Text = "  3 -           300";
            this.step3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step2
            // 
            this.step2.AutoSize = true;
            this.step2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step2.ForeColor = System.Drawing.Color.DarkOrange;
            this.step2.Location = new System.Drawing.Point(831, 501);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(171, 29);
            this.step2.TabIndex = 15;
            this.step2.Text = "  2 -           200";
            this.step2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // step1
            // 
            this.step1.AutoSize = true;
            this.step1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step1.ForeColor = System.Drawing.Color.DarkOrange;
            this.step1.Location = new System.Drawing.Point(831, 530);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(171, 29);
            this.step1.TabIndex = 16;
            this.step1.Text = "  1 -           100";
            this.step1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HelpAudiButton);
            this.groupBox1.Controls.Add(this.HelpCallButton);
            this.groupBox1.Controls.Add(this.Help50Button);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(797, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 65);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подсказки";
            // 
            // HelpAudiButton
            // 
            this.HelpAudiButton.BackgroundImage = Resource1._3;
            this.HelpAudiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpAudiButton.Enabled = false;
            this.HelpAudiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpAudiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpAudiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpAudiButton.Location = new System.Drawing.Point(163, 19);
            this.HelpAudiButton.Name = "HelpAudiButton";
            this.HelpAudiButton.Size = new System.Drawing.Size(56, 36);
            this.HelpAudiButton.TabIndex = 19;
            this.t.SetToolTip(this.HelpAudiButton, "Помощь зала");
            this.HelpAudiButton.UseVisualStyleBackColor = true;
            this.HelpAudiButton.Click += new System.EventHandler(this.HelpAudiButton_Click);
            this.HelpAudiButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDownButton);
            this.HelpAudiButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUpButton);
            // 
            // HelpCallButton
            // 
            this.HelpCallButton.BackgroundImage = Resource1._2;
            this.HelpCallButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpCallButton.Enabled = false;
            this.HelpCallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpCallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpCallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpCallButton.Location = new System.Drawing.Point(84, 19);
            this.HelpCallButton.Name = "HelpCallButton";
            this.HelpCallButton.Size = new System.Drawing.Size(56, 36);
            this.HelpCallButton.TabIndex = 18;
            this.t.SetToolTip(this.HelpCallButton, "Звонок другу");
            this.HelpCallButton.UseVisualStyleBackColor = true;
            this.HelpCallButton.Click += new System.EventHandler(this.HelpCallButton_Click);
            this.HelpCallButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDownButton);
            this.HelpCallButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUpButton);
            // 
            // Help50Button
            // 
            this.Help50Button.BackgroundImage = Resource1._1;
            this.Help50Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help50Button.Enabled = false;
            this.Help50Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help50Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help50Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help50Button.Location = new System.Drawing.Point(6, 19);
            this.Help50Button.Name = "Help50Button";
            this.Help50Button.Size = new System.Drawing.Size(56, 36);
            this.Help50Button.TabIndex = 17;
            this.t.SetToolTip(this.Help50Button, "Подсказка 50 на 50");
            this.Help50Button.UseVisualStyleBackColor = true;
            this.Help50Button.Click += new System.EventHandler(this.Help50Button_Click);
            this.Help50Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDownButton);
            this.Help50Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUpButton);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.QuestionLabel.Location = new System.Drawing.Point(24, 327);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(750, 120);
            this.QuestionLabel.MinimumSize = new System.Drawing.Size(750, 120);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(750, 120);
            this.QuestionLabel.TabIndex = 19;
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionLabel.UseCompatibleTextRendering = true;
            this.QuestionLabel.Visible = false;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.ForeColor = System.Drawing.Color.Orange;
            this.Answer1.Location = new System.Drawing.Point(25, 455);
            this.Answer1.MinimumSize = new System.Drawing.Size(350, 50);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(350, 50);
            this.Answer1.TabIndex = 20;
            this.Answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer1.Visible = false;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.ForeColor = System.Drawing.Color.Orange;
            this.Answer2.Location = new System.Drawing.Point(424, 455);
            this.Answer2.MinimumSize = new System.Drawing.Size(350, 50);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(350, 50);
            this.Answer2.TabIndex = 21;
            this.Answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer2.Visible = false;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.ForeColor = System.Drawing.Color.Orange;
            this.Answer3.Location = new System.Drawing.Point(24, 521);
            this.Answer3.MinimumSize = new System.Drawing.Size(350, 50);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(350, 50);
            this.Answer3.TabIndex = 22;
            this.Answer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer3.Visible = false;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.ForeColor = System.Drawing.Color.Orange;
            this.Answer4.Location = new System.Drawing.Point(424, 521);
            this.Answer4.MinimumSize = new System.Drawing.Size(350, 50);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(350, 50);
            this.Answer4.TabIndex = 23;
            this.Answer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Answer4.Visible = false;
            // 
            // TitleFalse
            // 
            this.TitleFalse.AutoSize = true;
            this.TitleFalse.BackColor = System.Drawing.Color.DarkRed;
            this.TitleFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleFalse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleFalse.Location = new System.Drawing.Point(106, 223);
            this.TitleFalse.MinimumSize = new System.Drawing.Size(150, 100);
            this.TitleFalse.Name = "TitleFalse";
            this.TitleFalse.Size = new System.Drawing.Size(150, 100);
            this.TitleFalse.TabIndex = 26;
            this.TitleFalse.Text = "Неправильно!";
            this.TitleFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleFalse.Visible = false;
            // 
            // TitleTrue
            // 
            this.TitleTrue.AutoSize = true;
            this.TitleTrue.BackColor = System.Drawing.Color.DarkGreen;
            this.TitleTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTrue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleTrue.Location = new System.Drawing.Point(544, 223);
            this.TitleTrue.MinimumSize = new System.Drawing.Size(150, 100);
            this.TitleTrue.Name = "TitleTrue";
            this.TitleTrue.Size = new System.Drawing.Size(150, 100);
            this.TitleTrue.TabIndex = 27;
            this.TitleTrue.Text = "Правильно!";
            this.TitleTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleTrue.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 24);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1034, 587);
            this.axWindowsMediaPlayer1.TabIndex = 29;
            this.axWindowsMediaPlayer1.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.axWindowsMediaPlayer1_KeyDownEvent);
            // 
            // SpaceButtonLabel
            // 
            this.SpaceButtonLabel.AutoSize = true;
            this.SpaceButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpaceButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpaceButtonLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpaceButtonLabel.Location = new System.Drawing.Point(371, 584);
            this.SpaceButtonLabel.Name = "SpaceButtonLabel";
            this.SpaceButtonLabel.Size = new System.Drawing.Size(323, 20);
            this.SpaceButtonLabel.TabIndex = 30;
            this.SpaceButtonLabel.Text = "Нажмите \"SPACE\" чтобы пропустить";
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackgroundImage = Resource1._new;
            this.NewGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewGameButton.Location = new System.Drawing.Point(69, 25);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(60, 32);
            this.NewGameButton.TabIndex = 28;
            this.t.SetToolTip(this.NewGameButton, "Новая игра");
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameMenuButton_Click);
            this.NewGameButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDownButton);
            this.NewGameButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUpButton);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = Resource1.Exit;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 25);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 34);
            this.ExitButton.TabIndex = 20;
            this.t.SetToolTip(this.ExitButton, "Выход");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitMenuButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDownButton);
            this.ExitButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUpButton);
            // 
            // ProfessorSay
            // 
            this.ProfessorSay.AutoSize = true;
            this.ProfessorSay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ProfessorSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessorSay.ForeColor = System.Drawing.Color.White;
            this.ProfessorSay.Location = new System.Drawing.Point(471, 88);
            this.ProfessorSay.MinimumSize = new System.Drawing.Size(138, 110);
            this.ProfessorSay.Name = "ProfessorSay";
            this.ProfessorSay.Size = new System.Drawing.Size(138, 110);
            this.ProfessorSay.TabIndex = 32;
            this.ProfessorSay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProfessorSay.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Controls.Add(this.Prog4);
            this.groupBox2.Controls.Add(this.Prog3);
            this.groupBox2.Controls.Add(this.Prog2);
            this.groupBox2.Controls.Add(this.Prog1);
            this.groupBox2.Controls.Add(this.AudiVoteLabel);
            this.groupBox2.Controls.Add(this.LettersLabel);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(375, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 158);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Помощь зала";
            this.groupBox2.Visible = false;
            // 
            // Prog4
            // 
            this.Prog4.ForeColor = System.Drawing.Color.Chartreuse;
            this.Prog4.Location = new System.Drawing.Point(65, 129);
            this.Prog4.Name = "Prog4";
            this.Prog4.Size = new System.Drawing.Size(186, 23);
            this.Prog4.TabIndex = 5;
            this.Prog4.Visible = false;
            // 
            // Prog3
            // 
            this.Prog3.ForeColor = System.Drawing.Color.Chartreuse;
            this.Prog3.Location = new System.Drawing.Point(65, 93);
            this.Prog3.Name = "Prog3";
            this.Prog3.Size = new System.Drawing.Size(186, 23);
            this.Prog3.TabIndex = 4;
            this.Prog3.Visible = false;
            // 
            // Prog2
            // 
            this.Prog2.ForeColor = System.Drawing.Color.Chartreuse;
            this.Prog2.Location = new System.Drawing.Point(65, 57);
            this.Prog2.Name = "Prog2";
            this.Prog2.Size = new System.Drawing.Size(186, 23);
            this.Prog2.TabIndex = 3;
            this.Prog2.Visible = false;
            // 
            // Prog1
            // 
            this.Prog1.ForeColor = System.Drawing.Color.Chartreuse;
            this.Prog1.Location = new System.Drawing.Point(65, 19);
            this.Prog1.Name = "Prog1";
            this.Prog1.Size = new System.Drawing.Size(186, 23);
            this.Prog1.TabIndex = 2;
            this.Prog1.Visible = false;
            // 
            // AudiVoteLabel
            // 
            this.AudiVoteLabel.AutoSize = true;
            this.AudiVoteLabel.ForeColor = System.Drawing.Color.Maroon;
            this.AudiVoteLabel.Location = new System.Drawing.Point(30, 19);
            this.AudiVoteLabel.Name = "AudiVoteLabel";
            this.AudiVoteLabel.Size = new System.Drawing.Size(0, 13);
            this.AudiVoteLabel.TabIndex = 1;
            this.AudiVoteLabel.Visible = false;
            // 
            // LettersLabel
            // 
            this.LettersLabel.AutoSize = true;
            this.LettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LettersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LettersLabel.Location = new System.Drawing.Point(6, 19);
            this.LettersLabel.Name = "LettersLabel";
            this.LettersLabel.Size = new System.Drawing.Size(20, 130);
            this.LettersLabel.TabIndex = 0;
            this.LettersLabel.Text = "A:\r\n\r\n\r\nB:\r\n\r\n\r\nC:\r\n\r\n\r\nD:";
            this.LettersLabel.Visible = false;
            // 
            // LooseLabel
            // 
            this.LooseLabel.AutoSize = true;
            this.LooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.LooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LooseLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.LooseLabel.Location = new System.Drawing.Point(355, 385);
            this.LooseLabel.Name = "LooseLabel";
            this.LooseLabel.Size = new System.Drawing.Size(187, 33);
            this.LooseLabel.TabIndex = 35;
            this.LooseLabel.Text = "Поражение!";
            this.LooseLabel.Visible = false;
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.WinLabel.Location = new System.Drawing.Point(335, 315);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(168, 42);
            this.WinLabel.TabIndex = 37;
            this.WinLabel.Text = "Победа!";
            this.WinLabel.Visible = false;
            // 
            // WinImage
            // 
            this.WinImage.Image = Resource1.Vifrash;
            this.WinImage.Location = new System.Drawing.Point(24, 148);
            this.WinImage.Name = "WinImage";
            this.WinImage.Size = new System.Drawing.Size(806, 456);
            this.WinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinImage.TabIndex = 36;
            this.WinImage.TabStop = false;
            this.WinImage.Visible = false;
            // 
            // LooseImage
            // 
            this.LooseImage.Image = Resource1._12122;
            this.LooseImage.Location = new System.Drawing.Point(24, 149);
            this.LooseImage.Name = "LooseImage";
            this.LooseImage.Size = new System.Drawing.Size(806, 455);
            this.LooseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LooseImage.TabIndex = 34;
            this.LooseImage.TabStop = false;
            this.LooseImage.Visible = false;
            // 
            // Professor
            // 
            this.Professor.Image = Resource1.zvonok;
            this.Professor.Location = new System.Drawing.Point(332, 88);
            this.Professor.Name = "Professor";
            this.Professor.Size = new System.Drawing.Size(138, 110);
            this.Professor.TabIndex = 31;
            this.Professor.TabStop = false;
            this.Professor.Visible = false;
            // 
            // GalkinFalse
            // 
            this.GalkinFalse.AutoSize = true;
            this.GalkinFalse.Image = Resource1.Galkin;
            this.GalkinFalse.Location = new System.Drawing.Point(26, 223);
            this.GalkinFalse.MinimumSize = new System.Drawing.Size(80, 100);
            this.GalkinFalse.Name = "GalkinFalse";
            this.GalkinFalse.Size = new System.Drawing.Size(80, 100);
            this.GalkinFalse.TabIndex = 25;
            this.GalkinFalse.Visible = false;
            // 
            // GalkinTrue
            // 
            this.GalkinTrue.AutoSize = true;
            this.GalkinTrue.Image = Resource1.Galkin;
            this.GalkinTrue.Location = new System.Drawing.Point(694, 223);
            this.GalkinTrue.MinimumSize = new System.Drawing.Size(80, 100);
            this.GalkinTrue.Name = "GalkinTrue";
            this.GalkinTrue.Size = new System.Drawing.Size(80, 100);
            this.GalkinTrue.TabIndex = 24;
            this.GalkinTrue.Visible = false;
            // 
            // BackGroundImage
            // 
            this.BackGroundImage.AutoSize = true;
            this.BackGroundImage.Image = Resource1.mil;
            this.BackGroundImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackGroundImage.Location = new System.Drawing.Point(-2, 24);
            this.BackGroundImage.MinimumSize = new System.Drawing.Size(793, 594);
            this.BackGroundImage.Name = "BackGroundImage";
            this.BackGroundImage.Size = new System.Drawing.Size(793, 594);
            this.BackGroundImage.TabIndex = 1;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.WinImage);
            this.Controls.Add(this.LooseLabel);
            this.Controls.Add(this.LooseImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProfessorSay);
            this.Controls.Add(this.Professor);
            this.Controls.Add(this.SpaceButtonLabel);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TitleTrue);
            this.Controls.Add(this.TitleFalse);
            this.Controls.Add(this.GalkinFalse);
            this.Controls.Add(this.GalkinTrue);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step3);
            this.Controls.Add(this.step4);
            this.Controls.Add(this.step5);
            this.Controls.Add(this.step6);
            this.Controls.Add(this.step7);
            this.Controls.Add(this.step8);
            this.Controls.Add(this.step9);
            this.Controls.Add(this.step10);
            this.Controls.Add(this.step11);
            this.Controls.Add(this.step12);
            this.Controls.Add(this.step13);
            this.Controls.Add(this.step14);
            this.Controls.Add(this.step15);
            this.Controls.Add(this.BackGroundImage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кто хочет стать миллионером?";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LooseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Professor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GameMenuButton;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuButton;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QManagerMenuButton;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuButton;
        private System.Windows.Forms.Label BackGroundImage;
        private System.Windows.Forms.Label step15;
        private System.Windows.Forms.Label step14;
        private System.Windows.Forms.Label step13;
        private System.Windows.Forms.Label step12;
        private System.Windows.Forms.Label step11;
        private System.Windows.Forms.Label step10;
        private System.Windows.Forms.Label step9;
        private System.Windows.Forms.Label step8;
        private System.Windows.Forms.Label step7;
        private System.Windows.Forms.Label step6;
        private System.Windows.Forms.Label step5;
        private System.Windows.Forms.Label step4;
        private System.Windows.Forms.Label step3;
        private System.Windows.Forms.Label step2;
        private System.Windows.Forms.Label step1;
        private System.Windows.Forms.Button Help50Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HelpCallButton;
        private System.Windows.Forms.Button HelpAudiButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.Label Answer3;
        private System.Windows.Forms.Label Answer4;
        private System.Windows.Forms.Label GalkinTrue;
        private System.Windows.Forms.Label GalkinFalse;
        private System.Windows.Forms.Label TitleFalse;
        private System.Windows.Forms.Label TitleTrue;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NewGameButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label SpaceButtonLabel;
        private ToolTip t;
        private PictureBox Professor;
        private Label ProfessorSay;
        private GroupBox groupBox2;
       
        private Label AudiVoteLabel;
        private Label LettersLabel;
        private PictureBox LooseImage;
        private Label LooseLabel;
        private PictureBox WinImage;
        private Label WinLabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
    }
}

