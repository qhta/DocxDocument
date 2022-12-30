namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Connection Shape.
/// </summary>
public partial class ConnectionShape
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published { get; set; }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Style? Style { get; set; }
  
}
