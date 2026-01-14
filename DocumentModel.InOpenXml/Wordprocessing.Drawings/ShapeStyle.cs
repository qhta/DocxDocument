using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the style settings for a shape in a Wordprocessing document.
/// This interface provides references to line, fill, effect, and font styles, enabling consistent visual formatting for shapes.
/// </summary>
public class ShapeStyle: ModelElement
{
  /// <summary>
  /// Reference to the line style applied to the shape, specifying line color, width, and pattern.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  /// Reference to the fill style applied to the shape, specifying fill color, gradient, or pattern.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  /// Reference to the effect style applied to the shape, such as shadow, glow, or reflection effects.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  /// Reference to the font style used for text within the shape, specifying font family, size, and formatting.
  /// </summary>
  public FontReference? FontReference { get; set; }
}