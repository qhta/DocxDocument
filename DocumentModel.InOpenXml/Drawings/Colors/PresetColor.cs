namespace DocumentModel.Drawings;
/// <summary>
/// Represents a color using a predefined color name with optional transformations.
/// This class allows colors to be 
/// specified by name (e.g., "Red", "Blue", "AliceBlue") from a standard palette, with optional 
/// modifications like tint, shade, alpha transparency, and hue/saturation/luminance adjustments.
/// </summary>
[OpenXmlType(typeof(DXD.PresetColor))]
[XmlRoot("PresetColor", Namespace = "DocumentModel.Drawings")]
public partial class PresetColor : DrawingsColorBase<DXD.PresetColor>, ISchemeBaseColor, IDrawingColor
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
  public PresetColors? Index { get => _index; set => UpdateField(ref _index, value, nameof(Index)); }
  private PresetColors? _index;

}