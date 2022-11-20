namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesLines))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICustomSplit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISplitPosition))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IGapWidth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOfPieType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISecondPieSize))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISplitType))]
public interface IOfPieChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public IOfPieType? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
