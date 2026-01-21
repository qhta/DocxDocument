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
/// <para>
/// All percentage values in this model use the range 0-100000 to represent 0% to 100%, 
/// providing fine-grained control with 1/1000th of a percent precision.
/// Multiple transformations can be applied simultaneously and are processed in the order 
/// defined by the Office Open XML specification.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a red color (100% red, 0% green, 0% blue)
/// var red = new RgbColorModelPercentage 
/// { 
///     RedPortion = 100000,    // 100%
///     GreenPortion = 0,       // 0%
///     BluePortion = 0         // 0%
/// };
/// 
/// // Create a semi-transparent purple with tint
/// var lightPurple = new RgbColorModelPercentage
/// {
///     RedPortion = 50000,     // 50% red
///     GreenPortion = 0,       // 0% green
///     BluePortion = 50000,    // 50% blue
///     Tint = 40000,          // 40% lighter
///     Alpha = 50000          // 50% opacity
/// };
/// </code>
/// </example>
public partial class RgbColorModelPercentage : DrawingColor
{
  /// <summary>
  /// Red component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of red in the color where 0 is no red and 100000 is maximum red (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no red), 50000 (50% red), 100000 (full red).
  /// </remarks>
  public Int32? RedPortion { get; set; }
  /// <summary>
  /// Green component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of green in the color where 0 is no green and 100000 is maximum green (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no green), 50000 (50% green), 100000 (full green).
  /// </remarks>
  public Int32? GreenPortion { get; set; }
  /// <summary>
  /// Blue component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of blue in the color where 0 is no blue and 100000 is maximum blue (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no blue), 50000 (50% blue), 100000 (full blue).
  /// </remarks>
  public Int32? BluePortion { get; set; }
}