using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SeriesCollection` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SeriesCollection: InteropCollection<IMsoSeries>
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="Rowcol">The `Rowcol` parameter.</param>
  /// <param name="SeriesLabels">The `SeriesLabels` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.add?view=office-pia
  /// </remarks>
  public IMsoSeries Add
    (object Source, XlRowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace);
  /// <summary>
  /// Invokes `Extend`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="Rowcol">The `Rowcol` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.extend?view=office-pia
  /// </remarks>
  public object Extend(object Source, object Rowcol, object CategoryLabels);
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <param name="Rowcol">The `Rowcol` parameter.</param>
  /// <param name="SeriesLabels">The `SeriesLabels` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <param name="NewSeries">The `NewSeries` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.paste?view=office-pia
  /// </remarks>
  public object Paste
  (XlRowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace,
    object NewSeries);
  /// <summary>
  /// Invokes `NewSeries`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.newseries?view=office-pia
  /// </remarks>
  public IMsoSeries NewSeries();
}
