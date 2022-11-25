namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public interface INonVisualDrawingShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
