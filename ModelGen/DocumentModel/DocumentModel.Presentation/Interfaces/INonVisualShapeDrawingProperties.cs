namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Drawing Properties for a Shape.
/// </summary>
public interface INonVisualShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Box
  /// </summary>
  public System.Boolean? TextBox { get ; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawing.IShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
