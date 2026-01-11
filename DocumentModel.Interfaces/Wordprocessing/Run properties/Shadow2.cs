namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the Office 2010+ advanced shadow effect for text runs in WordprocessingML documents.
///   This interface provides comprehensive shadow effect capabilities, including blur, distance, direction, scaling, skewing, alignment, and color options, enabling sophisticated shadow rendering for text.
/// </summary>
public interface Shadow2
{

  /// <summary>
  ///   Blur radius for the shadow effect, specified in EMUs. Larger values create a softer shadow edge.
  /// </summary>
  public long? BlurRadius { get; set; }

  /// <summary>
  ///   Distance of the shadow from the text, specified in EMUs. Creates the perception of depth or elevation.
  /// </summary>
  public long? DistanceFromText { get; set; }

  /// <summary>
  ///   Direction angle of the shadow, measured in 60,000ths of a degree. Determines the direction from the text to the shadow.
  /// </summary>
  public int? DirectionAngle { get; set; }

  /// <summary>
  ///   Horizontal scaling factor for the shadow, as a percentage in thousands. Affects the shadow's width relative to the text.
  /// </summary>
  public int? HorizontalScalingFactor { get; set; }

  /// <summary>
  ///   Vertical scaling factor for the shadow, as a percentage in thousands. Affects the shadow's height relative to the text.
  /// </summary>
  public int? VerticalScalingFactor { get; set; }

  /// <summary>
  ///   Horizontal skew angle for the shadow, in 60,000ths of a degree. Positive values skew right, negative skew left.
  /// </summary>
  public int? HorizontalSkewAngle { get; set; }

  /// <summary>
  ///   Vertical skew angle for the shadow, in 60,000ths of a degree. Positive values skew upward, negative downward.
  /// </summary>
  public int? VerticalSkewAngle { get; set; }

  /// <summary>
  ///   Alignment of the shadow relative to the text bounds. Determines the anchor point for shadow transformations.
  /// </summary>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Shadow color using RGB hexadecimal notation (e.g., "000000" for black). Mutually exclusive with SchemeColor.
  /// </summary>
  public RgbColor? RgbColor { get; set; }

  /// <summary>
  ///   Shadow color using a theme color scheme. Mutually exclusive with RgbColor.
  /// </summary>
  public SchemeColor? SchemeColor { get; set; }
}