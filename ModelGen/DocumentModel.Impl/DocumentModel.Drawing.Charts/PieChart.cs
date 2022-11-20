namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFirstSliceAngle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieChartSeries))]
public class PieChart: IPieChart
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors
  {
    get;
    set;
  }
  
}
