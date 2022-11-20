namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredBarSeries))]
public class BarChartExtension: IBarChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
