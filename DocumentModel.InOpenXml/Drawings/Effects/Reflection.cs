namespace DocumentModel.Drawings;

/// <summary>
///   Represents a reflection effect, including blur, opacity, position, distance, direction, scaling, skew, alignment, and rotation options.
/// </summary>
public interface Reflection
{
  /// <summary>
  ///   Blur radius of the reflection.
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  ///   Starting opacity of the reflection.
  /// </summary>
  public Int32? StartOpacity { get; set; }

  /// <summary>
  ///   Starting position of the reflection.
  /// </summary>
  public Int32? StartPosition { get; set; }

  /// <summary>
  ///   Ending alpha value of the reflection.
  /// </summary>
  public Int32? EndAlpha { get; set; }

  /// <summary>
  ///   Ending position of the reflection.
  /// </summary>
  public Int32? EndPosition { get; set; }

  /// <summary>
  ///   Distance to offset the reflection from the object.
  /// </summary>
  public Int64? Distance { get; set; }

  /// <summary>
  ///   Direction angle of the reflection.
  /// </summary>
  public Int32? Direction { get; set; }

  /// <summary>
  ///   Fade direction of the reflection.
  /// </summary>
  public Int32? FadeDirection { get; set; }

  /// <summary>
  ///   Horizontal scaling factor for the reflection.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical scaling factor for the reflection.
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Horizontal skew of the reflection.
  /// </summary>
  public Int32? HorizontalSkew { get; set; }

  /// <summary>
  ///   Vertical skew of the reflection.
  /// </summary>
  public Int32? VerticalSkew { get; set; }

  /// <summary>
  ///   Alignment of the reflection relative to the object.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Indicates whether the reflection rotates with the shape.
  /// </summary>
  public bool? RotateWithShape { get; set; }
}