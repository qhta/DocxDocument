namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public partial class NonVisualConnectorShapeDrawingProperties
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get; set; }
  
}
