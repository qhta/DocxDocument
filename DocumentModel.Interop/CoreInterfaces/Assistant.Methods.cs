using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Assistant
{
  public void Move(int xLeft, int yTop);
  public void Help();
  public int StartWizard
  (bool On, string Callback, int PrivateX, object Animation, object CustomTeaser, object Top, object Left,
    object Bottom, object Right);
  public void EndWizard(int WizardID, bool varfSuccess, object Animation);
  public void ActivateWizard(int WizardID, MsoWizardActType act, object Animation);
  public void ResetTips();
  public int DoAlert
  (string bstrAlertTitle, string bstrAlertText, MsoAlertButtonType alb, MsoAlertIconType alc, MsoAlertDefaultType ald,
    MsoAlertCancelType alq, bool varfSysAlert);
}
