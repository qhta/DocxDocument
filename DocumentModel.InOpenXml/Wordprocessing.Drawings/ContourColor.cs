namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the color settings for the contour of a drawing element in a Wordprocessing document.
/// This class provides properties for specifying the contour color using either an RGB value or a scheme color, enabling flexible color customization.
/// </summary>
[OpenXmlType(typeof(DXO10W.ContourColor))]
[XmlRoot("ContourColor", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class ContourColor : ModelElement<DXO10W.ContourColor>
{
 /// <summary>
 /// The RGB color value used for the contour, allowing precise color specification.
 /// </summary>
 public RgbColorHex? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }
 private RgbColorHex? _RgbColor;

 /// <summary>
 /// The scheme color used for the contour, enabling the use of document-defined color schemes.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.ContourColor.SchemeColor))]
 public SchemeColor? SchemeColor { get => _SchemeColor; set => UpdateField(ref _SchemeColor, value, nameof(SchemeColor)); }
 private SchemeColor? _SchemeColor;
}