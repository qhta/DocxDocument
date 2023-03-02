namespace DocumentModel.Drawings;

/// <summary>
///   Reflection Effect.
/// </summary>
public record Reflection
{
  /// <summary>
  ///   Blur Radius
  /// </summary>
  public Int64? BlurRadius { get; set; }

  /// <summary>
  ///   Start Opacity
  /// </summary>
  public Int32? StartOpacity { get; set; }

  /// <summary>
  ///   Start Position
  /// </summary>
  public Int32? StartPosition { get; set; }

  /// <summary>
  ///   End Alpha
  /// </summary>
  public Int32? EndAlpha { get; set; }

  /// <summary>
  ///   End Position
  /// </summary>
  public Int32? EndPosition { get; set; }

  /// <summary>
  ///   Distance
  /// </summary>
  public Int64? Distance { get; set; }

  /// <summary>
  ///   Direction
  /// </summary>
  public Int32? Direction { get; set; }

  /// <summary>
  ///   Fade Direction
  /// </summary>
  public Int32? FadeDirection { get; set; }

  /// <summary>
  ///   Horizontal Ratio
  /// </summary>
  public Int32? HorizontalRatio { get; set; }

  /// <summary>
  ///   Vertical Ratio
  /// </summary>
  public Int32? VerticalRatio { get; set; }

  /// <summary>
  ///   Horizontal Skew
  /// </summary>
  public Int32? HorizontalSkew { get; set; }

  /// <summary>
  ///   Vertical Skew
  /// </summary>
  public Int32? VerticalSkew { get; set; }

  /// <summary>
  ///   Shadow Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
}