namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SeriesLines Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public class SeriesLines: ISeriesLines
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
