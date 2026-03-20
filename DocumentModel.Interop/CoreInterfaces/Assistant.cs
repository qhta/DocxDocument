using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Microsoft Office Assistant.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant?view=office-pia
/// </remarks>
public partial interface Assistant: InteropObject
{
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.top?view=office-pia
  /// </remarks>
  public int Top { get; set; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.left?view=office-pia
  /// </remarks>
  public int Left { get; set; }
  /// <summary>
  /// Gets the `NewBalloon` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.newballoon?view=office-pia
  /// </remarks>
  public Balloon NewBalloon { get; }
  /// <summary>
  /// Gets the `BalloonError` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.balloonerror?view=office-pia
  /// </remarks>
  public MsoBalloonErrorType BalloonError { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.visible?view=office-pia
  /// </remarks>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Animation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.animation?view=office-pia
  /// </remarks>
  public MsoAnimationType Animation { get; set; }
  /// <summary>
  /// Gets or sets the `Reduced` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.reduced?view=office-pia
  /// </remarks>
  public bool Reduced { get; set; }
  /// <summary>
  /// Gets or sets the `AssistWithHelp` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.assistwithhelp?view=office-pia
  /// </remarks>
  public bool AssistWithHelp { get; set; }
  /// <summary>
  /// Gets or sets the `AssistWithWizards` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.assistwithwizards?view=office-pia
  /// </remarks>
  public bool AssistWithWizards { get; set; }
  /// <summary>
  /// Gets or sets the `AssistWithAlerts` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.assistwithalerts?view=office-pia
  /// </remarks>
  public bool AssistWithAlerts { get; set; }
  /// <summary>
  /// Gets or sets the `MoveWhenInTheWay` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.movewhenintheway?view=office-pia
  /// </remarks>
  public bool MoveWhenInTheWay { get; set; }
  /// <summary>
  /// Gets or sets the `Sounds` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.sounds?view=office-pia
  /// </remarks>
  public bool Sounds { get; set; }
  /// <summary>
  /// Gets or sets the `FeatureTips` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.featuretips?view=office-pia
  /// </remarks>
  public bool FeatureTips { get; set; }
  /// <summary>
  /// Gets or sets the `MouseTips` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.mousetips?view=office-pia
  /// </remarks>
  public bool MouseTips { get; set; }
  /// <summary>
  /// Gets or sets the `KeyboardShortcutTips` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.keyboardshortcuttips?view=office-pia
  /// </remarks>
  public bool KeyboardShortcutTips { get; set; }
  /// <summary>
  /// Gets or sets the `HighPriorityTips` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.highprioritytips?view=office-pia
  /// </remarks>
  public bool HighPriorityTips { get; set; }
  /// <summary>
  /// Gets or sets the `TipOfDay` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.tipofday?view=office-pia
  /// </remarks>
  public bool TipOfDay { get; set; }
  /// <summary>
  /// Gets or sets the `GuessHelp` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.guesshelp?view=office-pia
  /// </remarks>
  public bool GuessHelp { get; set; }
  /// <summary>
  /// Gets or sets the `SearchWhenProgramming` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.searchwhenprogramming?view=office-pia
  /// </remarks>
  public bool SearchWhenProgramming { get; set; }
  /// <summary>
  /// Gets the `Item` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.item?view=office-pia
  /// </remarks>
  public string Item { get; }
  /// <summary>
  /// Gets or sets the `FileName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.filename?view=office-pia
  /// </remarks>
  public string FileName { get; set; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `On` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.assistant.on?view=office-pia
  /// </remarks>
  public bool On { get; set; }
}
