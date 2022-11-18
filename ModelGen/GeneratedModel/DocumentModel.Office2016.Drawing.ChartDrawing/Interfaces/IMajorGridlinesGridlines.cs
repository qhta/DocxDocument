namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
public interface IMajorGridlinesGridlines // : DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList { get ; set; }
  
}
