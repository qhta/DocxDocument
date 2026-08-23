namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents the full set of Series objects in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection?view=office-pia"/>
public partial interface IFullSeriesCollection : IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.count?view=office-pia"/>
  public int Count { get; }

  /// <summary>
  /// Gets a series by index.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection.item?view=office-pia"/>
  public ISeries this[object Index] { get; }
}

