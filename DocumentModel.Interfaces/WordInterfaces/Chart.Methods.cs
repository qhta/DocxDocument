namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart?view=word-pia"/>
public partial interface Chart
{
  /// <summary>
  /// Returns one or all chart groups in the chart.
  /// </summary>
  /// <param name="Index">The index number of the chart group, or an empty value to return all groups.</param>
  /// <returns>A chart group object or chart groups collection, depending on <paramref name="Index"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.get_chartgroups?view=word-pia"/>
  public object ChartGroups(object Index);

  /// <summary>
  /// Determines whether a chart axis exists.
  /// </summary>
  /// <param name="Index1">The axis group type.</param>
  /// <param name="Index2">The axis type.</param>
  /// <returns>True if the specified axis exists; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.get_hasaxis?view=word-pia"/>
  public object HasAxis(object Index1, object Index2);

  /// <summary>
  /// Returns a single series or the full series collection for the chart.
  /// </summary>
  /// <param name="Index">The series index, or an empty value to return the entire collection.</param>
  /// <returns>A series object or series collection, depending on <paramref name="Index"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chart.seriescollection?view=word-pia"/>
  public object SeriesCollection(object Index);
}
