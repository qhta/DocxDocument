namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public interface INonVisualConnectorShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
}
