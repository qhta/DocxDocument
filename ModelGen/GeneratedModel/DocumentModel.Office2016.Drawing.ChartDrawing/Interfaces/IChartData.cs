namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IData))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExternalData))]
public interface IChartData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExternalData? ExternalData { get ; set; }
  
}
