
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the balloon where the Office Assistant displays information.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon?view=office-pia
/// </remarks>
public partial interface Balloon: InteropObject
{
  /// <summary>
  /// Gets or sets the `Checkboxes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.checkboxes?view=office-pia
  /// </remarks>
  public object Checkboxes { get; }
  /// <summary>
  /// Gets the `Labels` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.labels?view=office-pia
  /// </remarks>
  public object Labels { get; }
  /// <summary>
  /// Gets or sets the `BalloonType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.balloontype?view=office-pia
  /// </remarks>
  public MsoBalloonType BalloonType { get; set; }
  /// <summary>
  /// Gets or sets the `Icon` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.icon?view=office-pia
  /// </remarks>
  public MsoIconType Icon { get; set; }
  /// <summary>
  /// Gets or sets the `Heading` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.heading?view=office-pia
  /// </remarks>
  public string Heading { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Mode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.mode?view=office-pia
  /// </remarks>
  public MsoModeType Mode { get; set; }
  /// <summary>
  /// Gets or sets the `Animation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.animation?view=office-pia
  /// </remarks>
  public MsoAnimationType Animation { get; set; }
  /// <summary>
  /// Gets or sets the `Button` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.button?view=office-pia
  /// </remarks>
  public MsoButtonSetType Button { get; set; }
  /// <summary>
  /// Gets or sets the `Callback` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.callback?view=office-pia
  /// </remarks>
  public string Callback { get; set; }
  /// <summary>
  /// Gets or sets the `Private` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.private?view=office-pia
  /// </remarks>
  public int Private { get; set; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.name?view=office-pia
  /// </remarks>
  public string Name { get; }
}
