namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IBarChartSeries))]
public class FilteredBarSeries: IFilteredBarSeries
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IBarChartSeries? BarChartSeries
  {
    get;
    set;
  }
  
}
