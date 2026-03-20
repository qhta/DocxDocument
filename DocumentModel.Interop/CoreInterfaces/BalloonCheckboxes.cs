using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of BalloonCheckbox objects that represent all check boxes in the Office Assistant balloon.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckboxes?view=office-pia
/// </remarks>
public partial interface BalloonCheckboxes: InteropCollection<BalloonCheckbox>
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckboxes.name?view=office-pia
  /// </remarks>
  public string Name { get; }
}
