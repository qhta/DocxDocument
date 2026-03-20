
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart group.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup?view=office-pia
/// </remarks>
public partial interface IMsoChartGroup
{
  /// <summary>
  /// Returns a series collection from the chart group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.seriescollection?view=office-pia
  /// </remarks>
  public object SeriesCollection(object Index);
  /// <summary>
  /// Returns a category collection from the chart group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.categorycollection?view=office-pia
  /// </remarks>
  public object CategoryCollection(object Index);
  /// <summary>
  /// Returns a full category collection from the chart group.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.fullcategorycollection?view=office-pia
  /// </remarks>
  public object FullCategoryCollection(object Index);
}
