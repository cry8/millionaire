using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace Model
{
    public class DataIO:IModel
    {
        QuestionModel db;
        public DataIO()
        {
            this.Elements = new List<Questions>();
        }

        #region IModel Implementation
        public List<Questions> Elements { get; set; }
        public void OpenConnection()
        {
            try
            {
                db = new QuestionModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            db.Dispose();
        }

        public IEnumerable<object[]> GetRow()
        {
            var questions = from q in db.Questions
                            select q;
            foreach (var q in questions)
            {
                yield return new object[] { q.Id, q.Text, q.RightAnswer, q.Answer2, q.Answer3, q.Answer4 };
            }
        }
        public void LoadData()
        {
            OpenConnection();
            try
            {
                Elements.Clear();
                foreach (object[] obj in GetRow())
                {
                    string ra;
                    Elements.Add(new Questions(Convert.ToInt32(obj[0]), Convert.ToString(obj[1]),
                        ra = Convert.ToString(obj[2]), new string[] { Convert.ToString(obj[3]), 
                            Convert.ToString(obj[4]), Convert.ToString(obj[5]), ra }
                        ));
                }

            }
            catch (Exception ex)
            {
                throw ex;
                //throw new Exception("Ошибка чтения вопросов!");
            }
        }
        public void Delete(int index)
        {
            try
            {
                int QId = Elements[index].Id;
                var Question = db.Questions.SingleOrDefault(b => b.Id == QId);
                if (Question != null)
                {
                    db.Questions.Remove(Question);
                    db.SaveChanges();
                    Elements.RemoveAt(index);
                }
                else
                    throw new Exception();
            }
            catch (Exception)
            {
                throw new Exception("Ошибка удаления");
            }
        }

        public void Add(string Text, string[] Answers)
        {
            try
            {
                var Question = new Questions();
                Question.Text = Text;
                Question.RightAnswer = Answers[0];
                Question.Answer2 = Answers[1];
                Question.Answer3 = Answers[2];
                Question.Answer4 = Answers[3];
                db.Questions.Add(Question);
                db.SaveChanges();
                Elements.Add(Question);
            }
            catch (Exception)
            {
                throw new Exception("Ошибка добавления!");
            }
        }

        public void Edit(int index, string Text, string[] Answers)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    int QId = Elements[index].Id;
                    var q = db.Questions.SingleOrDefault(b => b.Id == QId);
                    if (q != null)
                    {
                        q.Text = Text;
                        q.RightAnswer = Answers[0];
                        q.Answer2 = Answers[1];
                        q.Answer3 = Answers[2];
                        q.Answer4 = Answers[3];
                        db.SaveChanges();
                        transaction.Commit();
                        Elements.RemoveAt(index);
                        Elements.Insert(index, new Questions(index, Text, Answers[0], new string[]{ Answers[1], Answers[2],
                            Answers[3], Answers[0]}));
                    }
                    else
                        throw new Exception();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw new Exception("Ошибка редактирования!");
                }
            }
        }
        public Questions this[int index]
        {
            get
            {
                if (index < 0 || index >= Elements.Count)
                    throw new IndexOutOfRangeException();
                return Elements[index];
            }
            set
            {
                if (index < 0 || index >= Elements.Count)
                    throw new IndexOutOfRangeException();
                else
                    Edit(value.Id, value.Text, new string[] { value.RightAnswer, value.Answer2, value.Answer3, value.Answer4 });
            }
        }
        public int Count
        {
            get
            {
                return Elements.Count;
            }
        }
        #endregion
       
    }
}
