namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Series objects in the specified chart or chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection?view=word-pia"/>
public partial class SeriesCollection : InteropCollection<Series>
{


  #region methods

/// <summary>
  /// Adds a new series to the collection.
  /// </summary>
  /// <param name="source">The data source for the series.</param>
  /// <param name="rowCol">Specifies whether the data is in rows or columns.</param>
  /// <param name="seriesLabels">Indicates if the first row or column contains series labels.</param>
  /// <param name="categoryLabels">Indicates if the first row or column contains category labels.</param>
  /// <param name="replace">true to replace existing data; otherwise, false.</param>
  /// <returns>The created <see cref="Series"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection.add?view=word-pia"/>
  public Series Add(object source, RowCol rowCol, object seriesLabels, object categoryLabels, object replace) { throw new NotImplementedException(); }

  /// <summary>
  /// Extends the series collection with additional data.
  /// </summary>
  /// <param name="source">The data source to extend with.</param>
  /// <param name="rowCol">Specifies whether the data is in rows or columns.</param>
  /// <param name="categoryLabels">Indicates if the first row or column contains category labels.</param>
  /// <returns>An object value returned by the underlying COM call.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection.extend?view=word-pia"/>
  public object Extend(object source, object rowCol, object categoryLabels) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a new series in the collection.
  /// </summary>
  /// <returns>The created <see cref="Series"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.seriescollection.newseries?view=word-pia"/>
  public Series NewSeries() { throw new NotImplementedException(); }

  #endregion methods
}
