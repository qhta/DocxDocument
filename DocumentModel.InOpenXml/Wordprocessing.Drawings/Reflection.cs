using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the reflection effect applied to a drawing element in a Wordprocessing document.
/// This class provides properties for configuring blur radius, opacity, position, distance, direction, scaling, skew, and alignment, enabling advanced visual effects for graphical objects.
/// </summary>
[OpenXmlType(typeof(DXO10W.Reflection))]
[DataContract]
[XmlRoot("Reflection", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class Reflection : ModelElement<DXO10W.Reflection>, IDrawingProperty
{
 /// <summary>
 /// The blur radius of the reflection, specified in EMUs (English Metric Units), determining the softness of the reflected image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.BlurRadius))]
 public Int64? BlurRadius { get => _BlurRadius; set => UpdateField(ref _BlurRadius, value, nameof(BlurRadius)); }
 private Int64? _BlurRadius;

 /// <summary>
 /// The starting opacity of the reflection, specified as a percentage, controlling the transparency at the beginning of the reflection.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.StartingOpacity))]
 public Int32? StartingOpacity { get => _StartingOpacity; set => UpdateField(ref _StartingOpacity, value, nameof(StartingOpacity)); }
 private Int32? _StartingOpacity;

 /// <summary>
 /// The start position of the reflection, indicating where the reflection effect begins relative to the object.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.StartPosition))]
 public Int32? StartPosition { get => _StartPosition; set => UpdateField(ref _StartPosition, value, nameof(StartPosition)); }
 private Int32? _StartPosition;

 /// <summary>
 /// The ending opacity of the reflection, specified as a percentage, controlling the transparency at the end of the reflection.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.EndingOpacity))]
 public Int32? EndingOpacity { get => _EndingOpacity; set => UpdateField(ref _EndingOpacity, value, nameof(EndingOpacity)); }
 private Int32? _EndingOpacity;

 /// <summary>
 /// The end position of the reflection, indicating where the reflection effect ends relative to the object.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.EndPosition))]
 public Int32? EndPosition { get => _EndPosition; set => UpdateField(ref _EndPosition, value, nameof(EndPosition)); }
 private Int32? _EndPosition;

 /// <summary>
 /// The distance from the text or object to the start of the reflection, specified in EMUs.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.DistanceFromText))]
 public Int64? DistanceFromText { get => _DistanceFromText; set => UpdateField(ref _DistanceFromText, value, nameof(DistanceFromText)); }
 private Int64? _DistanceFromText;

 /// <summary>
 /// The direction angle of the reflection, specified in degrees, determining the orientation of the reflection effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.DirectionAngle))]
 public Int32? DirectionAngle { get => _DirectionAngle; set => UpdateField(ref _DirectionAngle, value, nameof(DirectionAngle)); }
 private Int32? _DirectionAngle;

 /// <summary>
 /// The fade direction of the reflection, specifying the direction in which the reflection fades out.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.FadeDirection))]
 public Int32? FadeDirection { get => _FadeDirection; set => UpdateField(ref _FadeDirection, value, nameof(FadeDirection)); }
 private Int32? _FadeDirection;

 /// <summary>
 /// The horizontal scaling factor for the reflection, controlling the width of the reflected image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.HorizontalScalingFactor))]
 public Int32? HorizontalScalingFactor { get => _HorizontalScalingFactor; set => UpdateField(ref _HorizontalScalingFactor, value, nameof(HorizontalScalingFactor)); }
 private Int32? _HorizontalScalingFactor;

 /// <summary>
 /// The vertical scaling factor for the reflection, controlling the height of the reflected image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.VerticalScalingFactor))]
 public Int32? VerticalScalingFactor { get => _VerticalScalingFactor; set => UpdateField(ref _VerticalScalingFactor, value, nameof(VerticalScalingFactor)); }
 private Int32? _VerticalScalingFactor;

 /// <summary>
 /// The horizontal skew angle for the reflection, specified in degrees, distorting the reflection horizontally.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.HorizontalSkewAngle))]
 public Int32? HorizontalSkewAngle { get => _HorizontalSkewAngle; set => UpdateField(ref _HorizontalSkewAngle, value, nameof(HorizontalSkewAngle)); }
 private Int32? _HorizontalSkewAngle;

 /// <summary>
 /// The vertical skew angle for the reflection, specified in degrees, distorting the reflection vertically.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.VerticalSkewAngle))]
 public Int32? VerticalSkewAngle { get => _VerticalSkewAngle; set => UpdateField(ref _VerticalSkewAngle, value, nameof(VerticalSkewAngle)); }
 private Int32? _VerticalSkewAngle;

 /// <summary>
 /// The alignment of the reflection within the bounding rectangle, specifying how the reflection is positioned relative to the object.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.Reflection.Alignment))]
 public RectangleAlignment? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }
 private RectangleAlignment? _Alignment;
}