namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color that references a theme color scheme with optional transformations.
/// This class enables dynamic color theming in Word documents by referencing colors from the 
/// document's theme (e.g., Accent1, Dark1, Light2) rather than using fixed RGB values.
/// When the document theme changes, scheme colors automatically update to match the new theme.
/// </summary>
[OpenXmlType(typeof(DXD.SchemeColor))]
[XmlRoot("SchemeColor", Namespace = "DocumentModel.Drawings")]
public partial class SchemeColor : Color<DXD.SchemeColor>, IDrawingColor
{

  /// <summary>
  /// Gets or sets the scheme color identifier that references a specific color role in the document theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SchemeColor.Val))]
  public SchemeColors? Index { get => _index; set => UpdateField(ref _index, value, nameof(Index)); }
  private SchemeColors? _index;

  /// <summary>
  /// Tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the base color by mixing it with white. 
  /// Values range from 0 to 100,000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint applied (original color)</description></item>
  /// <item><description>50,000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100,000 = 100% tint (fully white)</description></item>
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
  /// Values range from 0 to 100,000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade applied (original color)</description></item>
  /// <item><description>50,000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100,000 = 100% shade (fully black)</description></item>
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