namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IVaryColors))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IScatterChartExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IScatterChartSeries))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IScatterStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAxisId))]
public interface IScatterChart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public IScatterStyle? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
