namespace DocumentModel.Drawings;
/// <summary>
/// Represents an RGB color using hexadecimal notation with optional color transformations.
/// This is one of several color model variants used in Office Open XML DrawingML, 
/// allowing colors to be specified as hex RGB values (e.g., "FF0000" for red) 
/// with optional modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
[OpenXmlType(typeof(DXD.RgbColorModelHex))]
[XmlRoot("RgbColorModelHex", Namespace = "DocumentModel.Drawings")]
public partial class RgbColorModelHex : DrawingsColorBase<DXD.RgbColorModelHex>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// RGB color value in hexadecimal format.
  /// </summary>
  /// <remarks>
  /// This is the primary color value specified as a 24-bit RGB color (8 bits per channel).
  /// Common values include 0xFF0000 (red), 0x00FF00 (green), 0x0000FF (blue), 0x000000 (black), and 0xFFFFFF (white).
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelHex.Val))]
  public HexColor Value { get => _value; set => UpdateField(ref _value, value, nameof(Value)); }
  private HexColor _value;
}