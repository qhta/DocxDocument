
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents chart data.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata?view=office-pia"/>
public partial interface IChartData: IModelObject
{
  /// <summary>
  /// Activates chart data editing.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.activate?view=office-pia"/>
  public void Activate();
  /// <summary>
  /// Breaks the link to the source data.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.breaklink?view=office-pia"/>
  public void BreakLink();
  /// <summary>
  /// Activates the chart data window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartdata.activatechartdatawindow?view=office-pia"/>
  public void ActivateChartDataWindow();
}

