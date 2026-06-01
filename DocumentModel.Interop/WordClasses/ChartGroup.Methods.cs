namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup?view=word-pia"/>
public partial class ChartGroup
{
  /// <summary>
  /// Returns one series or all series in the chart group.
  /// </summary>
  /// <param name="Index">The series index, or an empty value to return the full collection.</param>
  /// <returns>A series object or series collection, depending on <paramref name="Index"/>.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroup.seriescollection?view=word-pia"/>
  public object SeriesCollection(object Index) { throw new NotImplementedException(); }
}
