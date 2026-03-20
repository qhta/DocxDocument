using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a label in the Office Assistant balloon.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel?view=office-pia
/// </remarks>
public partial interface BalloonLabel: InteropObject
{
  /// <summary>
  /// Gets the item associated with the label.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel.item?view=office-pia
  /// </remarks>
  public string Item { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
}
