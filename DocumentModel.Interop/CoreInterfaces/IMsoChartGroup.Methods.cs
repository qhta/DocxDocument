
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoChartGroup` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoChartGroup
{
  /// <summary>
  /// Invokes `SeriesCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.seriescollection?view=office-pia
  /// </remarks>
  public object SeriesCollection(object Index);
  /// <summary>
  /// Invokes `CategoryCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.categorycollection?view=office-pia
  /// </remarks>
  public object CategoryCollection(object Index);
  /// <summary>
  /// Invokes `FullCategoryCollection`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartgroup.fullcategorycollection?view=office-pia
  /// </remarks>
  public object FullCategoryCollection(object Index);
}
