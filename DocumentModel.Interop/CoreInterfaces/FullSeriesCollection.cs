using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the full set of Series objects in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection?view=office-pia
/// </remarks>
public partial interface FullSeriesCollection: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.count?view=office-pia
  /// </remarks>
  public int Count { get; }

  /// <summary>
  /// Gets a series by index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.item?view=office-pia
  /// </remarks>
  public IMsoSeries this[object Index] { get; }
}
