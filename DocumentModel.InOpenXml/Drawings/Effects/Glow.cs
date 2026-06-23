namespace DocumentModel.Drawings;
/// <summary>
///   Represents a glow effect that can be applied to a drawing object.
/// </summary>
[OpenXmlType(typeof(DXD.Glow))]
[XmlRoot("Glow", Namespace = "DocumentModel.Drawings")]
public partial class Glow : ModelElement<DXD.Glow>
{
 /// <summary>
 ///   Radius
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.Radius))]
 public Int64? Radius { get => _Radius; set => UpdateField(ref _Radius, value, nameof(Radius)); }
 private Int64? _Radius;

 /// <summary>
 ///   RGB Color Model - Percentage Variant.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Glow.RgbColorModelPercentage))]
 public ColorType? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private ColorType? _Color;

}