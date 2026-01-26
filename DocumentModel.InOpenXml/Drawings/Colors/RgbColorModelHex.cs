namespace DocumentModel.Drawings;
/// <summary>
/// Represents an RGB color using hexadecimal notation with optional color transformations.
/// This is one of several color model variants used in Office Open XML DrawingML, 
/// allowing colors to be specified as hex RGB values (e.g., "FF0000" for red) 
/// with optional modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
/// <remarks>
/// <para>
/// The RGB Color Model - Hex Variant provides a compact way to specify colors using 
/// 6-digit hexadecimal notation (RRGGBB format), similar to HTML/CSS color notation.
/// This model is commonly used in Office documents for defining theme colors, shape fills, 
/// text colors, and other visual elements.
/// </para>
/// <para>
/// In addition to the base RGB value, this model supports extensive color transformations:
/// <list type="bullet">
/// <item><description><b>Tint/Shade:</b> Lighten or darken the base color</description></item>
/// <item><description><b>Alpha:</b> Control transparency (0-100000, where 100000 is fully opaque)</description></item>
/// <item><description><b>Hue/Saturation/Luminance:</b> Adjust color properties in HSL color space</description></item>
/// <item><description><b>RGB Modulation:</b> Individually adjust red, green, and blue channels</description></item>
/// <item><description><b>Color Effects:</b> Apply complement, inverse, gray, or gamma corrections</description></item>
/// </list>
/// </para>
/// <para>
/// Transformation values are typically specified as percentages in the range of 0-100000 
/// (representing 0% to 100%), with some transformations supporting negative offsets.
/// Multiple transformations can be applied simultaneously and are processed in the order defined by the Office Open XML specification.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a red color with 50% transparency
/// var color = new RgbColorModelHex 
/// { 
///     Val = new RGB(0xFF0000),
///     Alpha = 50000  // 50%
/// };
/// 
/// // Create a blue color with tint (lighter) and saturation adjustment
/// var lightBlue = new RgbColorModelHex
/// {
///     Val = new RGB(0x0000FF),
///     Tint = 40000,          // 40% lighter
///     SaturationModulation = 80000  // 80% saturation
/// };
/// </code>
/// </example>
[OpenXmlType(typeof(DXD.RgbColorModelHex))]
public partial class RgbColorModelHex : DrawingColor<DXD.RgbColorModelHex>
{
 /// <summary>
 /// Base RGB color value in hexadecimal format.
 /// </summary>
 /// <remarks>
 /// This is the primary color value specified as a 24-bit RGB color (8 bits per channel).
 /// Common values include 0xFF0000 (red), 0x00FF00 (green), 0x0000FF (blue), 0x000000 (black), and 0xFFFFFF (white).
 /// </remarks>
 public RGB? Val { get; set; }
}