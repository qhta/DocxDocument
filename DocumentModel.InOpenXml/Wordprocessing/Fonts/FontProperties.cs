namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the properties for a font used in a WordprocessingML document.
  /// A font element is written for each font face used in the document and includes the font name, optional font metrics for substitution, and optional embedded font forms.
  /// </summary>
  public class FontProperties: ModelElement
  {
    
    /// <summary>
    /// Primary name of the font, used to link font information with uses in the rFonts element in document content.
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// Set of alternative names for the font, stored as a comma-delimited list, used to locate the font if the primary name is unavailable.
    /// </summary>
    public StringList? Aliases { get; set; }
    
    /// <summary>
    /// Panose-1 classification number, used for font substitution logic to locate appropriate substitute fonts.
    /// </summary>
    public HexBinary? Panose { get; set; }
    
    /// <summary>
    /// Character set supported by the font, used for font substitution logic.
    /// </summary>
    public Charset? FontCharSet { get; set; }
    
    /// <summary>
    /// Font family classification (e.g., Roman, Swiss, Modern).
    /// </summary>
    public FontFamilyKind? FontFamily { get; set; }
    
    /// <summary>
    /// Indicates whether the font is not a TrueType font.
    /// </summary>
    public bool? NotTrueType { get; set; }
    
    /// <summary>
    /// Pitch of the font (e.g., fixed, variable).
    /// </summary>
    public FontPitchKind? Pitch { get; set; }
    
    /// <summary>
    /// Font signature information, including Unicode subset and code page bitfields.
    /// </summary>
    public FontSignature? FontSignature { get; set; }
    
    ///// <summary>
    ///// Embedded regular font resource for this font face.
    ///// </summary>
    //public EmbeddedFont? EmbedRegularFont { get; set; }
    
    ///// <summary>
    ///// Embedded bold font resource for this font face.
    ///// </summary>
    //public EmbeddedFont? EmbedBoldFont { get; set; }
    
    ///// <summary>
    ///// Embedded italic font resource for this font face.
    ///// </summary>
    //public EmbeddedFont? EmbedItalicFont { get; set; }
    
    ///// <summary>
    ///// Embedded bold italic font resource for this font face.
    ///// </summary>
    //public EmbeddedFont? EmbedBoldItalicFont { get; set; }
    
    ///// <summary>
    ///// Collection of embedded fonts for this font face, supporting multiple font forms.
    ///// </summary>
    //public EmbeddedFonts? EmbeddedFonts { get; set; }
  }