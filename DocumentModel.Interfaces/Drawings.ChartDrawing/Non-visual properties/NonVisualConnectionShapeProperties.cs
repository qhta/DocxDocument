namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a connection shape in chart drawings, including shape locks and connection endpoints.
/// </summary>
public interface NonVisualConnectionShapeProperties : ExtendableElement
{
  /// <summary>
  /// Specifies locking options that restrict editing or manipulation of the connection shape.
  /// </summary>
  public ConnectionShapeLocks? ConnectionShapeLocks { get; set; }

  /// <summary>
  /// Defines the starting connection point for the connection shape.
  /// </summary>
  public ConnectionType? StartConnection { get; set; }

  /// <summary>
  /// Defines the ending connection point for the connection shape.
  /// </summary>
  public ConnectionType? EndConnection { get; set; }
}