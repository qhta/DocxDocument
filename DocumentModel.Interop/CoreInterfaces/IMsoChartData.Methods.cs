
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoChartData` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoChartData
{
  /// <summary>
  /// Invokes `Activate`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.activate?view=office-pia
  /// </remarks>
  public void Activate();
  /// <summary>
  /// Invokes `BreakLink`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.breaklink?view=office-pia
  /// </remarks>
  public void BreakLink();
  /// <summary>
  /// Invokes `ActivateChartDataWindow`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.activatechartdatawindow?view=office-pia
  /// </remarks>
  public void ActivateChartDataWindow();
}
