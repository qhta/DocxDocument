namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha inset or outset effect, which modifies the transparency of an image or shape based on a specified radius.
/// </summary>
[OpenXmlType(typeof(DXD.AlphaOutset))]
public partial class AlphaOutset : ModelElement<DXD.AlphaOutset>
{
 /// <summary>
 /// Radius value that determines the extent of the alpha inset or outset effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AlphaOutset.Radius))]
 /// <summary>
 /// Radius value that determines the extent of the alpha inset or outset effect.
 /// </summary>
 [OpenXmlElement(typeof(DXD.AlphaOutset))]
 public Int64? Radius { get => _Radius; set => UpdateField(ref _Radius, value, nameof(Radius)); }

 private Int64? _Radius;
}