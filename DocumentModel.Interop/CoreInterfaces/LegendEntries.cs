using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of legend entries.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia
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
  /// <summary>
  /// Gets a legend entry by index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries.item?view=office-pia
  /// </remarks>
  public LegendEntry this[object Index] { get; }
}
