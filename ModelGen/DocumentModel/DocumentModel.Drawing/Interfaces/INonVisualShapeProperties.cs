namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public interface INonVisualShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
