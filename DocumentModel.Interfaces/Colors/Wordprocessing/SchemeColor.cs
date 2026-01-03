namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a color that references a theme color scheme with optional transformations.
/// This class enables dynamic color theming in Word documents by referencing colors from the 
/// document's theme (e.g., Accent1, Dark1, Light2) rather than using fixed RGB values.
/// When the document theme changes, scheme colors automatically update to match the new theme.
/// </summary>
/// <remarks>
/// <para>
/// Scheme colors are a fundamental part of the Office Open XML theming system introduced in Office 2007
/// and enhanced in Office 2010. Unlike fixed colors (RGB, preset), scheme colors provide:
/// <list type="bullet">
/// <item><description><b>Dynamic theming:</b> Colors automatically adapt when document themes change</description></item>
/// <item><description><b>Consistency:</b> Ensures color coordination across document elements</description></item>
/// <item><description><b>Flexibility:</b> Apply transformations while maintaining theme relationships</description></item>
/// <item><description><b>Professional appearance:</b> Leverages professionally designed color schemes</description></item>
/// </list>
/// </para>
/// <para>
/// The scheme color system includes predefined color roles in the document theme:
/// <list type="bullet">
/// <item><description><b>Background colors:</b> Background1, Background2 (typically light colors)</description></item>
/// <item><description><b>Text colors:</b> Text1, Text2 (typically dark colors for readability)</description></item>
/// <item><description><b>Accent colors:</b> Accent1 through Accent6 (theme accent colors for highlights, charts, etc.)</description></item>
/// <item><description><b>Hyperlink colors:</b> Hyperlink, FollowedHyperlink (for link styling)</description></item>
/// <item><description><b>Dark/Light:</b> Dark1, Dark2, Light1, Light2 (for high-contrast elements)</description></item>
/// </list>
/// </para>
/// <para>
/// Transformations can be applied to scheme colors to create variations (lighter, darker, more saturated)
/// while maintaining the connection to the theme. When the theme changes, both the base color and
/// transformations are applied to the new theme's color values.
/// </para>
/// <para>
/// This interface is part of the WordprocessingML color system and is typically used for text colors,
/// borders, shading, and other document formatting. For DrawingML objects (shapes, charts),
/// use <see cref="DocumentModel.Drawings.SchemeColor"/> instead.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Reference the first accent color from the theme
/// var accentColor = new SchemeColor 
/// { 
///     Val = SchemeColorKind.Accent1 
/// };
/// 
/// // Create a lighter version of the second accent color
/// var lightAccent = new SchemeColor
/// {
///     Val = SchemeColorKind.Accent2,
///     Tint = 60000,                  // 60% lighter
///     LuminanceModulation = 40000    // Reduce luminance to 40%
/// };
/// 
/// // Create a semi-transparent theme text color
/// var transparentText = new SchemeColor
/// {
///     Val = SchemeColorKind.Text1,
///     Alpha = 50000                  // 50% opacity
/// };
/// </code>
/// </example>
public interface SchemeColor : IModelElement
{
  /// <summary>
  /// Gets or sets the scheme color identifier that references a specific color role in the document theme.
  /// </summary>
  /// <remarks>
  /// <para>
  /// This property specifies which color from the document's active theme should be used as the base color.
  /// The actual RGB value is determined by the theme definition and will change if a different theme is applied.
  /// </para>
  /// <para>
  /// Common scheme color values and their typical uses:
  /// <list type="bullet">
  /// <item><description><b>Text1, Text2:</b> Primary and secondary text colors (usually dark)</description></item>
  /// <item><description><b>Background1, Background2:</b> Primary and secondary background colors (usually light)</description></item>
  /// <item><description><b>Accent1-Accent6:</b> Theme accent colors for emphasis, charts, highlights</description></item>
  /// <item><description><b>Hyperlink:</b> Default color for hyperlinks</description></item>
  /// <item><description><b>FollowedHyperlink:</b> Color for visited hyperlinks</description></item>
  /// <item><description><b>Dark1, Dark2:</b> Dark colors for high-contrast elements</description></item>
  /// <item><description><b>Light1, Light2:</b> Light colors for high-contrast elements</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Documents using scheme colors
  /// require compatibility with Office 2010 or higher to display correctly.
  /// </para>
  /// </remarks>
  public SchemeColorKind? Val { get; set; }

  /// <summary>
  /// Gets or sets the tint value to lighten the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint lightens the theme color by mixing it with white. Values range from 0 to 100000:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint (original theme color)</description></item>
  /// <item><description>50000 = 50% tint (theme color mixed 50/50 with white)</description></item>
  /// <item><description>100000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tint is commonly used to create lighter variations of theme colors for backgrounds, highlights,
  /// or subtle accents while maintaining the connection to the theme. For example, a 60% tint of
  /// Accent1 creates a light background that coordinates with text or shapes using the full Accent1 color.
  /// </para>
  /// <para>
  /// Tint and shade are mutually exclusive transformations; typically only one should be applied.
  /// </para>
  /// </remarks>
  public Int32? Tint { get; set; }

  /// <summary>
  /// Gets or sets the shade value to darken the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade darkens the theme color by mixing it with black. Values range from 0 to 100000:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade (original theme color)</description></item>
  /// <item><description>50000 = 50% shade (theme color mixed 50/50 with black)</description></item>
  /// <item><description>100000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade is commonly used to create darker variations of theme colors for text on light backgrounds,
  /// borders, or emphasis elements while maintaining theme consistency. For example, a 50% shade of
  /// Accent1 provides good contrast when the full Accent1 color is used for backgrounds.
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive transformations; typically only one should be applied.
  /// </para>
  /// </remarks>
  public Int32? Shade { get; set; }

  /// <summary>
  /// Gets or sets the absolute alpha (transparency) value for the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Specifies the opacity of the theme color:
  /// <list type="bullet">
  /// <item><description>0 = fully transparent (invisible)</description></item>
  /// <item><description>50000 = 50% transparent (semi-transparent)</description></item>
  /// <item><description>100000 or null = fully opaque (default)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Alpha transparency is useful for creating watermarks, subtle backgrounds, or overlay effects
  /// that allow underlying content to show through while maintaining theme color coordination.
  /// Transparent theme colors are commonly used in:
  /// <list type="bullet">
  /// <item><description>Cell shading with visible grid lines</description></item>
  /// <item><description>Layered graphic effects</description></item>
  /// <item><description>Text highlighting that doesn't completely obscure background</description></item>
  /// <item><description>Watermarks and draft markings</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public Int32? Alpha { get; set; }

  /// <summary>
  /// Gets or sets the hue modulation percentage for the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Multiplies the theme color's hue by this percentage. Range is 0 to 100000:
  /// <list type="bullet">
  /// <item><description>100000 or null = no change to hue</description></item>
  /// <item><description>50000 = hue compressed to 50% of original range</description></item>
  /// <item><description>Values &lt; 100000 = compress the hue range</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Hue modulation provides fine-grained control over the color's position on the color wheel
  /// while maintaining the theme relationship. This is less commonly used than tint/shade
  /// but provides advanced color adjustments for sophisticated color schemes.
  /// </para>
  /// </remarks>
  public Int32? HueModulation { get; set; }

  /// <summary>
  /// Gets or sets the absolute saturation value for the scheme color in HSL color space.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Overrides the saturation component of the theme color:
  /// <list type="bullet">
  /// <item><description>0 = completely desaturated (grayscale)</description></item>
  /// <item><description>50000 = 50% saturated (muted color)</description></item>
  /// <item><description>100000 or null = fully saturated (vibrant color, or theme's original saturation)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Setting an absolute saturation value is useful for creating consistent muted or vibrant
  /// variations across multiple theme colors. For example, setting saturation to 30000 on all
  /// accent colors creates a uniformly muted color palette while maintaining theme coordination.
  /// </para>
  /// </remarks>
  public Int32? Saturation { get; set; }

  /// <summary>
  /// Gets or sets the saturation offset adjustment for the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Adds or subtracts from the theme color's saturation:
  /// <list type="bullet">
  /// <item><description>Positive values = increase saturation (more vivid)</description></item>
  /// <item><description>Negative values = decrease saturation (more muted/gray)</description></item>
  /// <item><description>0 or null = no change</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Saturation offset is useful for creating slightly more or less vivid versions of theme colors
  /// while maintaining relative differences between colors. For example, reducing saturation by 20000
  /// across all theme colors creates a softer, more subdued appearance while preserving the theme's
  /// color relationships.
  /// </para>
  /// </remarks>
  public Int32? SaturationOffset { get; set; }

  /// <summary>
  /// Gets or sets the saturation modulation percentage for the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Multiplies the theme color's saturation by this percentage:
  /// <list type="bullet">
  /// <item><description>100000 or null = no change</description></item>
  /// <item><description>50000 = saturation reduced to 50% (more muted)</description></item>
  /// <item><description>150000 = saturation increased to 150% (more vivid)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Saturation modulation is commonly used to create pastel or muted variations of theme colors.
  /// For example, a saturation modulation of 50000 (50%) creates soft, gentle colors suitable for
  /// backgrounds while maintaining theme coordination. This is particularly useful for creating
  /// alternating row shading, callout boxes, or other elements that need subtle theme colors.
  /// </para>
  /// </remarks>
  public Int32? SaturationModulation { get; set; }

  /// <summary>
  /// Gets or sets the absolute luminance (brightness) value for the scheme color in HSL color space.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Overrides the luminance component of the theme color:
  /// <list type="bullet">
  /// <item><description>0 = black (no brightness)</description></item>
  /// <item><description>50000 = normal brightness for the theme color</description></item>
  /// <item><description>100000 or null = white (maximum brightness, or theme's original luminance)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Setting an absolute luminance value is useful for ensuring consistent brightness levels
  /// across different theme colors, which can be important for accessibility and readability.
  /// For example, setting luminance to 80000 on all text colors ensures adequate contrast
  /// against dark backgrounds regardless of which theme is active.
  /// </para>
  /// </remarks>
  public Int32? Luminance { get; set; }

  /// <summary>
  /// Gets or sets the luminance (brightness) offset adjustment for the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Adds or subtracts from the theme color's luminance:
  /// <list type="bullet">
  /// <item><description>Positive values = lighter (toward white)</description></item>
  /// <item><description>Negative values = darker (toward black)</description></item>
  /// <item><description>0 or null = no change</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Luminance offset provides an alternative to tint/shade with more precise control in HSL color space.
  /// Unlike tint (which mixes with white) and shade (which mixes with black), luminance offset
  /// adjusts brightness while potentially preserving more of the original color's saturation.
  /// This can create more vibrant light or dark variations compared to tint/shade.
  /// </para>
  /// </remarks>
  public Int32? LuminanceOffset { get; set; }

  /// <summary>
  /// Gets or sets the luminance (brightness) modulation percentage for the scheme color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Multiplies the theme color's luminance by this percentage:
  /// <list type="bullet">
  /// <item><description>100000 or null = no change</description></item>
  /// <item><description>50000 = luminance reduced to 50% (darker)</description></item>
  /// <item><description>150000 = luminance increased to 150% (lighter)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Luminance modulation is one of the most commonly used transformations for theme colors in Word.
  /// It creates proportional brightness variations that work well across different themes. Common patterns:
  /// <list type="bullet">
  /// <item><description><b>40000 (40%):</b> Dark variation for text or borders</description></item>
  /// <item><description><b>60000 (60%):</b> Medium variation for secondary elements</description></item>
  /// <item><description><b>80000 (80%):</b> Light variation for subtle backgrounds</description></item>
  /// <item><description><b>95000 (95%):</b> Very light variation for table shading</description></item>
  /// </list>
  /// These modulation values create consistent, professional-looking documents that adapt well
  /// to different themes while maintaining good contrast and readability.
  /// </para>
  /// </remarks>
  public Int32? LuminanceModulation { get; set; }
}