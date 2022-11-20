namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IRadarChartSeries))]
public class FilteredRadarSeries: IFilteredRadarSeries
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IRadarChartSeries? RadarChartSeries
  {
    get;
    set;
  }
  
}
