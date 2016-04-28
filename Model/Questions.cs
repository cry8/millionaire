namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questions
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Text { get; set; }

        [Required]
        [StringLength(200)]
        [Column("Answer1")]
        public string RightAnswer { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer2 { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer3 { get; set; }

        [Required]
        [StringLength(200)]
        public string Answer4 { get; set; }

        [NotMapped]
        private int mRightAnswerIndex;
        public enum Position { A, B, C, D };
        public Questions(int id, string Text, string RightAnswer, string[] Answers)
        {
            this.Text = Text;
            this.RightAnswer = RightAnswer;
            this.Answer2 = Answers[0];
            this.Answer3 = Answers[1];
            this.Answer4 = Answers[2];
            mRightAnswerIndex = 3;
            this.Id = id;
        }

        public Questions()
        {
            Text = "empty";
            this.Answer2 = "empty";
            this.Answer3 = "empty";
            this.Answer4 = "empty";
            RightAnswer = "empty";
            mRightAnswerIndex = -1;
        }
        public int Index()
        {
            return mRightAnswerIndex; 
        }
        public string[] Answers() { return Mix(); }
        private string[] Mix()
        {
            try
            {
                string[] temp = new string[4] { RightAnswer, Answer2, Answer3, Answer4 };
                Random random = new Random();
                int n = temp.Length;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    string value = temp[k];
                    temp[k] = temp[n];
                    temp[n] = value;
                }
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == RightAnswer)
                        mRightAnswerIndex = i;
                }
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] OriginalAnswers()
        {
            return new string[4] { Answer2, Answer3, Answer4, RightAnswer };
        }
    }
}
