using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SeriesCollection` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection?view=office-pia` for Office interop details.
/// </remarks>
public partial class SeriesCollection: InteropCollection<MsoSeries>
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
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.add?view=office-pia"/>
  public MsoSeries Add(object Source, RowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Extend`.
  /// </summary>
  /// <param name="Source">The `Source` parameter.</param>
  /// <param name="Rowcol">The `Rowcol` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.extend?view=office-pia"/>
  public object Extend(object Source, object Rowcol, object CategoryLabels) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <param name="Rowcol">The `Rowcol` parameter.</param>
  /// <param name="SeriesLabels">The `SeriesLabels` parameter.</param>
  /// <param name="CategoryLabels">The `CategoryLabels` parameter.</param>
  /// <param name="Replace">The `Replace` parameter.</param>
  /// <param name="NewSeries">The `NewSeries` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.paste?view=office-pia"/>
  public object Paste
  (RowCol Rowcol, object SeriesLabels, object CategoryLabels, object Replace,
    object NewSeries) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `NewSeries`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.seriescollection.newseries?view=office-pia"/>
  public MsoSeries NewSeries() { throw new NotImplementedException(); }
}

