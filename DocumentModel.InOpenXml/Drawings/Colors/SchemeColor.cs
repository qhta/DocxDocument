namespace DocumentModel.Drawings;

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
public interface SchemeColor: ColorType, DrawingColorModifications
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
}