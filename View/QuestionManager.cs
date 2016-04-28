using System;
using System.Windows.Forms;
using View.Events;

namespace View
{
    public partial class QuestionManager : Form, IManager
    {
        private bool ifEdit;

        #region IManager Implementation
        public ListBox listBox1 { get; set; }
        public TextBox QuestionText { get; set; }
        public TextBox Answer1Text { get; set; }
        public TextBox Answer2Text { get; set; }
        public TextBox Answer3Text { get; set; }
        public TextBox Answer4Text { get; set; }
        public event EventHandler<UpdateEvent> UpdateList;
        public event EventHandler<AddQuestionEvent> AddQuestion;
        public event EventHandler<EditQuestionEvent> EditQuestion;
        public event EventHandler<DeleteQuestionEvent> DeleteQuestion;
        public event EventHandler<GetQuestionEvent> GetQuestion;
        #endregion
        public QuestionManager()
        {
            InitializeComponent();
            ifEdit = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (QuestionText.Text == "" || Answer1Text.Text == "" || Answer2Text.Text == "" || Answer3Text.Text == "" ||
                Answer4Text.Text == "")
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (ifEdit == false)
                    AddQuestion(this, new AddQuestionEvent());
                else
                {
                    EditQuestion(this, new EditQuestionEvent());
                    ifEdit = false;
                    button1.Text = "Добавить";
                }
                QuestionText.Text = "";
                Answer1Text.Text = "";
                Answer2Text.Text = "";
                Answer3Text.Text = "";
                Answer4Text.Text = "";
                UpdateList(this, new UpdateEvent());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите вопрос!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                QuestionText.Text = "";
                Answer1Text.Text = "";
                Answer2Text.Text = "";
                Answer3Text.Text = "";
                Answer4Text.Text = "";
                button1.Text = "Добавить";
                ifEdit = false;
                DeleteQuestion(this, new DeleteQuestionEvent());
                UpdateList(this, new UpdateEvent());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Выберите вопрос!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GetQuestion(this, new GetQuestionEvent());
                button1.Text = "Сохранить";
                ifEdit = true;
            }
        }

        private void QuestionManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        void QuestionManager_Load(object sender, System.EventArgs e)
        {
            UpdateList(this, new UpdateEvent());
        }
    }
}
