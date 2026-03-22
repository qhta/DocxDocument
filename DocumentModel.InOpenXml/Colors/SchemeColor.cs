namespace DocumentModel;
/// <summary>
/// Represents a color that references a theme color scheme with optional transformations.
/// This class enables dynamic color theming in Word documents by referencing colors from the 
/// document's theme (e.g., Accent1, Dark1, Light2) rather than using fixed RGB values.
/// When the document theme changes, scheme colors automatically update to match the new theme.
/// </summary>
[OpenXmlType(typeof(DXD.SchemeColor))]
public partial class SchemeColor : AbstractColor<DXD.SchemeColor>
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
 public SchemeColors? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
 private SchemeColors? _Val;
}