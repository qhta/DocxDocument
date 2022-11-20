namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubble3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShowNegativeBubbles))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubbleChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubbleScale))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubbleChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISizeRepresents))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public interface IBubbleChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
