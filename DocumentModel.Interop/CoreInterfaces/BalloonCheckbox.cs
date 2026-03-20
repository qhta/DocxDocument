using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a check box in the Office Assistant balloon.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox?view=office-pia
/// </remarks>
public partial interface BalloonCheckbox: InteropObject
{
  /// <summary>
  /// Gets the item text associated with the check box.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.item?view=office-pia
  /// </remarks>
  public string Item { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Checked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.checked?view=office-pia
  /// </remarks>
  public bool Checked { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
}
