using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Microsoft Office Assistant.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant?view=office-pia"/>
public interface IAssistant: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.top?view=office-pia"/>
  public int Top { get; set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.left?view=office-pia"/>
  public int Left { get; set; }
  /// <summary>
  /// Gets the `NewBalloon` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.newballoon?view=office-pia"/>
  public IBalloon NewBalloon { get; }
  /// <summary>
  /// Gets the `BalloonError` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.balloonerror?view=office-pia"/>
  public BalloonErrorType BalloonError { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.visible?view=office-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Animation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.animation?view=office-pia"/>
  public AnimationType Animation { get; set; }
  /// <summary>
  /// Gets or sets the `Reduced` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.reduced?view=office-pia"/>
  public bool Reduced { get; set; }
  /// <summary>
  /// Gets or sets the `AssistWithHelp` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.assistwithhelp?view=office-pia"/>
  public bool AssistWithHelp { get; set; }
  /// <summary>
  /// Gets or sets the `AssistWithWizards` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.assistwithwizards?view=office-pia"/>
  public bool AssistWithWizards { get; set; }
  /// <summary>
  /// Gets or sets the `AssistWithAlerts` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.assistwithalerts?view=office-pia"/>
  public bool AssistWithAlerts { get; set; }
  /// <summary>
  /// Gets or sets the `MoveWhenInTheWay` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.movewhenintheway?view=office-pia"/>
  public bool MoveWhenInTheWay { get; set; }
  /// <summary>
  /// Gets or sets the `Sounds` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.sounds?view=office-pia"/>
  public bool Sounds { get; set; }
  /// <summary>
  /// Gets or sets the `FeatureTips` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.featuretips?view=office-pia"/>
  public bool FeatureTips { get; set; }
  /// <summary>
  /// Gets or sets the `MouseTips` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.mousetips?view=office-pia"/>
  public bool MouseTips { get; set; }
  /// <summary>
  /// Gets or sets the `KeyboardShortcutTips` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.keyboardshortcuttips?view=office-pia"/>
  public bool KeyboardShortcutTips { get; set; }
  /// <summary>
  /// Gets or sets the `HighPriorityTips` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.highprioritytips?view=office-pia"/>
  public bool HighPriorityTips { get; set; }
  /// <summary>
  /// Gets or sets the `TipOfDay` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.tipofday?view=office-pia"/>
  public bool TipOfDay { get; set; }
  /// <summary>
  /// Gets or sets the `GuessHelp` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.guesshelp?view=office-pia"/>
  public bool GuessHelp { get; set; }
  /// <summary>
  /// Gets or sets the `SearchWhenProgramming` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.searchwhenprogramming?view=office-pia"/>
  public bool SearchWhenProgramming { get; set; }
  /// <summary>
  /// Gets the `Item` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.item?view=office-pia"/>
  public string Item { get; }
  /// <summary>
  /// Gets or sets the `FileName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.filename?view=office-pia"/>
  public string FileName { get; set; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `On` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.on?view=office-pia"/>
  public bool On { get; set; }


  #region methods

/// <summary>
  /// Moves the Office Assistant to the specified screen coordinates.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.move?view=office-pia"/>
  public void Move(int xLeft, int yTop);
  /// <summary>
  /// Displays Help for the Office Assistant.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.help?view=office-pia"/>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.startwizard?view=office-pia"/>
  public int StartWizard
  (bool On, string Callback, int PrivateX, object Animation, object CustomTeaser, object Top, object Left,
    object Bottom, object Right);
  /// <summary>
  /// Ends a wizard session.
  /// </summary>
  /// <param name="wizardID">The `WizardID` parameter.</param>
  /// <param name="varfSuccess">The `varfSuccess` parameter.</param>
  /// <param name="animation">The `Animation` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.endwizard?view=office-pia"/>
  public void EndWizard(int wizardID, bool varfSuccess, object animation);
  /// <summary>
  /// Activates a wizard action for an existing wizard session.
  /// </summary>
  /// <param name="wizardID">The `WizardID` parameter.</param>
  /// <param name="act">The `act` parameter.</param>
  /// <param name="animation">The `Animation` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.activatewizard?view=office-pia"/>
  public void ActivateWizard(int wizardID, WizardActType act, object animation);
  /// <summary>
  /// Resets the Assistant tips so they can be shown again.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.resettips?view=office-pia"/>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.doalert?view=office-pia"/>
  public int DoAlert
  (string bstrAlertTitle, string bstrAlertText, AlertButtonType alb, AlertIconType alc, AlertDefaultType ald,
    AlertCancelType alq, bool varfSysAlert);

  #endregion methods
}

