namespace DocumentModel.Drawing;

/// <summary>
/// Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITextShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapeStyle))]
public interface IShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public DocumentModel.Drawing.INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Shape.
  /// </summary>
  public ITextShape? TextShape { get ; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public DocumentModel.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
