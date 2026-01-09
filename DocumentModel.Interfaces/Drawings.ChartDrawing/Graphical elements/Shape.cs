namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a shape element in chart drawings, including macro references, text linking, locking options, publishing settings, non-visual and visual properties, style, and text body formatting.
/// </summary>
public interface Shape
{
  /// <summary>
  /// Macro name or reference for custom functionality associated with the shape.
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  /// Link to external or internal text content for the shape.
  /// </summary>
  public string? TextLink { get; set; }

  /// <summary>
  /// Indicates whether the text within the shape is locked from editing.
  /// </summary>
  public bool? LockText { get; set; }

  /// <summary>
  /// Indicates whether the shape should be published to a server or external destination.
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  /// Non-visual properties for the shape, including identifiers, names, and metadata.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties { get; set; }

  /// <summary>
  /// Visual formatting and properties for the shape.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  /// Style settings applied to the shape for appearance customization.
  /// </summary>
  public Style? Style { get; set; }

  /// <summary>
  /// Text body formatting and content for the shape.
  /// </summary>
  public TextBody? TextBody { get; set; }
}