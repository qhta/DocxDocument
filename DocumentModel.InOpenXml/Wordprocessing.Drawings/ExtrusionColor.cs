namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the color settings for the extrusion effect of a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the extrusion color using either an RGB value or a scheme color, enabling flexible color customization for 3D effects.
/// </summary>
[OpenXmlType(typeof(DXO10W.ExtrusionColor))]
public partial class ExtrusionColor : ModelElement<DXO10W.ExtrusionColor>
{
 /// <summary>
 /// The RGB color value used for the extrusion, allowing precise color specification.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.ExtrusionColor))]
 public RgbColor? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }

 private RgbColor? _RgbColor;
 /// <summary>
 /// The scheme color used for the extrusion, enabling the use of document-defined color schemes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ExtrusionColor.SchemeColor))]
 /// <summary>
 /// The scheme color used for the extrusion, enabling the use of document-defined color schemes.
 /// </summary>
 [OpenXmlElement(typeof(DXO10W.ExtrusionColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }

 private SchemeColor? _SchemeColor;
}