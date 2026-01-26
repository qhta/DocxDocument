namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents underline formatting for a text run in WordprocessingML documents.
/// This class provides properties for underline style, color, theme color, and theme color tint/shade, enabling advanced underline customization for character-level formatting.
/// </summary>
[OpenXmlType(typeof(DXW.Underline))]
public partial class Underline : ModelElement<DXW.Underline>
{
 /// <summary>
 /// Underline style, specifying the type of underline applied to the text (e.g., single, double, dotted).
 /// </summary>
 [OpenXmlElement(typeof(DXW.Underline))]
 public UnderlineKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private UnderlineKind? _Type;
 /// <summary>
 /// Underline color, specified as a hex RGB value or named color.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Underline.Color))]
 /// <summary>
 /// Underline color, specified as a hex RGB value or named color.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Underline))]
 public Color? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

 private Color? _Color;
 /// <summary>
 /// Theme color index for the underline, enabling theme-aware underline coloring.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Underline.ThemeColor))]
 /// <summary>
 /// Theme color index for the underline, enabling theme-aware underline coloring.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Underline))]
 public ThemeColorIndex? ThemeColor { get => _ThemeColor; set => UpdateField(ref _ThemeColor, value, nameof(ThemeColor)); }

 private ThemeColorIndex? _ThemeColor;
 /// <summary>
 /// Theme color tint for the underline, specifying a lighter variation of the theme color.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Underline.ThemeTint))]
 /// <summary>
 /// Theme color tint for the underline, specifying a lighter variation of the theme color.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Underline))]
 public string? ThemeTint { get => _ThemeTint; set => UpdateField(ref _ThemeTint, value, nameof(ThemeTint)); }

 private string? _ThemeTint;
 /// <summary>
 /// Theme color shade for the underline, specifying a darker variation of the theme color.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Underline.ThemeShade))]
 /// <summary>
 /// Theme color shade for the underline, specifying a darker variation of the theme color.
 /// </summary>
 [OpenXmlElement(typeof(DXW.Underline))]
 public string? ThemeShade { get => _ThemeShade; set => UpdateField(ref _ThemeShade, value, nameof(ThemeShade)); }

 private string? _ThemeShade;
}