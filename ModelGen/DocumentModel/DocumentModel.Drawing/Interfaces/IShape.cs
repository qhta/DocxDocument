namespace DocumentModel.Drawing;

/// <summary>
/// Shape.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public INonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Shape.
  /// </summary>
  public ITextShape? TextShape { get ; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
