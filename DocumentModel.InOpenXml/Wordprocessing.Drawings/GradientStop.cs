namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a single stop in a gradient fill for a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the position and color of the gradient stop, enabling precise control over color transitions in gradient effects.
/// </summary>
[OpenXmlType(typeof(DXO10W.GradientStop))]
public partial class GradientStop : ModelElement<DXO10W.GradientStop>
{
 /// <summary>
 /// The position of the gradient stop, specified as a percentage or value indicating where the color is applied along the gradient axis.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.GradientStop.StopPosition))]
 public Int32? StopPosition { get => _StopPosition; set => UpdateField(ref _StopPosition, value, nameof(StopPosition)); }
 private Int32? _StopPosition;
 /// <summary>
 /// The RGB color value for the gradient stop, allowing precise color specification.
 /// </summary>
 public RgbColorModelHex? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }
 private RgbColorModelHex? _RgbColor;
 /// <summary>
 /// The scheme color for the gradient stop, enabling the use of document-defined color schemes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.GradientStop.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;
}