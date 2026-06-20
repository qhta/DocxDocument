namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a color that references a theme color scheme with optional transformations.
/// This class enables dynamic color theming in Word documents by referencing colors from the 
/// document's theme (e.g., Accent1, Dark1, Light2) rather than using fixed RGB values.
/// When the document theme changes, scheme colors automatically update to match the new theme.
/// </summary>
[OpenXmlType(typeof(DXO10W.SchemeColor))]
[XmlRoot("SchemeColor", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class SchemeColor : Color<DXO10W.SchemeColor>
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
  [OpenXmlProperty(nameof(DXO10W.SchemeColor.Val))]
  public DMD.SchemeColors? Index { get => _index; set => UpdateField(ref _index, value, nameof(Index)); }
  private DMD.SchemeColors? _index;

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
  [OpenXmlElement(typeof(DXO10W.Tint))]
  public DMD.Percentage? Tint { get => _Tint; set => UpdateField(ref _Tint, value, nameof(Tint)); }
  private DMD.Percentage? _Tint;

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
  [OpenXmlElement(typeof(DXO10W.Shade))]
  public DMD.Percentage? Shade { get => _Shade; set => UpdateField(ref _Shade, value, nameof(Shade)); }
  private DMD.Percentage? _Shade;

}