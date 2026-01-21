using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the glow effect applied to a drawing element in a Wordprocessing document.
/// This interface provides properties for configuring the glow radius and color, enabling visual emphasis and styling for graphical objects.
/// </summary>
public partial class Glow : DrawingProperty
{
  /// <summary>
  /// The radius of the glow effect, specified in EMUs (English Metric Units), determining the size of the glow around the element.
  /// </summary>
  public Int64? GlowRadius { get; set; }
  /// <summary>
  /// The RGB color value for the glow effect, allowing precise color specification using hexadecimal notation.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }
  /// <summary>
  /// The scheme color for the glow effect, enabling the use of document-defined color schemes for consistent styling.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}