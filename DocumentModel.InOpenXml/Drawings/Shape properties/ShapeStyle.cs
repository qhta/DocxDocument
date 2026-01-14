namespace DocumentModel.Drawings;

/// <summary>
///   Represents a style for a shape, including references to line, fill, effect, and font formatting.
/// </summary>
public class ShapeStyle: ModelElement
{
  /// <summary>
  ///   Reference to the line formatting for the shape.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  ///   Reference to the fill formatting for the shape.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  ///   Reference to the effect formatting for the shape.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  ///   Reference to the font formatting for the shape.
  /// </summary>
  public FontReference? FontReference { get; set; }
}