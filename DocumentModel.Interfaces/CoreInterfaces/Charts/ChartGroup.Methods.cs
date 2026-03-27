
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a chart group.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup?view=office-pia"/>
public partial interface ChartGroup: InteropObject
{
  /// <summary>
  /// Returns a series collection from the chart group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.seriescollection?view=office-pia"/>
  public object SeriesCollection(object Index);
  /// <summary>
  /// Returns a category collection from the chart group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.categorycollection?view=office-pia"/>
  public object CategoryCollection(object Index);
  /// <summary>
  /// Returns a full category collection from the chart group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.fullcategorycollection?view=office-pia"/>
  public object FullCategoryCollection(object Index);
}

