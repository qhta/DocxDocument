namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface INonVisualContentPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
