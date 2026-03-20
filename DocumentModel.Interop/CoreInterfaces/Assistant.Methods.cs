using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Microsoft Office Assistant.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant?view=office-pia
/// </remarks>
public partial interface Assistant
{
  /// <summary>
  /// Moves the Office Assistant to the specified screen coordinates.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.move?view=office-pia
  /// </remarks>
  public void Move(int xLeft, int yTop);
  /// <summary>
  /// Displays Help for the Office Assistant.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.help?view=office-pia
  /// </remarks>
  public void Help();
  /// <summary>
  /// Starts the specified wizard and returns a wizard identifier.
  /// </summary>
  /// <param name="On">The `On` parameter.</param>
  /// <param name="Callback">The `Callback` parameter.</param>
  /// <param name="PrivateX">The `PrivateX` parameter.</param>
  /// <param name="Animation">The `Animation` parameter.</param>
  /// <param name="CustomTeaser">The `CustomTeaser` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Bottom">The `Bottom` parameter.</param>
  /// <param name="Right">The `Right` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.startwizard?view=office-pia
  /// </remarks>
  public int StartWizard
  (bool On, string Callback, int PrivateX, object Animation, object CustomTeaser, object Top, object Left,
    object Bottom, object Right);
  /// <summary>
  /// Ends a wizard session.
  /// </summary>
  /// <param name="WizardID">The `WizardID` parameter.</param>
  /// <param name="varfSuccess">The `varfSuccess` parameter.</param>
  /// <param name="Animation">The `Animation` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.endwizard?view=office-pia
  /// </remarks>
  public void EndWizard(int WizardID, bool varfSuccess, object Animation);
  /// <summary>
  /// Activates a wizard action for an existing wizard session.
  /// </summary>
  /// <param name="WizardID">The `WizardID` parameter.</param>
  /// <param name="act">The `act` parameter.</param>
  /// <param name="Animation">The `Animation` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.activatewizard?view=office-pia
  /// </remarks>
  public void ActivateWizard(int WizardID, MsoWizardActType act, object Animation);
  /// <summary>
  /// Resets the Assistant tips so they can be shown again.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.resettips?view=office-pia
  /// </remarks>
  public void ResetTips();
  /// <summary>
  /// Displays an alert and returns the selected action.
  /// </summary>
  /// <param name="bstrAlertTitle">The `bstrAlertTitle` parameter.</param>
  /// <param name="bstrAlertText">The `bstrAlertText` parameter.</param>
  /// <param name="alb">The `alb` parameter.</param>
  /// <param name="alc">The `alc` parameter.</param>
  /// <param name="ald">The `ald` parameter.</param>
  /// <param name="alq">The `alq` parameter.</param>
  /// <param name="varfSysAlert">The `varfSysAlert` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.doalert?view=office-pia
  /// </remarks>
  public int DoAlert
  (string bstrAlertTitle, string bstrAlertText, MsoAlertButtonType alb, MsoAlertIconType alc, MsoAlertDefaultType ald,
    MsoAlertCancelType alq, bool varfSysAlert);
}
