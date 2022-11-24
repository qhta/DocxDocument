namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface INonVisualContentPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
