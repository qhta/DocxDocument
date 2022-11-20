namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPie3DChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieChartSeries))]
public class Pie3DChart: IPie3DChart
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
