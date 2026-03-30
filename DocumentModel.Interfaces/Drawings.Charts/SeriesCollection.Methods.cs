using System.Collections;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents the `SeriesCollection` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISeriesCollection: IModelCollection<ISeries>
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="RowCol">The `Rowcol` parameter.</param>
  /// <param name="SeriesLabels">The `SeriesLabels` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.add?view=office-pia"/>
  public ISeries Add
    (object Source, XlRowCol RowCol, object SeriesLabels, object CategoryLabels, object Replace);
  /// <summary>
  /// Invokes `Extend`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="RowCol">The `Rowcol` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.extend?view=office-pia"/>
  public object Extend(object Source, object RowCol, object CategoryLabels);
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <param name="RowCol">The `Rowcol` parameter.</param>
  /// <param name="SeriesLabels">The `SeriesLabels` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <param name="NewSeries">The `NewSeries` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.paste?view=office-pia"/>
  public object Paste (XlRowCol RowCol, object SeriesLabels, object CategoryLabels, object Replace, object NewSeries);
  /// <summary>
  /// Invokes `NewSeries`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.newseries?view=office-pia"/>
  public ISeries NewSeries();
}

