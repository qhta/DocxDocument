
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoLegend` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoLegend
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `LegendEntries`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.legendentries?view=office-pia
  /// </remarks>
  public object LegendEntries(object Index);
  /// <summary>
  /// Invokes `Clear`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.clear?view=office-pia
  /// </remarks>
  public object Clear();
}
