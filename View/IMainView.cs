using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Events;

namespace View
{
    public interface IMainView
    {
        event EventHandler<ActivateAnswersEvent> ActivateAnswers;
        event EventHandler<MiddleTipEvent> MakeMiddle;
        event EventHandler<StartChoiceEvent> StartChoice;
        event EventHandler<NewGameEvent> ENewGame;
        event EventHandler<ActivatePlayerEvent> EActivatePlayer;
        event EventHandler<PhoneCallStringEvent> PhoneCallString;
        event EventHandler<StartPhoneCallEvent> StartPhoneCall;
        event EventHandler<StartAudienceEvent> StartAudience;
        event EventHandler<HighLightEvent> EHighLight;
        int RightLabelNumber { get; set; }
        void SetManager(IManager manager);
        ProgressBar Prog4 { get; set; }
        ProgressBar Prog3 { get; set; }
        ProgressBar Prog2 { get; set; }
        ProgressBar Prog1 { get; set; }
        void InvokeAction(Action act);
        void InvokeAction(Delegate act, int param);
        void SetVoteLabel(string Text);
        void ShowAudienceVote(bool flag);
        void ActivatePlayer(bool flag);
        void ActivateAnswer(int index, bool flag);
        void ActivatePhoneCall(bool flag);
        void EnableAnswer(int index, bool flag);
        void ShowQuestion(string Text, string[] Answers);
        void InitWin();
        void RefreshSteps();
        void ActivateStep(int index);
        void ClearField();
        bool MakeQuestion(string Text);
        void HighLight(object label);
        void HighLight(int LabelIndex);
        void PlaySound(string Filename);
        void RestoreHelpButtons();
        void ShowLooseImage(bool flag);
        void HighLightAnswer(object label, bool AnswerStatus);
        void NewGame();
        void SetProfessorsTip(string Text);
    }
}
