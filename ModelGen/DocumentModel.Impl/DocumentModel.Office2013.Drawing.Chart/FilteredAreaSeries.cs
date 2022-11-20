namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IAreaChartSeries))]
public class FilteredAreaSeries: IFilteredAreaSeries
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IAreaChartSeries? AreaChartSeries
  {
    get;
    set;
  }
  
}
