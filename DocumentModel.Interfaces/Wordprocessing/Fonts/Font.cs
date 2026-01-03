namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies the properties for one of the fonts used in this document. 
///   A font element shall be written out for each font face used in the document, and includes:
///   <list type="bullet">
///     <item>
///       The name of the font as used in the document's stories
///     </item>
///     <item>
///       (optionally) Font metrics allowing other applications to locate appropriate substitute fonts as needed
///     </item>
///     <item>
///       (optionally) Embedded forms of the font
///     </item>
///   </list>
/// </summary>
public interface Font : IModelElement
{
  /// <summary>
  ///   Specifies the primary name of the current font. 
  ///   This name shall be used to link the information stored in this element 
  ///   with uses of this value in the rFonts element (§17.3.2.26) in document content.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Specifies a set of alternative names which can be used to locate the font specified by the parent element. 
  ///   This set of alternative names is stored in a comma-delimited list, with all adjacent commas ignored 
  ///   (i.e. a value of Name A, Name B is equivalent to Name A,,,,,,,,, Name B). 
  /// </summary>
  public IStringList? Aliases { get; set; }
  /// <summary>
  ///   Specifies the Panose-1 classification number shown in §5.2.7.17 of ISO/IEC 14496-22. 
  ///   This information can be used as defined in font substitution logic 
  ///   to locate an appropriate substitute font when this font is not available. 
  ///   This information is determined by querying the font when present 
  ///   and shall not be modified when the font is not available.
  /// </summary>
  public IHexBinary? Panose { get; set; }
  /// <summary>
  ///   Specifies the character set which is supported by the parent font. 
  ///   This information can be used as defined in font substitution logic 
  ///   to locate an appropriate substitute font when this font is not available. 
  ///   This information is determined by querying the font when present 
  ///   and shall not be modified when the font is not available. .
  /// </summary>
  public Charset? FontCharSet { get; set; }
  /// <summary>
  ///   FontFamily.
  /// </summary>
  public FontFamilyKind? FontFamily { get; set; }
  /// <summary>
  ///   NotTrueType.
  /// </summary>
  public bool? NotTrueType { get; set; }
  /// <summary>
  ///   Pitch.
  /// </summary>
  public FontPitchKind? Pitch { get; set; }
  /// <summary>
  ///   FontSignature.
  /// </summary>
  public FontSignature? FontSignature { get; set; }
  /// <summary>
  ///   EmbedRegularFont.
  /// </summary>
  public EmbeddedFont? EmbedRegularFont { get; set; }

  /// <summary>
  ///   EmbedBoldFont.
  /// </summary>
  public EmbeddedFont? EmbedBoldFont { get; set; }

  /// <summary>
  ///   EmbedItalicFont.
  /// </summary>
  public EmbeddedFont? EmbedItalicFont { get; set; }

  /// <summary>
  ///   EmbedBoldItalicFont.
  /// </summary>
  public EmbeddedFont? EmbedBoldItalicFont { get; set; }

  /// <summary>
  ///   Collection of embedded fonts.
  /// </summary>
  public EmbeddedFonts? EmbeddedFonts { get; set; }
}