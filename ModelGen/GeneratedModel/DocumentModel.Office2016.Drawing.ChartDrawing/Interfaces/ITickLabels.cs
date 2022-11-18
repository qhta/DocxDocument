namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the TickLabels Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
public interface ITickLabels // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
