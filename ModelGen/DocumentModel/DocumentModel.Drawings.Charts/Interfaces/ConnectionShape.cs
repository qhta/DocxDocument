namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Connection Shape.
/// </summary>
public interface ConnectionShape
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Connector Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Connection Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Charts.Style? Style { get ; set; }
  
}
