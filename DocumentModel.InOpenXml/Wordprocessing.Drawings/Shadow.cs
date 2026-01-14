using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the shadow effect applied to a drawing element in a Wordprocessing document.
/// This interface provides properties for configuring blur radius, distance, direction, scaling, skew, alignment, and color, enabling advanced visual effects for graphical objects.
/// </summary>
public interface Shadow : TypedModelElement, DrawingProperty
{

  /// <summary>
  /// The blur radius of the shadow, specified in EMUs (English Metric Units), determining the softness of the shadow's edges.
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  /// The distance from the text or object to the start of the shadow, specified in EMUs.
  /// </summary>
  public Int64? DistanceFromText { get; set; }

  /// <summary>
  /// The direction angle of the shadow, specified in degrees, determining the orientation of the shadow effect.
  /// </summary>
  public Int32? DirectionAngle { get; set; }

  /// <summary>
  /// The horizontal scaling factor for the shadow, controlling the width of the shadow image.
  /// </summary>
  public Int32? HorizontalScalingFactor { get; set; }

  /// <summary>
  /// The vertical scaling factor for the shadow, controlling the height of the shadow image.
  /// </summary>
  public Int32? VerticalScalingFactor { get; set; }

  /// <summary>
  /// The horizontal skew angle for the shadow, specified in degrees, distorting the shadow horizontally.
  /// </summary>
  public Int32? HorizontalSkewAngle { get; set; }

  /// <summary>
  /// The vertical skew angle for the shadow, specified in degrees, distorting the shadow vertically.
  /// </summary>
  public Int32? VerticalSkewAngle { get; set; }

  /// <summary>
  /// The alignment of the shadow within the bounding rectangle, specifying how the shadow is positioned relative to the object.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  /// The RGB color value for the shadow effect, allowing precise color specification using hexadecimal notation.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get; set; }

  /// <summary>
  /// The scheme color for the shadow effect, enabling the use of document-defined color schemes for consistent styling.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}