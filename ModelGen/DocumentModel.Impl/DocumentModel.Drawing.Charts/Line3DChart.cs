namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDropLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapDepth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGrouping))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILine3DChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILineChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public class Line3DChart: ILine3DChart
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
