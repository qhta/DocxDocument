namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeLocks))]
public interface INonVisualDrawingShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Box
  /// </summary>
  public bool? TextBox { get ; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public IShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
