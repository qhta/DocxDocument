using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the collection of all chart points in a series.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia
/// </remarks>
public partial interface Points: IEnumerable
{
  /// <summary>
  /// Gets the number of points in the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  /// <summary>
  /// Gets a chart point at the specified index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points._default?view=office-pia
  /// </remarks>
  public ChartPoint this[int Index] { get; }
}
