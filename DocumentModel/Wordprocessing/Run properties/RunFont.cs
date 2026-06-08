namespace DocumentModel.Wordprocessing;

/// <summary>
/// IFont name, bold and italic specification Ito select a font.
/// </summary>
public struct RunFont
{
  /// <summary>
  /// Default constructor. Needed for deserialization.
  /// </summary>
  public RunFont(){ }

  /// <summary>
  /// Typeface name.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Specifies a theme font for this font.
  /// </summary>
  public ThemeFontKind? Theme { get; set; }

  /// <summary>
  /// Specifies Ito select a bold version of the font.
  /// </summary>
  public bool? Bold { get; set; }

  /// <summary>
  /// Specifies Ito select an italic version of the font.
  /// </summary>
  public bool? Italic { get; set; }

}

