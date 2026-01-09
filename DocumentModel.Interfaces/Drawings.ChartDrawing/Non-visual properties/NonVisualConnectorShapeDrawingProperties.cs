namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for connector shapes in chart drawings, including general drawing properties and connection-specific settings.
/// </summary>
public interface NonVisualConnectorShapeDrawingProperties
{
  /// <summary>
  /// General non-visual properties for the connector shape, such as ID, name, and metadata.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual properties specific to connection shapes, including locks and connection endpoints.
  /// </summary>
  public NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get; set; }
}