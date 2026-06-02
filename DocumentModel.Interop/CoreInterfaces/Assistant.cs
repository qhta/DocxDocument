using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Microsoft Office Assistant.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant?view=office-pia"/>
public partial interface IAssistant: IInteropObject
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
  public Balloon NewBalloon { get; }
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
}

