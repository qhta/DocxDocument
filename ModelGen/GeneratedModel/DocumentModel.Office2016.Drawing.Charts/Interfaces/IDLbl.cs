namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the DLbl Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDelete))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowLegendKey))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowValue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowCategoryName))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowSeriesName))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowPercent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowBubbleSize))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDLblExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabelPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILayout))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeparator))]
public interface IDLbl // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index { get ; set; }
  
}
