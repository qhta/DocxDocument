
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart legend.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend?view=office-pia
/// </remarks>
public partial interface IMsoLegend
{
  /// <summary>
  /// Selects the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Returns legend entries.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.legendentries?view=office-pia
  /// </remarks>
  public object LegendEntries(object Index);
  /// <summary>
  /// Clears the legend.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsolegend.clear?view=office-pia
  /// </remarks>
  public object Clear();
}
