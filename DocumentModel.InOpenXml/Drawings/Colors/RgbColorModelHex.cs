namespace DocumentModel.Drawings;
/// <summary>
/// Represents an RGB color using hexadecimal notation with optional color transformations.
/// This is one of several color model variants used in Office Open XML DrawingML, 
/// allowing colors to be specified as hex RGB values (e.g., "FF0000" for red) 
/// with optional modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
[OpenXmlType(typeof(DXD.RgbColorModelHex))]
[XmlRoot("RgbColorModelHex", Namespace = "DocumentModel.Drawings")]
public partial class RgbColorModelHex : AbstractColor<DXD.RgbColorModelHex>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Base RGB color value in hexadecimal format.
  /// </summary>
  /// <remarks>
  /// This is the primary color value specified as a 24-bit RGB color (8 bits per channel).
  /// Common values include 0xFF0000 (red), 0x00FF00 (green), 0x0000FF (blue), 0x000000 (black), and 0xFFFFFF (white).
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.RgbColorModelHex.Val))]
  public HexColor? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
  private HexColor? _Val;

  /// <summary>
  /// Tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the base color by mixing it with white. 
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint applied (original color)</description></item>
  /// <item><description>50000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Tint))]
  public Percentage? Tint { get => _Tint; set => UpdateField(ref _Tint, value, nameof(Tint)); }
  private Percentage? _Tint;

  /// <summary>
  /// Shade value to darken the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade value darkens the base color by mixing it with black.
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade applied (original color)</description></item>
  /// <item><description>50000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Shade))]
  public Percentage? Shade { get => _Shade; set => UpdateField(ref _Shade, value, nameof(Shade)); }
  private Percentage? _Shade;
}