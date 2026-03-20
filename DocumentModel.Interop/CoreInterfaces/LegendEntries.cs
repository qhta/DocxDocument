using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `LegendEntries` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia` for Office interop details.
/// </remarks>
public partial interface LegendEntries: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  public LegendEntry this[object Index] { get; }
}
