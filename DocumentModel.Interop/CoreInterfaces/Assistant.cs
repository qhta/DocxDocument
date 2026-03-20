using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Assistant: InteropObject
{
  void Move(int xLeft, int yTop);
  int Top { get; set; }
  int Left { get; set; }
  void Help();

  int StartWizard
  (bool On, string Callback, int PrivateX, object Animation, object CustomTeaser, object Top, object Left,
    object Bottom, object Right);

  void EndWizard(int WizardID, bool varfSuccess, object Animation);
  void ActivateWizard(int WizardID, MsoWizardActType act, object Animation);
  void ResetTips();
  Balloon NewBalloon { get; }
  MsoBalloonErrorType BalloonError { get; }
  bool Visible { get; set; }
  MsoAnimationType Animation { get; set; }
  bool Reduced { get; set; }
  bool AssistWithHelp { get; set; }
  bool AssistWithWizards { get; set; }
  bool AssistWithAlerts { get; set; }
  bool MoveWhenInTheWay { get; set; }
  bool Sounds { get; set; }
  bool FeatureTips { get; set; }
  bool MouseTips { get; set; }
  bool KeyboardShortcutTips { get; set; }
  bool HighPriorityTips { get; set; }
  bool TipOfDay { get; set; }
  bool GuessHelp { get; set; }
  bool SearchWhenProgramming { get; set; }
  string Item { get; }
  string FileName { get; set; }
  string Name { get; }
  bool On { get; set; }

  int DoAlert
  (string bstrAlertTitle, string bstrAlertText, MsoAlertButtonType alb, MsoAlertIconType alc, MsoAlertDefaultType ald,
    MsoAlertCancelType alq, bool varfSysAlert);
}