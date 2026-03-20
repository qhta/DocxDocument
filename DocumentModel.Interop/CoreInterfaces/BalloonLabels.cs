using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of BalloonLabel objects that represent all labels in the Office Assistant balloon.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabels?view=office-pia
/// </remarks>
public partial interface BalloonLabels: InteropCollection<object>
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabels.name?view=office-pia
  /// </remarks>
  public string Name { get; }
}
