namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color using a predefined color name with optional transformations.
/// This is the preset color variant used in Office Open XML DrawingML, allowing colors to be 
/// specified by name (e.g., "Red", "Blue", "AliceBlue") from a standard palette, with optional 
/// modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
[OpenXmlType(typeof(DXD.PresetColor))]
[XmlRoot("PresetColor", Namespace = "DocumentModel.Drawings")]
public partial class PresetColor : AbstractColor<DXD.PresetColor>, ISchemeBaseColor, IDrawingColor
{

  /// <summary>
  /// Gets or sets the preset color name that defines the base color.
  /// </summary>
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
  [OpenXmlProperty(nameof(DXD.PresetColor.Val))]
  public PresetColors? Val { get => _val; set => UpdateField(ref _val, value, nameof(RGB)); }
  private PresetColors? _val;

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