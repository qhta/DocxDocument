namespace DocumentModel.Interop;

public partial interface ChartGroup
{
  /// <summary>
  /// Returns one series or all series in the chart group.
  /// </summary>
  /// <param name="Index">The series index, or an empty value to return the full collection.</param>
  /// <returns>A series object or series collection, depending on <paramref name="Index"/>.</returns>
  public object SeriesCollection(object Index);
}
