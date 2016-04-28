using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using View;
using View.Events;

namespace Presenters
{
    public class ManagerPresenter
    {
        IManager _view;
        IModel _model;
        public ManagerPresenter(IManager View, IModel Model)
        {
            _view = View;
            _model = Model;
            _view.UpdateList += new EventHandler<UpdateEvent>(UpdateListBox);
            _view.AddQuestion += new EventHandler<AddQuestionEvent>(AddQuestion);
            _view.EditQuestion += new EventHandler<EditQuestionEvent>(EditQuestion);
            _view.DeleteQuestion += new EventHandler<DeleteQuestionEvent>(DeleteQuestion);
            _view.GetQuestion += new EventHandler<GetQuestionEvent>(GetQuestion);
        }

        private void UpdateListBox(object sender, UpdateEvent e)
        {
            _model.LoadData();
            _view.listBox1.Items.Clear();
            foreach(Questions q in _model.Elements)
            {
                _view.listBox1.Items.Add(q.Text);
            }
        }

        private void AddQuestion(object sender, AddQuestionEvent e)
        {
            _model.Add(_view.QuestionText.Text, new string[] { _view.Answer1Text.Text, _view.Answer2Text.Text, 
                _view.Answer3Text.Text, _view.Answer4Text.Text});
        }
        private void EditQuestion(object sender, EditQuestionEvent e)
        {
            _model.Edit(_view.listBox1.SelectedIndex, _view.QuestionText.Text, new string[] { _view.Answer1Text.Text, _view.Answer2Text.Text, 
                _view.Answer3Text.Text, _view.Answer4Text.Text});
        }

        private void DeleteQuestion(object sender, DeleteQuestionEvent e)
        {
            _model.Delete(_view.listBox1.SelectedIndex);
        }
        private void GetQuestion(object sender, GetQuestionEvent e)
        {
            _view.QuestionText.Text=_model[_view.listBox1.SelectedIndex].Text;
            _view.Answer1Text.Text=_model[_view.listBox1.SelectedIndex].RightAnswer;
            _view.Answer2Text.Text=_model[_view.listBox1.SelectedIndex].Answer2;
            _view.Answer3Text.Text=_model[_view.listBox1.SelectedIndex].Answer3;
            _view.Answer4Text.Text = _model[_view.listBox1.SelectedIndex].Answer4;
        }
    }
}
