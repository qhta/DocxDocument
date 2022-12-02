namespace DocumentModel.Drawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public interface INonVisualConnectorShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }
  
}
