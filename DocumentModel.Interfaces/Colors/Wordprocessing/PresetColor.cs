namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color using a predefined color name with optional transformations.
/// This is the preset color variant used in Office Open XML DrawingML, allowing colors to be 
/// specified by name (e.g., "Red", "Blue", "AliceBlue") from a standard palette, with optional 
/// modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
/// <remarks>
/// <para>
/// The Preset Color model provides a convenient way to specify colors using standardized color names
/// defined in the Office Open XML specification. These names correspond to common colors and provide
/// consistency across documents and applications. The preset colors include basic colors (red, green, blue),
/// extended web colors (aliceBlue, antiqueWhite, etc.), and special values.
/// </para>
/// <para>
/// In addition to the base color name, this model supports the same extensive color transformations
/// as other color models:
/// <list type="bullet">
/// <item><description><b>Tint/Shade:</b> Lighten or darken the base color</description></item>
/// <item><description><b>Alpha:</b> Control transparency (0-100000, where 100000 is fully opaque)</description></item>
/// <item><description><b>Hue/Saturation/Luminance:</b> Adjust color properties in HSL color space</description></item>
/// <item><description><b>RGB Modulation:</b> Individually adjust red, green, and blue channels</description></item>
/// <item><description><b>Color Effects:</b> Apply complement, inverse, gray, or gamma corrections</description></item>
/// </list>
/// </para>
/// <para>
/// Preset colors are particularly useful for:
/// <list type="bullet">
/// <item><description>Creating documents with standardized, named colors</description></item>
/// <item><description>Ensuring color consistency across different Office applications</description></item>
/// <item><description>Providing readable color specifications in XML (names instead of hex values)</description></item>
/// <item><description>Using colors that are guaranteed to render consistently</description></item>
/// </list>
/// </para>
/// <para>
/// Transformation values use the range 0-100000 to represent 0% to 100%, providing fine-grained
/// control with 1/1000th of a percent precision. Multiple transformations can be applied simultaneously.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a red color
/// var red = new PresetColor 
/// { 
///     Val = PresetColorKind.Red
/// };
/// 
/// // Create a semi-transparent light blue
/// var lightBlue = new PresetColor
/// {
///     Val = PresetColorKind.Blue,
///     Tint = new Percent(40),        // 40% lighter
///     Alpha = 50000                  // 50% opacity
/// };
/// 
/// // Create a desaturated green
/// var mutedGreen = new PresetColor
/// {
///     Val = PresetColorKind.Green,
///     SaturationModulation = 50000  // 50% saturation
/// };
/// </code>
/// </example>
public interface PresetColor: IModelElement
{
  /// <summary>
  /// Gets or sets the preset color name that defines the base color.
  /// </summary>
  /// <value>
  /// A <see cref="PresetColorKind"/> value representing one of the predefined color names
  /// (e.g., Red, Blue, AliceBlue, AntiqueWhite). If <see langword="null"/>, no preset color is specified.
  /// </value>
  /// <remarks>
  /// <para>
  /// The preset color names are defined by the Office Open XML standard and include:
  /// <list type="bullet">
  /// <item><description><b>Basic colors:</b> Black, White, Red, Green, Blue, Yellow, Cyan, Magenta</description></item>
  /// <item><description><b>Extended colors:</b> Named colors from the X11/Web color palette (e.g., AliceBlue, Coral, DarkGoldenrod)</description></item>
  /// <item><description><b>System colors:</b> Colors that may reference system theme colors on some platforms</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Each preset color name maps to a specific RGB value as defined by the Office Open XML specification.
  /// These mappings ensure consistent color rendering across different applications and platforms.
  /// </para>
  /// </remarks>
  public PresetColorKind? Val { get; set; }
  
  /// <summary>
  /// Gets or sets the tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the preset color by mixing it with white. 
  /// The <see cref="IPercent"/> value typically ranges from 0% to 100%, where:
  /// <list type="bullet">
  /// <item><description>0% or null = no tint applied (original preset color)</description></item>
  /// <item><description>50% = preset color mixed 50/50 with white</description></item>
  /// <item><description>100% = fully white (original color completely lightened)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  public IPercent? Tint { get; set; }
  
  /// <summary>
  /// Gets or sets the shade value to darken the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade value darkens the preset color by mixing it with black.
  /// The <see cref="IPercent"/> value typically ranges from 0% to 100%, where:
  /// <list type="bullet">
  /// <item><description>0% or null = no shade applied (original preset color)</description></item>
  /// <item><description>50% = preset color mixed 50/50 with black</description></item>
  /// <item><description>100% = fully black (original color completely darkened)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  public IPercent? Shade { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the complement (opposite) color operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the preset color is transformed to its complement on the color wheel
  /// (e.g., red becomes cyan, green becomes magenta, blue becomes yellow). Default is <see langword="false"/>.
  /// This transformation is applied after the base color is resolved from the preset name.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Complement { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the color inversion operation is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, each RGB component of the preset color is inverted (255 - value),
  /// creating a negative effect. Default is <see langword="false"/>.
  /// This is different from complement, which rotates the hue 180 degrees on the color wheel.
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Inverse { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the color is converted to grayscale.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the preset color is desaturated to create a grayscale value
  /// based on the perceived luminance of the original color. Default is <see langword="false"/>.
  /// The luminance calculation typically uses weighted RGB values (e.g., 0.299*R + 0.587*G + 0.114*B).
  /// </remarks>
  [DefaultValue(false)]
  public Boolean Gray { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute alpha (transparency) value.
  /// </summary>
  /// <remarks>
  /// Specifies the opacity of the preset color where 0 is fully transparent and 100000 is fully opaque (100%).
  /// Values in between create semi-transparent colors. If <see langword="null"/>, full opacity (100000) is assumed.
  /// For example, 50000 (50%) makes the color half-transparent, useful for overlays and watermarks.
  /// </remarks>
  public Int32? Alpha { get; set; }
  
  /// <summary>
  /// Gets or sets the alpha (transparency) offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the base alpha value. Range is typically -100000 to +100000.
  /// Positive values increase opacity (make less transparent), negative values increase transparency (make more transparent).
  /// Applied after any absolute <see cref="Alpha"/> value is set.
  /// </remarks>
  public Int32? AlphaOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the alpha (transparency) modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the base alpha by this percentage. A value of 50000 (50%) makes the color twice as transparent.
  /// Range is 0 to 100000, where 100000 means no change to transparency.
  /// For example, if alpha is 80000 (80% opaque) and modulation is 50000 (50%), the result is 40000 (40% opaque).
  /// </remarks>
  public Int32? AlphaModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute hue value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the hue angle in degrees (0-360), represented as 0-21600000 units (1/60000th of a degree).
  /// Overrides the hue component of the preset color while maintaining saturation and luminance.
  /// Hue represents the color's position on the color wheel: 0=red, 60=yellow, 120=green, 180=cyan, 240=blue, 300=magenta.
  /// </remarks>
  public Int32? Hue { get; set; }
  
  /// <summary>
  /// Gets or sets the hue offset adjustment in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the preset color's hue value to shift the color around the color wheel.
  /// Values wrap around at 360 degrees (adding 360 degrees returns to the same hue).
  /// Positive values shift toward warmer colors (red/yellow), negative toward cooler colors (blue/green).
  /// </remarks>
  public Int32? HueOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the hue modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the preset color's hue by this percentage. Used for relative hue adjustments.
  /// Range is 0 to 100000, where 100000 means no change.
  /// Values less than 100000 compress the hue range, while values greater than 100000 expand it.
  /// </remarks>
  public Int32? HueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute saturation value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the color saturation where 0 is grayscale (no color) and 100000 is fully saturated (100%).
  /// Overrides the saturation component of the preset color.
  /// Saturation determines the intensity or vividness of the color. Low saturation creates muted, pastel colors;
  /// high saturation creates vibrant, vivid colors.
  /// </remarks>
  public Int32? Saturation { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the preset color's saturation value. Range is typically -100000 to +100000.
  /// Positive values make colors more vivid and intense, negative values make them more gray and muted.
  /// Commonly used to create color variations that are either more or less vibrant than the base preset color.
  /// </remarks>
  public Int32? SaturationOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the saturation modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the preset color's saturation by this percentage. A value of 50000 (50%) reduces saturation by half,
  /// creating a more muted version of the color. Range is 0 to 100000, where 100000 means no change.
  /// Commonly used to create pastel or desaturated variations of preset colors for subtle color schemes.
  /// </remarks>
  public Int32? SaturationModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute luminance value in the HSL color space.
  /// </summary>
  /// <remarks>
  /// Specifies the brightness where 0 is black, 50000 is the color at normal brightness (50%), 
  /// and 100000 is white. Overrides the luminance component of the preset color.
  /// Luminance determines how light or dark the color appears overall. At 0%, any color becomes black;
  /// at 100%, any color becomes white; at 50%, the color appears at its natural brightness.
  /// </remarks>
  public Int32? Luminance { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the preset color's luminance value. Range is typically -100000 to +100000.
  /// Positive values make colors lighter (toward white), negative values make them darker (toward black).
  /// This is an alternative to using tint/shade, providing more precise control over brightness in HSL space.
  /// </remarks>
  public Int32? LuminanceOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the luminance modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the preset color's luminance by this percentage. A value of 50000 (50%) reduces brightness by half,
  /// creating a darker version. Range is 0 to 100000, where 100000 means no change.
  /// Commonly used to create lighter or darker variations of preset colors while maintaining their hue and saturation.
  /// </remarks>
  public Int32? LuminanceModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute red channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the red component (0-100000 representing 0-255) of the preset color's RGB value.
  /// Use this to set an explicit red value independent of the preset color definition.
  /// When set, this value takes precedence over the red component derived from the preset color name.
  /// </remarks>
  public Int32? Red { get; set; }
  
  /// <summary>
  /// Gets or sets the red channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the red channel value derived from the preset color. Range is typically -100000 to +100000.
  /// Positive values add more red to the color, negative values reduce red.
  /// Applied after the base red value is resolved from the preset color name.
  /// </remarks>
  public Int32? RedOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the red channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the red channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the red component by half, shifting the color away from red.
  /// Useful for fine-tuning the color balance of preset colors.
  /// </remarks>
  public Int32? RedModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute green channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the green component (0-100000 representing 0-255) of the preset color's RGB value.
  /// Use this to set an explicit green value independent of the preset color definition.
  /// When set, this value takes precedence over the green component derived from the preset color name.
  /// </remarks>
  public Int32? Green { get; set; }
  
  /// <summary>
  /// Gets or sets the green channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the green channel value derived from the preset color. Range is typically -100000 to +100000.
  /// Positive values add more green to the color, negative values reduce green.
  /// Applied after the base green value is resolved from the preset color name.
  /// </remarks>
  public Int32? GreenOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the green channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the green channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the green component by half, shifting the color away from green.
  /// Useful for fine-tuning the color balance of preset colors.
  /// </remarks>
  public Int32? GreenModulation { get; set; }
  
  /// <summary>
  /// Gets or sets the absolute blue channel value override.
  /// </summary>
  /// <remarks>
  /// Overrides the blue component (0-100000 representing 0-255) of the preset color's RGB value.
  /// Use this to set an explicit blue value independent of the preset color definition.
  /// When set, this value takes precedence over the blue component derived from the preset color name.
  /// </remarks>
  public Int32? Blue { get; set; }
  
  /// <summary>
  /// Gets or sets the blue channel offset adjustment.
  /// </summary>
  /// <remarks>
  /// Adds or subtracts from the blue channel value derived from the preset color. Range is typically -100000 to +100000.
  /// Positive values add more blue to the color, negative values reduce blue.
  /// Applied after the base blue value is resolved from the preset color name.
  /// </remarks>
  public Int32? BlueOffset { get; set; }
  
  /// <summary>
  /// Gets or sets the blue channel modulation percentage.
  /// </summary>
  /// <remarks>
  /// Multiplies the blue channel by this percentage. Range is 0 to 100000, where 100000 means no change.
  /// A value of 50000 (50%) reduces the blue component by half, shifting the color away from blue.
  /// Useful for fine-tuning the color balance of preset colors.
  /// </remarks>
  public Int32? BlueModulation { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies standard gamma correction (typically gamma 2.2)
  /// to the preset color to convert from linear RGB space to display-corrected RGB. 
  /// Default is <see langword="false"/>.
  /// Gamma correction adjusts colors to appear correct on display devices by compensating for
  /// the non-linear response of monitors.
  /// </remarks>
  public Boolean Gamma { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether inverse gamma correction is applied.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, applies inverse gamma correction to the preset color
  /// to convert from display-corrected RGB to linear RGB space. Default is <see langword="false"/>.
  /// This is the opposite of standard gamma correction and is used in certain color processing pipelines.
  /// </remarks>
  public Boolean InverseGamma { get; set; }
}