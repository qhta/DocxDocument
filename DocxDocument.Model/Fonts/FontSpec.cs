namespace DocxDocument.Model;

/// <summary>
/// Speficies font typeface and other identifying data.
/// </summary>
public class FontSpec
{
  /// <summary>
  /// Specifies the script handled by the font.
  /// </summary>
  [XmlAttribute]
  [Key]
  public string? Script { get; set; }

  /// <summary>
  /// Specifies the typeface name of the font.
  /// </summary>
  [XmlAttribute]
  public string? Typeface { get; set; }

  /// <summary>
  /// Specifies the Panose hex identifier of the font.
  /// Can be used when a font with a specific typeface name can't be found.
  /// </summary>
  [XmlAttribute]
  public string? Panose { get; set; }

  /// <summary>
  /// Specifies the character set number of the font.
  /// Can be used to check if the font has needed glyphs.
  /// Three are the most important: 0 - ANSI, 1 - default, 2 - symbol.
  /// </summary>
  [XmlAttribute]
  public byte? Charset { get; set; }

  /// <summary>
  /// Specifies the pitch of font characters: default, fixed or variable.
  /// </summary>
  [XmlAttribute]
  public FontPitch? Pitch { get; set; }
}