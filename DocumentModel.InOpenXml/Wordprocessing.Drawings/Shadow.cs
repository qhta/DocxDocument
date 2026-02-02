using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the shadow effect applied to a drawing element in a Wordprocessing document.
/// This class provides properties for configuring blur radius, distance, direction, scaling, skew, alignment, and color, enabling advanced visual effects for graphical objects.
/// </summary>
[OpenXmlType(typeof(DXW.Shadow))]
public partial class Shadow : ModelElement<DXW.Shadow>, IDrawingProperty
{
  /// <summary>
  /// The blur radius of the shadow, specified in EMUs (English Metric Units), determining the softness of the shadow's edges.
  /// </summary>
  public Int64? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }

  private Int64? _BlurRadius;
  /// <summary>
  /// The distance from the text or object to the start of the shadow, specified in EMUs.
  /// </summary>
  public Int64? DistanceFromText { get => _DistanceFromText; set => UpdateField(ref _DistanceFromText, value, nameof(DistanceFromText)); }

  private Int64? _DistanceFromText;
  /// <summary>
  /// The direction angle of the shadow, specified in degrees, determining the orientation of the shadow effect.
  /// </summary>
  public Int32? DirectionAngle { get => _DirectionAngle; set => UpdateField(ref _DirectionAngle, value, nameof(DirectionAngle)); }

  private Int32? _DirectionAngle;
  /// <summary>
  /// The horizontal scaling factor for the shadow, controlling the width of the shadow image.
  /// </summary>
  public Int32? HorizontalScalingFactor { get => _HorizontalScalingFactor; set => UpdateField(ref _HorizontalScalingFactor, value, nameof(HorizontalScalingFactor)); }

  private Int32? _HorizontalScalingFactor;
  /// <summary>
  /// The vertical scaling factor for the shadow, controlling the height of the shadow image.
  /// </summary>
  public Int32? VerticalScalingFactor { get => _VerticalScalingFactor; set => UpdateField(ref _VerticalScalingFactor, value, nameof(VerticalScalingFactor)); }

  private Int32? _VerticalScalingFactor;
  /// <summary>
  /// The horizontal skew angle for the shadow, specified in degrees, distorting the shadow horizontally.
  /// </summary>
  public Int32? HorizontalSkewAngle { get => _HorizontalSkewAngle; set => UpdateField(ref _HorizontalSkewAngle, value, nameof(HorizontalSkewAngle)); }

  private Int32? _HorizontalSkewAngle;
  /// <summary>
  /// The vertical skew angle for the shadow, specified in degrees, distorting the shadow vertically.
  /// </summary>
  public Int32? VerticalSkewAngle { get => _VerticalSkewAngle; set => UpdateField(ref _VerticalSkewAngle, value, nameof(VerticalSkewAngle)); }

  private Int32? _VerticalSkewAngle;
  /// <summary>
  /// The alignment of the shadow within the bounding rectangle, specifying how the shadow is positioned relative to the object.
  /// </summary>
  public RectangleAlignment? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

  private RectangleAlignment? _Alignment;
  /// <summary>
  /// The RGB color value for the shadow effect, allowing precise color specification using hexadecimal notation.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get => _RgbColorModelHex; set => UpdateField(ref _RgbColorModelHex, value, nameof(RgbColorModelHex)); }

  private RgbColorModelHex? _RgbColorModelHex;
  /// <summary>
  /// The scheme color for the shadow effect, enabling the use of document-defined color schemes for consistent styling.
  /// </summary>
  public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

  private SchemeColor? _SchemeColor;
}