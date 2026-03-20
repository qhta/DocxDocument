using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `LegendEntries` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia` for Office interop details.
/// </remarks>
public partial interface LegendEntries
{
  /// <summary>
  /// Invokes `GetEnumerator`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
