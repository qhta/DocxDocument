namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Connection Shape.
/// </summary>
public class ConnectionShape: ModelElement
{
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  public string? Macro { get; set; }
  /// <summary>
  ///   Publish to Server
  /// </summary>
  public bool? Published { get; set; }
  /// <summary>
  ///   Connector Non Visual Properties.
  /// </summary>
  public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get; set; }
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }
  /// <summary>
  ///   Connection Shape Style.
  /// </summary>
  public Style? Style { get; set; }
}