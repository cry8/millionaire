using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;
using Model;
using View;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                IMainView MainWin = new MainUI();
                IModel MainModel = new DataIO();
                MainModel.LoadData();
                IManager Manager = new QuestionManager();
                MainWin.SetManager(Manager);
                MainPresenter presenter1 = new MainPresenter(MainWin, MainModel);
                ManagerPresenter presenter2 = new ManagerPresenter(Manager, MainModel);
                ((MainUI)MainWin).ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
