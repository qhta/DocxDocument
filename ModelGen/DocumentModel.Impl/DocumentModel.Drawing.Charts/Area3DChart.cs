namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Area Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IArea3DChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAreaChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDropLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapDepth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGrouping))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public class Area3DChart: IArea3DChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public IGrouping? Grouping
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
