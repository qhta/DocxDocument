namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOverlay))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILayout))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILegendEntry))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILegendPosition))]
public class Legend: ILegend
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILegendPosition? LegendPosition
  {
    get;
    set;
  }
  
}
