namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredRadarSeries))]
public class RadarChartExtension: IRadarChartExtension
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
