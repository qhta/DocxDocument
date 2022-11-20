namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRadarChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRadarChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRadarStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public class RadarChart: IRadarChart
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public IRadarStyle? RadarStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors
  {
    get;
    set;
  }
  
}
