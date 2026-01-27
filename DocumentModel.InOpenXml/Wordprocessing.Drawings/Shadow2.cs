namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Represents the Office 2010+ advanced shadow effect for text runs in WordprocessingML documents.
///   This class provides comprehensive shadow effect capabilities, including blur, distance, direction, scaling, skewing, alignment, and color options, enabling sophisticated shadow rendering for text.
/// </summary>
[OpenXmlType(typeof(DXO10W.Shadow))]
public partial class Shadow2 : ModelElement<DXO10W.Shadow>
{
 /// <summary>
 ///   Blur radius for the shadow effect, specified in EMUs. Larger values create a softer shadow edge.
 /// </summary>
 public long? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }

 private long? _BlurRadius;
 /// <summary>
 ///   Distance of the shadow from the text, specified in EMUs. Creates the perception of depth or elevation.
 /// </summary>
 public long? DistanceFromText { get => _DistanceFromText; set => UpdateField(ref _DistanceFromText, value, nameof(DistanceFromText)); }

 private long? _DistanceFromText;
 /// <summary>
 ///   Direction angle of the shadow, measured in 60,000ths of a degree. Determines the direction from the text to the shadow.
 /// </summary>
 public int? DirectionAngle { get => _DirectionAngle; set => UpdateField(ref _DirectionAngle, value, nameof(DirectionAngle)); }

 private int? _DirectionAngle;
 /// <summary>
 ///   Horizontal scaling factor for the shadow, as a percentage in thousands. Affects the shadow's width relative to the text.
 /// </summary>
 public int? HorizontalScalingFactor { get => _HorizontalScalingFactor; set => UpdateField(ref _HorizontalScalingFactor, value, nameof(HorizontalScalingFactor)); }

 private int? _HorizontalScalingFactor;
 /// <summary>
 ///   Vertical scaling factor for the shadow, as a percentage in thousands. Affects the shadow's height relative to the text.
 /// </summary>
 public int? VerticalScalingFactor { get => _VerticalScalingFactor; set => UpdateField(ref _VerticalScalingFactor, value, nameof(VerticalScalingFactor)); }

 private int? _VerticalScalingFactor;
 /// <summary>
 ///   Horizontal skew angle for the shadow, in 60,000ths of a degree. Positive values skew right, negative skew left.
 /// </summary>
 public int? HorizontalSkewAngle { get => _HorizontalSkewAngle; set => UpdateField(ref _HorizontalSkewAngle, value, nameof(HorizontalSkewAngle)); }

 private int? _HorizontalSkewAngle;
 /// <summary>
 ///   Vertical skew angle for the shadow, in 60,000ths of a degree. Positive values skew upward, negative downward.
 /// </summary>
 public int? VerticalSkewAngle { get => _VerticalSkewAngle; set => UpdateField(ref _VerticalSkewAngle, value, nameof(VerticalSkewAngle)); }

 private int? _VerticalSkewAngle;
 /// <summary>
 ///   Alignment of the shadow relative to the text bounds. Determines the anchor point for shadow transformations.
 /// </summary>
 public RectangleAlignmentKind? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

 private RectangleAlignmentKind? _Alignment;
 /// <summary>
 ///   Shadow color using RGB hexadecimal notation (e.g., "000000" for black). Mutually exclusive with SchemeColor.
 /// </summary>
 public RgbColor? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }

 private RgbColor? _RgbColor;
 /// <summary>
 ///   Shadow color using a theme color scheme. Mutually exclusive with RgbColor.
 /// </summary>
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
}