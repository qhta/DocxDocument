namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes style settings for a shape in chart drawings, including references to line, fill, effect, and font formatting.
/// </summary>
public interface Style
{
  /// <summary>
  /// Reference to the line formatting applied to the shape.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  /// Reference to the fill formatting applied to the shape.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  /// Reference to the effect formatting applied to the shape.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  /// Reference to the font formatting applied to the shape's text content.
  /// </summary>
  public FontReference? FontReference { get; set; }
}