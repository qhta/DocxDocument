
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the plot area of a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea?view=office-pia
/// </remarks>
public partial interface IMsoPlotArea
{
  /// <summary>
  /// Selects the plot area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Clears formatting from the plot area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
}
