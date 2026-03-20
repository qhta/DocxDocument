
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart data.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata?view=office-pia
/// </remarks>
public partial interface IMsoChartData
{
  /// <summary>
  /// Activates chart data editing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.activate?view=office-pia
  /// </remarks>
  public void Activate();
  /// <summary>
  /// Breaks the link to the source data.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.breaklink?view=office-pia
  /// </remarks>
  public void BreakLink();
  /// <summary>
  /// Activates the chart data window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.activatechartdatawindow?view=office-pia
  /// </remarks>
  public void ActivateChartDataWindow();
}
