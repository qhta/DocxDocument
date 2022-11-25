namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Properties for a Shape.
/// </summary>
public interface INonVisualShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
