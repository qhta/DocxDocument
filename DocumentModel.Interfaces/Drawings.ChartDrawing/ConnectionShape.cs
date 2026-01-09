namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a connection shape in chart drawings, including macro references, publishing options, non-visual connector properties, shape formatting, and style settings.
/// </summary>
public interface ConnectionShape
{
  /// <summary>
  /// Macro name or reference for custom functionality associated with the connection shape.
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  /// Indicates whether the connection shape should be published to a server or external destination.
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  /// Non-visual properties for the connector shape, including drawing and connection settings.
  /// </summary>
  public NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get; set; }

  /// <summary>
  /// Formatting and visual properties for the connection shape.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Style settings applied to the connection shape for appearance customization.
  /// </summary>
  public Style? Style { get; set; }
}