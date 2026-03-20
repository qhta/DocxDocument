using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Trendlines` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Trendlines: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  public IMsoTrendline this[object Index] { get; }
}
