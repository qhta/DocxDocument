namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the LeaderLines Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public class LeaderLines: ILeaderLines
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
