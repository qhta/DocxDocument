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
public interface RgbColorModelPercentage:
{
  /// <summary>
  /// Gets or sets the red component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of red in the color where 0 is no red and 100000 is maximum red (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no red), 50000 (50% red), 100000 (full red).
  /// </remarks>
  public Int32? RedPortion { get; set; }
  
  /// <summary>
  /// Gets or sets the green component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of green in the color where 0 is no green and 100000 is maximum green (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no green), 50000 (50% green), 100000 (full green).
  /// </remarks>
  public Int32? GreenPortion { get; set; }
  
  /// <summary>
  /// Gets or sets the blue component as a percentage value.
  /// </summary>
  /// <remarks>
  /// Specifies the amount of blue in the color where 0 is no blue and 100000 is maximum blue (100%).
  /// This is equivalent to RGB values 0-255, but expressed as a percentage for easier calculations.
  /// Common values: 0 (no blue), 50000 (50% blue), 100000 (full blue).
  /// </remarks>
  public Int32? BluePortion { get; set; }
  
  /// <summary>
  /// Gets or sets the tint value to lighten the color.
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
  public Int32? Tint { get; set; }
  
  /// <summary>
  /// Gets or sets the shade value to darken the color.
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
  public Int32? Shade { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the complement (opposite) color operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the color is transformed to its complement on the color wheel
  /// (e.g., red becomes cyan, green becomes magenta). Default is <see langword="false"/>.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Complement { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the color inversion operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, each RGB percentage is inverted (100000 - value),
  /// creating a negative effect. Default is <see langword="false"/>.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the color is converted to grayscale.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the color is desaturated to create a grayscale value
  /// based on the perceived luminance of the original color. Default is <see langword="false"/>.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Gray { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute alpha (transparency) value.
  /// </summary>
  /// <remarks>
  /// Specifies the opacity of the color where 0 is fully transparent and 100000 is fully opaque (100%).
  /// Values between create semi-transparent colors. If null, full opacity (100000) is assumed.
  /// </remarks>
  public Int32? Alpha { get; set; }
  
  /// <summary>
  /// Gets or sets the alpha (transparency) offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base alpha value. Range is typically -100000 to +100000.
  /// Positive values increase opacity, negative values increase transparency.
  /// </remarks>
  public Int32? AlphaOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the alpha (transparency) modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base alpha by this percentage. A value of 50000 (50%) makes the color twice as transparent.
  /// Range is 0 to 100000, where 100000 means no change.
  /// </remarks>
  public Int32? AlphaModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute hue value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the hue angle in degrees (0-360), represented as 0-21600000 units (1/60000th of a degree).
  /// Hue represents the color's position on the color wheel: 0=red, 60=yellow, 120=green, 180=cyan, 240=blue, 300=magenta.
  /// </remarks>
  public Int32? Hue { get; set; }
  
  /// <summary>
  /// Gets or sets the hue offset adjustment in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base hue value to shift the color around the color wheel.
  /// Values wrap around (adding 360 degrees returns to the same hue).
  /// </remarks>
  public Int32? HueOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the hue modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base hue by this percentage. Used for relative hue adjustments.
  /// Range is 0 to 100000, where 100000 means no change.
  /// </remarks>
  public Int32? HueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute saturation value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the color saturation where 0 is grayscale and 100000 is fully saturated (100%).
  /// Saturation determines the intensity or vividness of the color.
  /// </remarks>
  public Int32? Saturation { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base saturation value. Range is typically -100000 to +100000.
  /// Positive values make colors more vivid, negative values make them more gray.
  /// </remarks>
  public Int32? SaturationOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base saturation by this percentage. A value of 50000 (50%) reduces saturation by half.
  /// Range is 0 to 100000, where 100000 means no change. Commonly used to create muted color variations.
  /// </remarks>
  public Int32? SaturationModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute luminance value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the brightness where 0 is black, 50000 is the color at normal brightness (50%), 
  /// and 100000 is white. Luminance determines how light or dark the color appears.
  /// </remarks>
  public Int32? Luminance { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base luminance value. Range is typically -100000 to +100000.
  /// Positive values make colors lighter, negative values make them darker.
  /// </remarks>
  public Int32? LuminanceOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base luminance by this percentage. A value of 50000 (50%) reduces brightness by half.
  /// Range is 0 to 100000, where 100000 means no change. Commonly used to create lighter or darker variations.
  /// </remarks>
  public Int32? LuminanceModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute red channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the red component (0-100000 representing 0-100%). 
  /// Use this to set an explicit red value independent of the <see cref="RedPortion"/> base color.
  /// When set, this value takes precedence over <see cref="RedPortion"/> for final color calculation.
  /// </remarks>
  public Int32? Red { get; set; }
  
  /// <summary>
  /// Gets or sets the red channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the red channel value. Range is typically -100000 to +100000.
  /// Applied after the base <see cref="RedPortion"/> or <see cref="Red"/> value.
  /// </remarks>
  public Int32? RedOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the red channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base red channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the red component by half.
  /// </remarks>
  public Int32? RedModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute green channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the green component (0-100000 representing 0-100%).
  /// Use this to set an explicit green value independent of the <see cref="GreenPortion"/> base color.
  /// When set, this value takes precedence over <see cref="GreenPortion"/> for final color calculation.
  /// </remarks>
  public Int32? Green { get; set; }
  
  /// <summary>
  /// Gets or sets the green channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the green channel value. Range is typically -100000 to +100000.
  /// Applied after the base <see cref="GreenPortion"/> or <see cref="Green"/> value.
  /// </remarks>
  public Int32? GreenOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the green channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base green channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the green component by half.
  /// </remarks>
  public Int32? GreenModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute blue channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the blue component (0-100000 representing 0-100%).
  /// Use this to set an explicit blue value independent of the <see cref="BluePortion"/> base color.
  /// When set, this value takes precedence over <see cref="BluePortion"/> for final color calculation.
  /// </remarks>
  public Int32? Blue { get; set; }
  
  /// <summary>
  /// Gets or sets the blue channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the blue channel value. Range is typically -100000 to +100000.
  /// Applied after the base <see cref="BluePortion"/> or <see cref="Blue"/> value.
  /// </remarks>
  public Int32? BlueOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the blue channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base blue channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the blue component by half.
  /// </remarks>
  public Int32? BlueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies standard gamma correction (typically gamma 2.2)
  /// to convert from linear RGB space to display-corrected RGB. Default is <see langword="false"/>.
  /// Gamma correction adjusts colors to appear correct on display devices.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Gamma { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether inverse gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies inverse gamma correction to convert from 
  /// display-corrected RGB to linear RGB space. Default is <see langword="false"/>.
  /// This is the opposite of standard gamma correction.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean InverseGamma { get; set; }
}