namespace DocumentModel.Drawings;
/// <summary>
/// Represents an RGB color using percentage values with optional color transformations.
/// This is the percentage variant of the RGB color model used in Office Open XML DrawingML, 
/// allowing colors to be specified as percentage values for red, green, and blue components (0-100%)
/// with optional modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
/// <remarks>
/// <para>
/// The RGB Color Model - Percentage Variant provides a way to specify colors using 
/// percentage notation (0-100000 representing 0-100%), which can be more intuitive than 
/// hexadecimal notation for certain color calculations and transformations.
/// This model is used in Office documents alongside the hex variant for defining theme colors, 
/// shape fills, text colors, and other visual elements.
/// </para>
/// <para>
/// In addition to the base RGB percentage values, this model supports the same extensive 
/// color transformations as the hex variant:
/// <list type="bullet">
/// <item><description><b>Tint/Shade:</b> Lighten or darken the base color</description></item>
/// <item><description><b>Alpha:</b> Control transparency (0-100000, where 100000 is fully opaque)</description></item>
/// <item><description><b>Hue/Saturation/Luminance:</b> Adjust color properties in HSL color space</description></item>
/// <item><description><b>RGB Modulation:</b> Individually adjust red, green, and blue channels</description></item>
/// <item><description><b>Color Effects:</b> Apply complement, inverse, gray, or gamma corrections</description></item>
/// </list>
/// </para>
/// </remarks>
[OpenXmlType(typeof(DXD.RgbColorModelPercentage))]
[XmlRoot("RgbColorModelPercentage", Namespace = "DocumentModel.Drawings")]
public partial class RgbColorModelPercentage : AbstractColor<DXD.RgbColorModelPercentage>, ISchemeBaseColor
{
 /// <summary>
 /// Red component as a percentage value.
 /// </summary>
 /// <remarks>
 /// Specifies the amount of red in the color where 0 is no red and 100000 is maximum red (100%).
 /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
 /// Common values: 0 (no red), 50000 (50% red), 100000 (full red).
 /// </remarks>
 [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.RedPortion))]
 public Percentage? Red { get => _red; set => UpdateField(ref _red, value, nameof(Red)); }

 private Percentage? _red;
 /// <summary>
 /// Green component as a percentage value.
 /// </summary>
 /// <remarks>
 /// Specifies the amount of green in the color where 0 is no green and 100000 is maximum green (100%).
 /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
 /// Common values: 0 (no green), 50000 (50% green), 100000 (full green).
 /// </remarks>
 [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.GreenPortion))]
 public Percentage? Green { get => _green; set => UpdateField(ref _green, value, nameof(Green)); }

 private Percentage? _green;
 /// <summary>
 /// Blue component as a percentage value.
 /// </summary>
 /// <remarks>
 /// Specifies the amount of blue in the color where 0 is no blue and 100000 is maximum blue (100%).
 /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
 /// Common values: 0 (no blue), 50000 (50% blue), 100000 (full blue).
 /// </remarks>
 [OpenXmlProperty(nameof(DXD.RgbColorModelPercentage.BluePortion))]
 public Percentage? Blue { get => _blue; set => UpdateField(ref _blue, value, nameof(Blue)); }

 private Percentage? _blue;
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