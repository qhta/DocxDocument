using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the reflection effect applied to a drawing element in a Wordprocessing document.
/// This interface provides properties for configuring blur radius, opacity, position, distance, direction, scaling, skew, and alignment, enabling advanced visual effects for graphical objects.
/// </summary>
public class Reflection : DrawingProperty
{
  /// <summary>
  /// The blur radius of the reflection, specified in EMUs (English Metric Units), determining the softness of the reflected image.
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  /// The starting opacity of the reflection, specified as a percentage, controlling the transparency at the beginning of the reflection.
  /// </summary>
  public Int32? StartingOpacity { get; set; }

  /// <summary>
  /// The start position of the reflection, indicating where the reflection effect begins relative to the object.
  /// </summary>
  public Int32? StartPosition { get; set; }

  /// <summary>
  /// The ending opacity of the reflection, specified as a percentage, controlling the transparency at the end of the reflection.
  /// </summary>
  public Int32? EndingOpacity { get; set; }

  /// <summary>
  /// The end position of the reflection, indicating where the reflection effect ends relative to the object.
  /// </summary>
  public Int32? EndPosition { get; set; }

  /// <summary>
  /// The distance from the text or object to the start of the reflection, specified in EMUs.
  /// </summary>
  public Int64? DistanceFromText { get; set; }

  /// <summary>
  /// The direction angle of the reflection, specified in degrees, determining the orientation of the reflection effect.
  /// </summary>
  public Int32? DirectionAngle { get; set; }

  /// <summary>
  /// The fade direction of the reflection, specifying the direction in which the reflection fades out.
  /// </summary>
  public Int32? FadeDirection { get; set; }

  /// <summary>
  /// The horizontal scaling factor for the reflection, controlling the width of the reflected image.
  /// </summary>
  public Int32? HorizontalScalingFactor { get; set; }

  /// <summary>
  /// The vertical scaling factor for the reflection, controlling the height of the reflected image.
  /// </summary>
  public Int32? VerticalScalingFactor { get; set; }

  /// <summary>
  /// The horizontal skew angle for the reflection, specified in degrees, distorting the reflection horizontally.
  /// </summary>
  public Int32? HorizontalSkewAngle { get; set; }

  /// <summary>
  /// The vertical skew angle for the reflection, specified in degrees, distorting the reflection vertically.
  /// </summary>
  public Int32? VerticalSkewAngle { get; set; }

  /// <summary>
  /// The alignment of the reflection within the bounding rectangle, specifying how the reflection is positioned relative to the object.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }
}