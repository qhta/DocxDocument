namespace DocumentModel.Drawing;

/// <summary>
/// Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualConnectionShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeStyle))]
public interface IConnectionShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Connection Shape.
  /// </summary>
  public DocumentModel.Drawing.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
