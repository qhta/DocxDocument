namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Office 2010+ Shadow effect for text runs.
/// </summary>
/// <remarks>
///   <para>
///   Shadow2 represents the advanced shadow effect introduced in Office 2010, providing
///   more sophisticated shadow rendering than the basic shadow effect from earlier versions.
///   </para>
///   <para>
///   This interface corresponds to the DocumentFormat.OpenXml.Office2010.Word.Shadow class
///   and provides comprehensive shadow effect capabilities including blur, distance, direction,
///   scaling, skewing, and color options.
///   </para>
///   <para>
///   The shadow effect can use either RGB hex color or scheme color for theme-aware rendering.
///   All angle and distance measurements follow the OpenXML conventions (60,000ths of a degree
///   for angles, EMUs for distances).
///   </para>
/// </remarks>
public interface Shadow2
{
  /// <summary>
  ///   Gets or sets the blur radius for the shadow effect.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the blur radius of the shadow in EMUs (English Metric Units).
  ///   Larger values create a more diffuse, softer shadow edge.
  ///   </para>
  ///   <para>
  ///   One EMU = 1/914,400 of an inch = 1/36,000 of a centimeter.
  ///   Common values range from 0 (sharp edge) to 63,500 (very soft/blurred).
  ///   </para>
  /// </remarks>
  public long? BlurRadius { get; set; }

  /// <summary>
  ///   Gets or sets the distance of the shadow from the text.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies how far the shadow is offset from the text in EMUs (English Metric Units).
  ///   This creates the perception of depth or elevation.
  ///   </para>
  ///   <para>
  ///   Typical values range from 0 (no offset, directly behind text) to 127,000 (far shadow).
  ///   The actual visual distance depends on the direction angle.
  ///   </para>
  /// </remarks>
  public long? DistanceFromText { get; set; }

  /// <summary>
  ///   Gets or sets the direction angle of the shadow.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the angle at which the shadow is cast, measured in 60,000ths of a degree.
  ///   This determines the direction from the text to the shadow.
  ///   </para>
  ///   <para>
  ///   Common angles:
  ///   <list type="bullet">
  ///     <item><description>0° (0) - Shadow to the right</description></item>
  ///     <item><description>90° (5,400,000) - Shadow below</description></item>
  ///     <item><description>180° (10,800,000) - Shadow to the left</description></item>
  ///     <item><description>270° (16,200,000) - Shadow above</description></item>
  ///     <item><description>315° (18,900,000) - Shadow upper-left (typical)</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public int? DirectionAngle { get; set; }

  /// <summary>
  ///   Gets or sets the horizontal scaling factor for the shadow.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies horizontal scaling as a percentage in thousands.
  ///   100,000 = 100% (no scaling), 50,000 = 50% (compressed), 200,000 = 200% (expanded).
  ///   </para>
  ///   <para>
  ///   Horizontal scaling affects the shadow's width relative to the text width.
  ///   Values less than 100% make the shadow narrower, values greater make it wider.
  ///   </para>
  /// </remarks>
  public int? HorizontalScalingFactor { get; set; }

  /// <summary>
  ///   Gets or sets the vertical scaling factor for the shadow.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies vertical scaling as a percentage in thousands.
  ///   100,000 = 100% (no scaling), 50,000 = 50% (compressed), 200,000 = 200% (expanded).
  ///   </para>
  ///   <para>
  ///   Vertical scaling affects the shadow's height relative to the text height.
  ///   Values less than 100% make the shadow shorter, values greater make it taller.
  ///   </para>
  /// </remarks>
  public int? VerticalScalingFactor { get; set; }

  /// <summary>
  ///   Gets or sets the horizontal skew angle for the shadow.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies horizontal skew (shear) in 60,000ths of a degree.
  ///   Positive values skew the shadow to the right, negative values to the left.
  ///   </para>
  ///   <para>
  ///   Skewing creates perspective or italic-like effects on the shadow.
  ///   Typical values range from -5,400,000 (-90°) to 5,400,000 (90°).
  ///   </para>
  /// </remarks>
  public int? HorizontalSkewAngle { get; set; }

  /// <summary>
  ///   Gets or sets the vertical skew angle for the shadow.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies vertical skew (shear) in 60,000ths of a degree.
  ///   Positive values skew the shadow upward, negative values downward.
  ///   </para>
  ///   <para>
  ///   Combined with horizontal skew, this can create complex perspective effects.
  ///   Typical values range from -5,400,000 (-90°) to 5,400,000 (90°).
  ///   </para>
  /// </remarks>
  public int? VerticalSkewAngle { get; set; }

  /// <summary>
  ///   Gets or sets the alignment of the shadow relative to the text bounds.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies which point of the shadow is aligned with the text.
  ///   This affects how the shadow is positioned when scaling or skewing is applied.
  ///   </para>
  ///   <para>
  ///   Common alignments include TopLeft, Center, and BottomRight, which determine
  ///   the anchor point for shadow transformations.
  ///   </para>
  /// </remarks>
  public RectangleAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Gets or sets the shadow color using RGB hexadecimal notation.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the shadow color as a hex RGB value (e.g., "000000" for black).
  ///   This is mutually exclusive with SchemeColor - only one color specification should be used.
  ///   </para>
  ///   <para>
  ///   RGB colors provide exact color control but don't respond to theme changes.
  ///   For theme-aware shadows, use SchemeColor instead.
  ///   </para>
  /// </remarks>
  public RgbColor? RgbColor{ get; set; }

  /// <summary>
  ///   Gets or sets the shadow color using a theme color scheme.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies the shadow color using a theme color reference (e.g., dark1, light1, accent1).
  ///   This is mutually exclusive with RgbColorModelHex - only one color specification should be used.
  ///   </para>
  ///   <para>
  ///   Scheme colors respond to document theme changes, making them preferred for
  ///   documents that should maintain visual consistency with the applied theme.
  ///   </para>
  /// </remarks>
  public SchemeColor? SchemeColor { get; set; }
}