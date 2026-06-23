namespace DocumentModel.Drawings;
/// <summary>
///   Gradient stops.
/// </summary>
[OpenXmlType(typeof(DXD.GradientStop))]
[XmlRoot("GradientStop", Namespace = "DocumentModel.Drawings")]
public partial class GradientStop : ModelElement<DXD.GradientStop>
{
 /// <summary>
 ///   Position
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.Position))]
 public Percentage? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }
 private Percentage? _Position;

 /// <summary>
 ///   RGB Color Model - Percentage Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.GradientStop.RgbColorModelPercentage))]
 public ColorType? Color { get => _color; set => UpdateField(ref _color, value, nameof(Color)); }
 private ColorType? _color;



}