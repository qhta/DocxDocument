using DocumentModel.Interop.Core;

namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection?view=word-pia"/>
public partial interface SeriesCollection
{
  /// <summary>
  /// Adds a new series to the collection.
  /// </summary>
  /// <param name="Source">The data source for the series.</param>
  /// <param name="RowCol">Specifies whether the data is in rows or columns.</param>
  /// <param name="SeriesLabels">Indicates if the first row or column contains series labels.</param>
  /// <param name="CategoryLabels">Indicates if the first row or column contains category labels.</param>
  /// <param name="Replace">true to replace existing data; otherwise, false.</param>
  /// <returns>The created <see cref="Series"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection.add?view=word-pia"/>
  public Series Add(object Source, XlRowCol RowCol, object SeriesLabels, object CategoryLabels, object Replace);

  /// <summary>
  /// Extends the series collection with additional data.
  /// </summary>
  /// <param name="Source">The data source to extend with.</param>
  /// <param name="RowCol">Specifies whether the data is in rows or columns.</param>
  /// <param name="CategoryLabels">Indicates if the first row or column contains category labels.</param>
  /// <returns>An object value returned by the underlying COM call.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection.extend?view=word-pia"/>
  public object Extend(object Source, object RowCol, object CategoryLabels);

  /// <summary>
  /// Creates a new series in the collection.
  /// </summary>
  /// <returns>The created <see cref="Series"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection.newseries?view=word-pia"/>
  public Series NewSeries();
}
