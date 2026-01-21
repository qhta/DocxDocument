namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents underline formatting for a text run in WordprocessingML documents.
/// This interface provides properties for underline style, color, theme color, and theme color tint/shade, enabling advanced underline customization for character-level formatting.
/// </summary>
public partial class Underline : ModelElement<DXW.Underline>
{
  /// <summary>
  /// Underline style, specifying the type of underline applied to the text (e.g., single, double, dotted).
  /// </summary>
  public UnderlineKind? Type { get; set; }
  /// <summary>
  /// Underline color, specified as a hex RGB value or named color.
  /// </summary>
  public Color? Color { get; set; }
  /// <summary>
  /// Theme color index for the underline, enabling theme-aware underline coloring.
  /// </summary>
  public ThemeColorIndex? ThemeColor { get; set; }
  /// <summary>
  /// Theme color tint for the underline, specifying a lighter variation of the theme color.
  /// </summary>
  public string? ThemeTint { get; set; }
  /// <summary>
  /// Theme color shade for the underline, specifying a darker variation of the theme color.
  /// </summary>
  public string? ThemeShade { get; set; }
}