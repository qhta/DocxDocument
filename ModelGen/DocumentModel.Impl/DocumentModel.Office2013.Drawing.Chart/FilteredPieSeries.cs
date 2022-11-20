namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IPieChartSeries))]
public class FilteredPieSeries: IFilteredPieSeries
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IPieChartSeries? PieChartSeries
  {
    get;
    set;
  }
  
}
