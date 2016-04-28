using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Events;

namespace View
{
    public interface IManager
    {
        ListBox listBox1 { get; set; }
        TextBox QuestionText { get; set; }
        TextBox Answer1Text { get; set; }
        TextBox Answer2Text { get; set; }
        TextBox Answer3Text { get; set; }
        TextBox Answer4Text { get; set; }
        event EventHandler<UpdateEvent> UpdateList;
        event EventHandler<AddQuestionEvent> AddQuestion;
        event EventHandler<EditQuestionEvent> EditQuestion;
        event EventHandler<DeleteQuestionEvent> DeleteQuestion;
        event EventHandler<GetQuestionEvent> GetQuestion;
    }
}
