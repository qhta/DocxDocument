namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the settings that are applied to a WordprocessingML document. 
/// Each setting is represented by appropriate property.
/// </summary>
[DataContract]
public partial class DocumentSettings: ModelElement
{

  public DocumentSettings() { }

  public DocumentSettings(DM.Document document)
  {
    _WordprocessingDocument = document._WordprocessingDocument;
    _DocumentSettings = _WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart?.Settings;
  }

  internal DXP.WordprocessingDocument? _WordprocessingDocument { get; private set; }

  internal DXW.Settings? _DocumentSettings { get; private set; }

  internal DXW.Settings _ExistingSettings
  {
    get
    {
      if (_DocumentSettings == null)
      {
        if (_WordprocessingDocument != null)
        {
          var mainDocumentPart = _WordprocessingDocument.MainDocumentPart;
          if (mainDocumentPart == null)
            mainDocumentPart = _WordprocessingDocument.AddMainDocumentPart();
          var settingsPart = mainDocumentPart.DocumentSettingsPart;
          if (settingsPart == null)
            settingsPart = mainDocumentPart.AddNewPart<DXP.DocumentSettingsPart>();
          _DocumentSettings = settingsPart.Settings;
          if (_DocumentSettings == null)
          {
            _DocumentSettings = new DXW.Settings();
            settingsPart.Settings = _DocumentSettings;
          }
        }
        else
          _DocumentSettings = new DXW.Settings();
      }
      Debug.Assert(_DocumentSettings != null);
      return _DocumentSettings;
    }
  }

  /// <summary>
  /// This element specifies the write protection settings which have been applied to a WordprocessingML document. 
  /// Write protection refers to a mode in which the document's contents cannot be edited, 
  /// and the document cannot be resaved using the same file name. 
  /// This setting is independent of the documentProtection (§17.15.1.29) element, 
  /// but like document protection, this setting is not intended as a security feature and can be ignored.
  /// When present, the write protection shall result in one of two write protection behaviors:
  /// <list type="bullet">
  ///   <item>
  ///     If the password attribute is present, or both attributes are omitted, 
  ///     then the application shall prompt for a password to exit write protection. 
  ///     If the supplied password does not match the hash value in this attribute, then write protection shall be enabled.
  ///   </item>
  ///   <item>
  ///    If only the recommended attribute is present, the application should provide user interface 
  ///    recommending that the user open this document in write protected state. 
  ///    If the user chooses to do so, the document shall be write protected, otherwise, it shall be opened fully editable.
  ///  </item>
  /// </list>
  /// If this element is omitted, then no write protection shall be applied to the current document.
  /// </summary>
  [DataMember]
  public DMW.WriteProtection? WriteProtection
  {
    get => _DocumentSettings?.GetObject<WriteProtection, DXW.WriteProtection>();
    set => _ExistingSettings.SetObject<WriteProtection, DXW.WriteProtection>(value);
  }

  /// <summary>
  /// This element specifies the manner in which the contents of this document should be displayed when opened by an application.
  /// </summary>
  [DataMember]
  public DMW.ViewKind? View
  {
    get => _DocumentSettings?.GetEnumVal<DMW.ViewKind, DXW.View>();
    set => _ExistingSettings?.SetEnumVal<DMW.ViewKind, DXW.View>(value);
  }

  /// <summary>
  /// This element specifies that hosting applications shall remove all personal information of document authors upon saving
  /// a given WordprocessingML document. The definition and extent of personal information is not defined by /IEC 29500.
  /// </summary>
  [DataMember]
  public bool? RemovePersonalInformation
  {
    get => _DocumentSettings?.GetBoolVal<DXW.RemovePersonalInformation>();
    set => _ExistingSettings.SetBoolVal<DXW.RemovePersonalInformation>(value);
  }

  /// <summary>
  /// This element specifies that the date and time information shall be removed from all annotations 
  /// which are present in the current document when it is saved. 
  /// Annotations store this information in the date attribute on the annotation's XML element.
  /// </summary>
  [DataMember]
  public bool? RemoveDateAndTime
  {
    get => _DocumentSettings?.GetBoolVal<DXW.RemoveDateAndTime>();
    set => _ExistingSettings.SetBoolVal<DXW.RemoveDateAndTime>(value);
  }

  /// <summary>
  /// This element specifies whether applications displaying this document should display the contents of the header and footer 
  /// when displaying the document in print layout view (§17.15.1.92) or should collapse those areas 
  /// as well as the whitespace on all displayed pages so that the text extents are directly following one another. 
  /// <para>
  /// [Rationale: Collapsing the ends of pages makes it easier to read the contents of the document, 
  /// since the text flows between pages without whitespace, while maintaining the WYSIWYG functionality 
  /// of print layout view for the document's main content. end rationale]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotDisplayPageBoundaries
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotDisplayPageBoundaries>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotDisplayPageBoundaries>(value);
  }

  /// <summary>
  /// This element specifies whether the images and colors defined in the document's background using the background element (§17.2.1) 
  /// shall be displayed when the document is displayed in print layout view as specified in the view element (§17.15.1.92).
  /// </summary>
  [DataMember]
  public bool? DisplayBackgroundShape
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DisplayBackgroundShape>();
    set => _ExistingSettings.SetBoolVal<DXW.DisplayBackgroundShape>(value);
  }

  /// <summary>
  /// This element specifies that the PostScript codes specified in WordprocessingML documents containing PRINT fields shall be included in foreground 
  /// (on the same Z-order as text) with the data printed in the contents of a given WordprocessingML document.
  /// <para>
  /// [Note: This setting is maintained to ensure compatibility of legacy word processing documents. 
  /// The PRINT field should not be used in lieu of newer technologies in /IEC 29500. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? PrintPostScriptOverText
  {
    get => _DocumentSettings?.GetBoolVal<DXW.PrintPostScriptOverText>();
    set => _ExistingSettings.SetBoolVal<DXW.PrintPostScriptOverText>(value);
  }

  /// <summary>
  /// This element specifies the contents of this document shall be printed with fractional character widths. 
  /// Fractional character widths exist when the spacing between characters is not constant (i.e. a proportional font face is used).
  /// <para>
  /// [Note: Fractional character widths are generally used in conjunction with large font sizes 
  /// to prevent characters from running together or having too much space between one another. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? PrintFractionalCharacterWidth
  {
    get => _DocumentSettings?.GetBoolVal<DXW.PrintFractionalCharacterWidth>();
    set => _ExistingSettings.SetBoolVal<DXW.PrintFractionalCharacterWidth>(value);
  }

  /// <summary>
  /// This element specifies that printing the contents of this document shall only print the contents 
  /// of WordprocessingML form fields defined using the FORMTEXT, FORMCHECKBOX, and FORMDROPDOWN field codes 
  /// in their current locations on the page - all other document contents shall be suppressed.
  /// <para>
  /// [Rationale: This setting is typically used to allow duplication of paper forms in electronic WordprocessingML document form, 
  /// allowing the resulting online document to be printed into the correct locations on the existing paper form. end rationale]
  /// </summary>
  /// </para>
  [DataMember]
  public bool? PrintFormsData
  {
    get => _DocumentSettings?.GetBoolVal<DXW.PrintFormsData>();
    set => _ExistingSettings.SetBoolVal<DXW.PrintFormsData>(value);
  }

  /// <summary>
  /// This element specifies that applications shall embed the fonts in use in this document when it is saved. 
  /// These fonts shall be embedded subject to the algorithm specified in §17.8.1.
  /// </summary>
  [DataMember]
  public bool? EmbedTrueTypeFonts
  {
    get => _DocumentSettings?.GetBoolVal<DXW.EmbedTrueTypeFonts>();
    set => _ExistingSettings.SetBoolVal<DXW.EmbedTrueTypeFonts>(value);
  }

  /// <summary>
  /// This element specifies that applications shall embed common system fonts when they are in use 
  /// and font embedding is enabled for this document using the embedTrueTypeFonts element (§17.8.3.8). 
  /// Common system fonts refer to a set of fonts which are typically always present on a machine, and are not defined by /IEC 29500.
  /// </summary>
  [DataMember]
  public bool? EmbedSystemFonts
  {
    get => _DocumentSettings?.GetBoolVal<DXW.EmbedSystemFonts>();
    set => _ExistingSettings.SetBoolVal<DXW.EmbedSystemFonts>(value);
  }

  /// <summary>
  /// This element specifies that applications shall subset fonts when font embedding is enabled 
  /// for this document using the embedTrueTypeFonts element (§17.8.3.8). 
  /// Subsetting is a mechanism by which only the glyphs used in the contents of this WordprocessingML document are stored in an embedded font, 
  /// in order to prevent the file from becoming unnecessarily large from the use of a small number of glyphs from a large embedded font.
  /// </summary>
  [DataMember]
  public bool? SaveSubsetFonts
  {
    get => _DocumentSettings?.GetBoolVal<DXW.SaveSubsetFonts>();
    set => _ExistingSettings.SetBoolVal<DXW.SaveSubsetFonts>(value);
  }

  /// <summary>
  /// This element specifies that saving the contents of this document shall only save the contents of WordprocessingML form fields 
  /// defined using the FORMTEXT, FORMCHECKBOX, and FORMDROPDOWN field codes in a comma-delimited text format
  /// which does not conform to /IEC 29500 (i.e. it is a one-way export from a WordprocessingML document).
  /// <para>
  /// [Rationale: This setting is typically used to allow duplication of paper forms in electronic WordprocessingML document form, 
  /// allowing the resulting content to be extracted as a comma-delimited text file. end rationale]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? SaveFormsData
  {
    get => _DocumentSettings?.GetBoolVal<DXW.SaveFormsData>();
    set => _ExistingSettings.SetBoolVal<DXW.SaveFormsData>(value);
  }

  /// <summary>
  /// This element specifies that the left and right margins defined in the section properties shall be swapped on facing pages.
  /// <para>
  /// [Guidance: This setting is generally used when printing on both sides of pages and binding them like a book. end guidance]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? MirrorMargins
  {
    get => _DocumentSettings?.GetBoolVal<DXW.MirrorMargins>();
    set => _ExistingSettings.SetBoolVal<DXW.MirrorMargins>(value);
  }

  /// <summary>
  /// This element specifies that paragraph borders specified using the pBdr element (§17.3.1.24) and table borders using the tblBorders element (§17.4.40) 
  /// shall be adjusted to align with extents of the page border defined using the pgBorders element (§17.6.10) 
  /// if the spacing between these borders is less than or equal to 10.5 points (one character width) or less from the page border. 
  /// The presence of this setting shall ensure there are no gaps of one character width or less between adjoining page and paragraph/table borders, 
  /// as borders which are perfectly aligning shall not be displayed in favor of the intervening page border.
  /// </summary>
  [DataMember]
  public bool? AlignBorderAndEdges
  {
    get => _DocumentSettings?.GetBoolVal<DXW.AlignBorderAndEdges>();
    set => _ExistingSettings.SetBoolVal<DXW.AlignBorderAndEdges>(value);
  }

  /// <summary>
  /// This element specifies that a given WordprocessingML document’s page border specified using the pgBorders element (§17.6.10) 
  /// should not surround contents of the header.
  /// If this element is omitted, then the page border shall not exclude the header on the page. 
  /// As well, this element shall be ignored if the pgBorders element has an offsetFrom attribute which is not equal to text.
  /// <para>
  /// [Note: If the pgBorders element has a offsetFrom attribute equal to page, the bordersDoNotSurroundHeader element is ignored 
  /// as specifying the pgBorders element with a offsetFrom attribute equal to page is to specify that the positioning of borders 
  /// within the document shall be calculated relative to the edge of the page and therefore irrespective of document content in the header. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? BordersDoNotSurroundHeader
  {
    get => _DocumentSettings?.GetBoolVal<DXW.BordersDoNotSurroundHeader>();
    set => _ExistingSettings.SetBoolVal<DXW.BordersDoNotSurroundHeader>(value);
  }

  /// <summary>
  /// This element specifies that a given WordprocessingML document’s page border specified using the pgBorders element (§17.6.10) 
  /// should not surround contents of the footer.
  /// <para>
  /// If this element is omitted, then the page border shall not exclude the footer on the page. 
  /// As well, this element shall be ignored if the pgBorders element has an offsetFrom attribute which is not equal to text.
  /// </para>
  /// [Note: If the pgBorders element has a offsetFrom attribute equal to page, the bordersDoNotSurroundFooter element is ignored
  /// as specifying the pgBorders element with a offsetFrom attribute equal to page is to specify that the positioning of borders
  /// within the document shall be calculated relative to the edge of the page and therefore irrespective of document content in the footer. end note]
  /// <para>
  /// </para>
  /// </summary>
  [DataMember]
  public bool? BordersDoNotSurroundFooter
  {
    get => _DocumentSettings?.GetBoolVal<DXW.BordersDoNotSurroundFooter>();
    set => _ExistingSettings.SetBoolVal<DXW.BordersDoNotSurroundFooter>(value);
  }

  /// <summary>
  /// This element specifies that a given WordprocessingML document’s gutter shall be positioned at the top of the document’s pages when the document is displayed. 
  /// A gutter is the white space formed by the inner margins of two pages facing one another; 
  /// such as the white space between the text on pages of a book when the book is opened.
  /// <para>
  /// If this element is omitted, then the gutter shall not be positioned at the top of the page. 
  /// If the mirrorMargins (§17.15.1.57), bookFoldPrinting (§17.15.1.11), bookFoldRevPrinting (§17.15.1.13), or printTwoOnOne (§17.15.1.64) elements 
  /// are used within a given document, the gutterAtTop element shall not be used. 
  /// Rather, the gutter shall be positioned automatically as necessary to enable the printing and page layout capabilities of these settings.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? GutterAtTop
  {
    get => _DocumentSettings?.GetBoolVal<DXW.GutterAtTop>();
    set => _ExistingSettings.SetBoolVal<DXW.GutterAtTop>(value);
  }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around run content contained in a WordprocessingML document 
  /// which has been flagged as a possible spelling error using the proofErr element (§17.13.8.1) or via the application's own spelling engine.
  /// If this element is not present in a WordprocessingML document, visual cues shall be displayed on content 
  /// contained in a WordprocessingML document which is considered to contain spelling errors.
  /// </summary>
  [DataMember]
  public bool? HideSpellingErrors
  {
    get => _DocumentSettings?.GetBoolVal<DXW.HideSpellingErrors>();
    set => _ExistingSettings.SetBoolVal<DXW.HideSpellingErrors>(value);
  }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around run content contained in a WordprocessingML document 
  /// which has been flagged as a possible grammatical error using the proofErr element (§17.13.8.1) or via the application's own grammar engine.
  /// If this element is not present in a WordprocessingML document, visual cues shall be displayed on content 
  /// contained in a WordprocessingML document which is considered to contain grammatical errors.
  /// </summary>
  [DataMember]
  public bool? HideGrammaticalErrors
  {
    get => _DocumentSettings?.GetBoolVal<DXW.HideGrammaticalErrors>();
    set => _ExistingSettings.SetBoolVal<DXW.HideGrammaticalErrors>(value);
  }

  /// <summary>
  /// This element specifies that the contents of this document can be upgraded and that the resulting document shall not have its functionality 
  /// limited to only those functions compatible with earlier word processing applications. 
  /// The only actions required as part of upgrading the document are:
  /// <list type="bullet">
  ///   <item>
  ///     The removal of this element. If an application does not know how to upgrade a document, this element should be ignored and persisted.
  ///   </item>
  ///     The removal of all Compatibility options on the document which maintain compatibility with previous word processing applications. 
  ///     The compatibility settings which simply affect a given behavior shall not be turned off.
  ///   <item>
  ///   </item>
  /// </list>
  /// <para>
  /// [Note: The remaining operations which must be performed as part of upgrading the document are application-defined and outside the scope of /IEC 29500. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? ForceUpgrade
  {
    get => _DocumentSettings?.GetTrueIfExists<DXW.ForceUpgrade>();
    set => _ExistingSettings.SetExistsIfTrue<DXW.ForceUpgrade>(value);
  }

  /// <summary>
  /// This element specifies the set of characters which shall be restricted from ending a line for runs of text 
  /// which shall be subject to custom line breaking logic using the Kinsoku element 
  /// when the contents of the document are displayed. 
  /// <para>
  /// This constraint shall only apply to text which has been flagged in the language of this rule via the Lang element 
  /// or automatic detection methods outside the scope of /IEC 29500.
  /// </para>
  /// </summary>
  [DataMember]
  public NoBreakKinsoku? NoLineBreaksAfterKinsoku
  {
    get => _DocumentSettings?.GetObject<NoBreakKinsoku, DXW.NoLineBreaksAfterKinsoku>();
    set => _ExistingSettings.SetObject<NoBreakKinsoku, DXW.NoLineBreaksAfterKinsoku>(value);

  }

  /// <summary>
  /// This element specifies the set of characters which shall be restricted from beginning a new line for runs of text 
  /// which shall be subject to custom line breaking logic using the kinsoku element (§17.3.1.16) 
  /// when the contents of the document are displayed. 
  /// <para>
  /// This constraint shall only apply to text which has been flagged in the language of this rule via the lang element (§17.3.2.20) 
  /// or automatic detection methods outside the scope of /IEC 29500.
  /// </para>
  /// </summary>
  [DataMember]
  public NoBreakKinsoku? NoLineBreaksBeforeKinsoku
  {
    get => _DocumentSettings?.GetObject<NoBreakKinsoku, DXW.NoLineBreaksBeforeKinsoku>();
    set => _ExistingSettings.SetObject<NoBreakKinsoku, DXW.NoLineBreaksBeforeKinsoku>(value);
  }

  /// <summary>
  /// This element specifies the set of document protection restrictions which have been applied to the contents of a WordprocessingML document. 
  /// These restrictions should be enforced by applications editing this document when the enforcement attribute is turned on, 
  /// and ignored (but persisted) otherwise. 
  /// <para>
  /// Document protection is a set of restrictions used to prevent unintentional changes to all or part of a WordprocessingML document. 
  /// </para>
  /// <para>
  /// [Note: This protection does not encrypt the document, and malicious applications might circumvent its use. 
  /// This protection is not intended as a security feature. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public DocumentProtection? DocumentProtection
  {
    get => _DocumentSettings?.GetObject<DocumentProtection, DXW.DocumentProtection>();
    set => _ExistingSettings.SetObject<DocumentProtection, DXW.DocumentProtection>(value);
  }

  /// <summary>
  /// This element specifies the presence of information about captions in a given WordprocessingML document. 
  /// This information is divided into two components:
  /// <list type="bullet">
  ///   <item>The child elements Caption defines the format for a single type of caption to be automatically added to the document.</item>
  ///   <item>The child element AutoCaptions defines the types of objects to which a caption format shall automatically be applied.</item>
  /// </list>
  ///  This information should be used to determine the captions which are automatically added to objects when they are inserted into a WordprocessingML document. [Note: This setting is typically ignored unless it is specified in an application's default template. end note]
  /// </summary>
  [DataMember]
  public Captions? Captions
  {
    get => _DocumentSettings?.GetObject<Captions, DXW.Captions>();
    set => _ExistingSettings.SetObject<Captions, DXW.Captions>(value);
  }

  /// <summary>
  /// This element specifies if the grammar and spell checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  [DataMember]
  public ProofState? ProofState
  {
    get => _DocumentSettings?.GetObject<ProofState, DXW.ProofState>();
    set => _ExistingSettings.SetObject<ProofState, DXW.ProofState>(value);
  }

  /// <summary>
  /// This element specifies the magnification level which should be applied to a document when it is displayed by an application. 
  /// The zoom level is specified with the use of two attributes stored on this element:
  /// <list type="bullet">
  ///   <item>val, which stores the type of zoom applied to the document</item>
  ///   <item>percent, which stores the zoom percentage to be used when rendering the document</item>
  /// </list>
  /// If both attributes are present, then the percent attribute shall be treated as a 'cached' value and only used when the value none is specified for the val attribute.
  /// </summary>
  [DataMember]
  public Zoom? Zoom
  {
    get => _DocumentSettings?.GetObject<Zoom, DXW.Zoom>();
    set => _ExistingSettings.SetObject<Zoom, DXW.Zoom>(value);
  }

  /// <summary>
  /// This element specifies if the grammar and spell checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  [DataMember]
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get => _DocumentSettings?.GetObject<StylePaneFormatFilter, DXW.StylePaneFormatFilter>();
    set => _ExistingSettings.SetObject<StylePaneFormatFilter, DXW.StylePaneFormatFilter>(value);
  }

  /// <summary>
  /// This element specifies the value which shall be used as the multiplier to generate automatic tab stops in this document. 
  /// Automatic tab stops refer to the tab stop locations which occur after all custom tab stops in the current paragraph have been surpassed.
  /// </summary>
  [DataMember]
  public Twips? DefaultTabStop
  {
    get => _DocumentSettings?.GetTwipsVal<DXW.DefaultTabStop>();
    set => _ExistingSettings.SetTwipsVal<DXW.DefaultTabStop>(value);
  }

  /// <summary>
  ///  Specifies the hyphenation zone which shall be used when automatically or manually hyphenating the contents of this document. 
  ///  The hyphenation zone is the amount of whitespace which can be left at the end of a line (or added to justified lines) 
  ///  before hyphenation should be attempted on the next word in the document (in order to reduce the amount of whitespace on the line). 
  ///  A smaller hyphenation zone should reduce the raggedness of the right edge of a given document's body text, as more words is hyphenated. 
  ///  Conversely, a larger hyphenation zone should increase the raggedness of the right edge of a given document's text, as fewer words is hyphenated.
  /// </summary>
  [DataMember]
  public Twips? HyphenationZone
  {
    get => _DocumentSettings?.GetTwipsVal<DXW.HyphenationZone>();
    set => _ExistingSettings.SetTwipsVal<DXW.HyphenationZone>(value);
  }

  /// <summary>
  /// This element specifies the sets of characters which should be compressed when the contents of this document are displayed.
  /// </summary>
  [DataMember]
  public DMW.CharacterSpacingKind? CharacterSpacingControl
  {
    get => _DocumentSettings?.GetEnumVal<DMW.CharacterSpacingKind, DXW.CharacterSpacingControl>();
    set => _ExistingSettings.SetEnumVal<DMW.CharacterSpacingKind, DXW.CharacterSpacingControl>(value);
  }

  /// <summary>
  /// This element specifies a set of optional compatibility options for the current document.
  /// </summary>
  [DataMember]
  public DMW.Compatibility? Compatibility
  {
    get => _DocumentSettings?.GetObject<DMW.Compatibility, DXW.Compatibility>();
    set => _ExistingSettings.SetObject<DMW.Compatibility, DXW.Compatibility>(value);
  }

  /// <summary>
  /// This element specifies the set of revision save ID values for the current document. 
  /// Revision save ID values refer to four digit hexadecimal values which uniquely identify an editing session in the life of the current document. 
  /// An editing session is the period of time between two subsequent save operations by an application.
  /// <para>
  /// [Guidance: The set of revision save IDs stored with a document only supplies information about the editing session 
  /// in which document components were last saved, which can be used by applications in any manner desired. end guidance]  
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.Rsids? Rsids
  {
    get => _DocumentSettings?.GetObject<DMW.Rsids, DXW.Rsids>();
    set => _ExistingSettings.SetObject<DMW.Rsids, DXW.Rsids>(value);
  }

  /// <summary>
  ///  Specifies the document-level properties for all math in the document. 
  /// </summary>
  [DataMember]
  public DMM.MathProperties? MathProperties
  {
    get => _DocumentSettings?.GetObject<DMM.MathProperties, DXM.MathProperties>();
    set => _ExistingSettings.SetObject<DMM.MathProperties, DXM.MathProperties>(value);
  }

  /// <summary>
  ///  This element specifies the language which shall be used to determine the appropriate theme fonts 
  ///  in the document's Theme part which map to the major/minor theme fonts. 
  ///  Specifically, the bidi attribute is used to determine the theme font applied to complex script text, 
  ///  the eastAsia attribute is used to determine the theme font applied to East Asian text, 
  ///  and the val attribute is used to determine the theme font applied to all other text.
  /// </summary>
  [DataMember]
  public DMW.LanguageType? ThemeFontLanguages
  {
    get => _DocumentSettings?.GetObject<DMW.LanguageType, DXW.ThemeFontLanguages>();
    set => _ExistingSettings.SetObject<DMW.LanguageType, DXW.ThemeFontLanguages>(value);
  }

  /// <summary>
  /// This element specifies the theme color, stored in the document's Theme part to which the value of this theme color shall be mapped. 
  /// This mapping enables multiple theme colors to be chained together.
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeMapping? ColorSchemeMapping
  {
    get => _DocumentSettings?.GetObject<DMW.ColorSchemeMapping, DXW.ColorSchemeMapping>();
    set => _ExistingSettings.SetObject<DMW.ColorSchemeMapping, DXW.ColorSchemeMapping>(value);
  }

  /// <summary>
  /// This element specifies the default parameters for object using the VML syntax 
  /// inserted in the body (the main document story, comments, footnotes, and endnotes) of the WordprocessingML document. 
  /// The definition and semantics of these parameters is described in the VML - Office Drawing subclause of /IEC 29500.
  /// </summary>
  [DataMember]
  public DMW.ShapeDefaultsType? ShapeDefaults
  {
    get => _DocumentSettings?.GetObject<DMW.ShapeDefaultsType, DXW.ShapeDefaults>();
    set => _ExistingSettings.SetObject<DMW.ShapeDefaultsType, DXW.ShapeDefaults>(value);
  }

  /// <summary>
  /// This element specifies the default parameters for object using the VML syntax 
  /// inserted in the header and footer of a WordprocessingML document. 
  /// The definition and semantics of these parameters is described in the VML - Office Drawing subclause of /IEC 29500.
  /// </summary>
  public DMW.ShapeDefaultsType? HeaderShapeDefaults
  {
    get => _DocumentSettings?.GetObject<DMW.ShapeDefaultsType, DXW.HeaderShapeDefaults>();
    set => _ExistingSettings.SetObject<DMW.ShapeDefaultsType, DXW.HeaderShapeDefaults>(value);
  }

  /// <summary>
  /// This element specifies the character that shall be interpreted as the radix point 
  /// when evaluating the contents of all fields in the current document.
  /// <para>
  /// [Rationale: When evaluating field instructions based on the contents of the current document, 
  /// it is necessary to know the character which must be treated as the radix point 
  /// in order to prevent changes to the calculation of the same field instructions based on the current user's locale. 
  /// This element stores the radix point which must be used to evaluate fields in the contents of this document, 
  /// irrespective of the locale of the application loading the file. end rationale]
  /// </para>
  /// </summary>
  [DataMember]
  public string? DecimalSymbol
  {
    get => _DocumentSettings?.GetStringVal<DXW.DecimalSymbol>();
    set => _ExistingSettings.SetStringVal<DXW.DecimalSymbol>(value);
  }

  /// <summary>
  /// This element specifies the character that shall be interpreted as a list item separator 
  /// when evaluating the contents of all fields in the current document.
  /// <para>
  /// [Rationale: When evaluating field instructions based on the contents of the current document, 
  /// it is necessary to know the character which must be treated as the list separator 
  /// in order to prevent changes to the calculation of the same field instructions based on the current user's locale. 
  /// This element stores the list separator which must be used to evaluate fields in the contents of this document, 
  /// irrespective of the locale of the application loading the file. end rationale]
  /// </para>
  /// </summary>
  [DataMember]
  public string? ListSeparator
  {
    get => _DocumentSettings?.GetStringVal<DXW.ListSeparator>();
    set => _ExistingSettings.SetStringVal<DXW.ListSeparator>(value);
  }

  /// <summary>
  /// LongHexNumber element that specifies an arbitrary identifier for the context of the paragraph identifiers in the document. 
  /// Values MUST be greater than 0 and less than 0x80000000.
  /// </summary>
  [DataMember]
  public HexInt? DocumentId
  {
    get => _DocumentSettings?.GetHexIntVal<DXW10.DocumentId>();
    set => _ExistingSettings.SetHexIntVal<DXW10.DocumentId>(value);
  }

  /// <summary>
  /// This element specifies a unique identifier for a set of documents derived from a common source. 
  /// The possible values for this attribute are defined by Guid simple type. 
  /// </summary>
  [DataMember]
  public Guid? PersistentDocumentId
  {
    get => _DocumentSettings?.GetGuidVal<DXW13.PersistentDocumentId>();
    set => _ExistingSettings.SetGuidVal<DXW13.PersistentDocumentId>(value);
  }

  /// <summary>
  /// This element specifies the resolution in dots per inch (DPI) at which images in the document will be saved. 
  /// This setting is ignored by images that have dots per inch (DPI) specified by UseLocalDpi. 
  /// This setting is also ignored when DoNotAutoCompressPictures is set to "true".
  /// </summary>
  [DataMember]
  public int? DefaultImageDpi
  {
    get => _DocumentSettings?.GetIntVal<DXW10.DefaultImageDpi>();
    set => _ExistingSettings.SetIntVal<DXW10.DefaultImageDpi>(value);
  }

  /// <summary>
  /// Element that specifies that when true, the cropped-out areas of the images are not to be saved. 
  /// Rather, the images saved are the results of applying ImgProps on the original images. 
  /// If this element is absent or if it has a value of "false", the cropped-out areas of images are saved.
  /// </summary>
  [DataMember]
  public bool? DiscardImageEditingData
  {
    get => _DocumentSettings?.GetBoolVal<DXW10.DiscardImageEditingData>();
    set => _ExistingSettings.SetBoolVal<DXW10.DiscardImageEditingData>(value);
  }

  /// <summary>
  /// Element that, when true, specifies that the user was resolving conflicting edits when the document was saved. 
  /// </summary>
  [DataMember]
  public bool? ConflictMode
  {
    get => _DocumentSettings?.GetBoolVal<DXW10.ConflictMode>();
    set => _ExistingSettings.SetBoolVal<DXW10.ConflictMode>(value);
  }

  /// <summary>
  /// Element that specifies how the datapoint properties and datalabels 
  /// in all charts in this document behave.
  /// <list type="bullet">
  ///   <item>
  ///     True - Datapoint properties and datalabels ( [MS-ODRAWXML] section 2.2.1.2) in all charts ([ISO/IEC-29500-1] section 21.2) 
  ///     in this document follow their reference.
  ///   </item>
  ///   <item>
  ///     False -Datapoint properties and datalabels ([MS-ODRAWXML] section 2.2.1.2) in all charts ([ISO/IEC-29500-1] section 21.2) 
  ///     in this document follow their position in the chart.
  ///   </item>
  /// </list>
  /// </summary>
  [DataMember]
  public bool? ChartTrackingRefBased
  {
    get => _DocumentSettings?.GetBoolVal<DXW13.ChartTrackingRefBased>();
    set => _ExistingSettings.SetBoolVal<DXW13.ChartTrackingRefBased>(value);
  }

  /// <summary>
  /// This element specifies that applications shall track revisions made to the WordprocessingML document. 
  /// Revisions are changes to a WordprocessingML document which are recorded such that they can be viewed independently, 
  /// accepted or removed, and reverted if needed. When revisions are tracked, 
  /// the resulting WordprocessingML markup in the Revisions subclause of this document describes the necessary syntax.
  /// </summary>
  [DataMember]
  public bool? TrackRevisions
  {
    get => _DocumentSettings?.GetBoolVal<DXW.TrackRevisions>();
    set => _ExistingSettings.SetBoolVal<DXW.TrackRevisions>(value);
  }

  /// <summary>
  /// This element specifies that applications shall not track revisions made to this WordprocessingML document as moves 
  /// when the TrackRevisions is turned on, even when that syntax is appropriate. 
  /// Instead, applications should use a standard insertion and deletion annotation syntax. 
  /// Existing moves shall not be modified. 
  /// <para>
  /// [Rationale: This element is provided to enable interoperability with earlier word processing applications 
  /// which do not understand moves. end rationale]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotTrackMoves
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotTrackMoves>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotTrackMoves>(value);
  }

  /// <summary>
  /// This element specifies that applications shall not track revisions made to the formatting of this WordprocessingML document 
  /// when the TrackRevisions is turned on.
  /// </summary>
  [DataMember]
  public bool? DoNotTrackFormatting
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotTrackFormatting>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotTrackFormatting>(value);
  }

  /// <summary>
  /// This element specifies whether formatting automatically applied by an application (i.e. not explicitly applied by a use or an application) 
  /// shall be allowed to override formatting protection enabled via the formatting attribute on the documentProtection element 
  /// when those formatting operations would add formatting which has been explicitly disabled. 
  /// <para>
  /// [Example: Automatically adding superscript to the st in the string 1st. end example]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? AutoFormatOverride
  {
    get => _DocumentSettings?.GetBoolVal<DXW.AutoFormatOverride>();
    set => _ExistingSettings.SetBoolVal<DXW.AutoFormatOverride>(value);
  }

  /// <summary>
  /// This element specifies whether the content of a given WordprocessingML document should automatically be hyphenated 
  /// by the hosting application before it is displayed, if the application supports this functionality.
  /// </summary>
  [DataMember]
  public bool? AutoHyphenation
  {
    get => _DocumentSettings?.GetBoolVal<DXW.AutoHyphenation>();
    set => _ExistingSettings.SetBoolVal<DXW.AutoHyphenation>(value);
  }

  /// <summary>
  /// This element specifies whether or not words comprised of all capital letters shall be hyphenated within a given document 
  /// when automatic hyphenation is specified via the autoHyphenation element.
  /// <para>
  /// If this element is omitted, then words in CAPITAL LETTERS shall be hyphenated when the document is hyphenated.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotHyphenateCaps
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotHyphenateCaps>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotHyphenateCaps>(value);
  }

  /// <summary>
  /// This element specifies that an e-mail message header shall be displayed when this document is opened, 
  /// if an e-mail header is supported by the application opening the file.
  /// <para>
  /// If this element is omitted, then applications shall not display the e-mail message header automatically when this file is opened, 
  /// even if one is available in the application opening the file.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? ShowEnvelope
  {
    get => _DocumentSettings?.GetBoolVal<DXW.ShowEnvelope>();
    set => _ExistingSettings.SetBoolVal<DXW.ShowEnvelope>(value);
  }

  /// <summary>
  /// This element specifies whether sections in this document shall have different headers and footers for even and odd pages 
  /// (an odd page header/footer and an even page header/footer).
  /// <para>
  /// If it is set to true, then each section in the document shall use an odd page header for all odd numbered pages in the section, 
  /// and an even page header for all even numbered pages in the section (counting each page in the section starting from one, 
  /// regardless of the page numbering settings for the section). If it is set to false, then all pages in a section shall use the odd page header.
  /// </para>
  /// <para>
  /// This setting does not affect the presence of a first page header on each section, which is specified using the TitlePg element. 
  /// If a first page header is specified, then all subsequent pages shall have this setting applied, 
  /// including the first page in the odd/even page count.
  /// </para>
  /// <para>
  /// If it is set to false and an even page header is specified, 
  /// then it shall be ignored and only the odd page header shall be displayed. 
  /// Conversely, if this element is set to true and either header type is omitted for a given section, 
  /// then a blank header shall be created as needed (another header type shall not be used in its place).
  /// </para>
  /// </summary>
  [DataMember]
  public bool? EvenAndOddHeaders
  {
    get => _DocumentSettings?.GetBoolVal<DXW.EvenAndOddHeaders>();
    set => _ExistingSettings.SetBoolVal<DXW.EvenAndOddHeaders>(value);
  }

  /// <summary>
  /// This element specifies if pages of a given WordprocessingML document are to be printed as signatures in reverse order. 
  /// Signatures are printed sheets, which depict several pages of a document that are folded and bound with other signatures to form a booklet, 
  /// a set of which can be bound together to form a book like publication. 
  /// Specifically, this element specifies that each page in a given WordprocessingML document should be oriented in a landscape fashion 
  /// and divided in half vertically, with two left margins emanating from the bisector of the page, 
  /// and right margins instantiated at the left and right side of each page.
  /// <para>
  /// In addition, this element is used in conjunction with the bookFoldPrintingSheets element to enable given WordprocessingML document 
  /// to be printed such that the series of signatures printed can be folded and bound to create a booklet.
  /// </para>
  /// <para>
  /// This element has no impact on the settings of printer leveraged by the hosting application. 
  /// In other words, if the printer leveraged by the hosting application has been configured to print on one side of a page, 
  /// including the WordprocessingML for this element has no effect.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? BookFoldReversePrinting
  {
    get => _DocumentSettings?.GetBoolVal<DXW.BookFoldReversePrinting>();
    set => _ExistingSettings.SetBoolVal<DXW.BookFoldReversePrinting>(value);
  }

  /// <summary>
  /// This element specifies if the contents of a given WordprocessingML document should be printed as signatures. 
  /// Signatures are printed sheets, which depict several pages of a document that are folded 
  /// and bound with other signatures to form a booklet, a set of which can be bound together to form a book like publication. 
  /// Specifically, this element specifies that each page in a given WordprocessingML document should be oriented in a landscape fashion, 
  /// divided in half vertically with two left margins emanating from the bisector of the page, 
  /// and two right margins instantiated at the left and right side of each page.
  /// <para>
  /// This element is used in conjunction with the bookFoldPrintingSheets element to enable a WordprocessingML document 
  /// to be printed such that the series of signatures printed can be folded and bound to create a booklet.
  /// </para>
  /// <para>
  /// This element has no impact on the settings of printer leveraged by the hosting application. 
  /// In other words, if the printer leveraged by the hosting application has been configured to print on one side of a page, 
  /// including the WordprocessingML for this element has no effect.
  /// </para>
  /// <para>
  /// If this element is omitted, then pages shall not be printed as signatures. 
  /// If the BookFoldRevPrinting element is also specified, then this element shall be ignored.
  /// </summary>
  [DataMember]
  public bool? BookFoldPrinting
  {
    get => _DocumentSettings?.GetBoolVal<DXW.BookFoldPrinting>();
    set => _ExistingSettings.SetBoolVal<DXW.BookFoldPrinting>(value);
  }

  /// <summary>
  /// This element specifies that the top-left corner of the page shall not be used as the origin for the drawing grid. 
  /// The drawing grid is a virtual grid which can be used by applications to specify 
  /// where drawing objects shall be positioned on a page when inserted (i.e. to ensure objects are aligned, etc.). 
  /// If this element is present the grid shall start at the top-left edge of the page and not the text extents.
  /// <para>
  /// If this element is omitted, then the gridlines shall start at the topmost edge of the text extents.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotUseMarginsForDrawingGridOrigin
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotUseMarginsForDrawingGridOrigin>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotUseMarginsForDrawingGridOrigin>(value);
  }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around form fields contained in a WordprocessingML document 
  /// specified via the FORMTEXT, FORMCHECKBOX, or FORMDROPDOWN fields.
  /// <para>
  /// If this element is not present in a WordprocessingML document visual cues should be displayed on form fields contained in the document.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotShadeFormData
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotShadeFormData>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotShadeFormData>(value);
  }

  /// <summary>
  /// This element specifies that punctuation characters shall not be kerned in the current document when kerning is enabled on a run using the kern element (§17.3.2.19). Kerning refers to a process by which a hosting application shall reduce the spacing of adjacent characters and/or punctuation to improve the visual appearance of text. Well kerned text has a similar amount of blank space between each pair of characters and/or each set of a character and punctuation symbol. When kerning is enabled, Latin text shall always be kerned, and this option shall control whether punctuation characters are also kerned.
  /// <para>
  /// If this element is omitted, then punctuation characters shall be kerned when kerning is enabled on a given run.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? NoPunctuationKerning
  {
    get => _DocumentSettings?.GetBoolVal<DXW.NoPunctuationKerning>();
    set => _ExistingSettings.SetBoolVal<DXW.NoPunctuationKerning>(value);
  }

  /// <summary>
  /// This element specifies whether two pages should be printed on one sheet of paper when this document is printed. 
  /// Specifically, this element specifies that each page displayed for the contents in a given WordprocessingML document 
  /// should be the page size specified in the section settings divided in half with two top margins originating from the bisector of the page, 
  /// and bottom margins instantiated at the top and bottom of each page.
  /// <para>
  /// If this element is omitted, then pages should be displayed and printed as one per sheet.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? PrintTwoOnOne
  {
    get => _DocumentSettings?.GetBoolVal<DXW.PrintTwoOnOne>();
    set => _ExistingSettings.SetBoolVal<DXW.PrintTwoOnOne>(value);
  }

  /// <summary>
  /// This element specifies that the strict set of Kinsoku rules shall be applied to Japanese text in this document 
  /// when the Kinsoku element is applied to that text. The resulting line breaking rules are provided on the kinsoku element.
  /// <para>
  /// If this element is omitted, then standard rules shall apply to Japanese text when the kinsoku element is applied to that text.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? StrictFirstAndLastChars
  {
    get => _DocumentSettings?.GetBoolVal<DXW.StrictFirstAndLastChars>();
    set => _ExistingSettings.SetBoolVal<DXW.StrictFirstAndLastChars>(value);
  }

  /// <summary>
  /// This element specifies if a document's Thumbnail part should be generated for the contents of the first page 
  /// of this document when saved by application which support document thumbnail generation.
  /// <para>
  /// If this element is omitted, then applications can choose to save a thumbnail, however, that behavior is not required. 
  /// If this element is specified, a thumbnail shall be produced if that functionality is supported.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? SavePreviewPicture
  {
    get => _DocumentSettings?.GetBoolVal<DXW.SavePreviewPicture>();
    set => _ExistingSettings.SetBoolVal<DXW.SavePreviewPicture>(value);
  }

  /// <summary>
  /// This element specifies that applications shall not validate the custom XML markup in this document 
  /// against the applicable custom XML schema(s), even when those schemas are available. 
  /// The application should silently behave as if it was unable to provide this functionality.
  /// <para>
  /// If this element is omitted, then applications which support this functionality should attempt 
  /// to validate the custom XML contents against any available related custom XML schema(s).
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotValidateAgainstSchema
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotValidateAgainstSchema>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotValidateAgainstSchema>(value);
  }

  /// <summary>
  /// This element specifies that this document should be capable of being saved into a format 
  /// consisting of a single XML file (not defined by /IEC 29500) when its contents are invalid based XML schema validation 
  /// of the custom XML markup contained in the document. This setting has no effect on documents that do not contain custom XML markup, 
  /// or that do contain custom XML markup but do not have a schema attached. 
  /// <para>
  /// [Guidance: Because this setting specifies behavior when saving to an alternative file format not defined by /IEC 29500, 
  /// this behavior is optional. end guidance]
  /// </para>
  /// <para>
  /// If this element is omitted, then applications should not allow this document to be saved into a single XML file 
  /// when its contents are invalid based on the custom XML markup contained in the document. 
  /// If the doNotValidateAgainstSchema element is set, then the XML is never "invalid" and this property is ignored.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? SaveInvalidXml
  {
    get => _DocumentSettings?.GetBoolVal<DXW.SaveInvalidXml>();
    set => _ExistingSettings.SetBoolVal<DXW.SaveInvalidXml>(value);
  }

  /// <summary>
  /// This element specifies that applications should ignore all text content which is not contained 
  /// within a leaf custom XML markup element when validating the contents of the custom XML markup in this document 
  /// against one or more attached custom XML schema(s). A leaf element is a custom XML element which has no child custom XML elements 
  /// (it is a leaf in the custom XML tree).
  /// <para>
  /// If this element is omitted, then text content in leaf elements shall not be ignored 
  /// when validating the custom XML markup against one or more custom XML schema(s).
  /// </para>
  /// </summary>
  [DataMember]
  public bool? IgnoreMixedContent
  {
    get => _DocumentSettings?.GetBoolVal<DXW.IgnoreMixedContent>();
    set => _ExistingSettings.SetBoolVal<DXW.IgnoreMixedContent>(value);
  }

  /// <summary>
  /// This element specifies that each custom XML element specified using the customXml element within this document 
  /// shall always show some form of in-document placeholder text presentation when it contains no run content. 
  /// If the Placeholder element is present in the custom XML element's properties, 
  /// then this is the placeholder text displayed and this effect has no effect. 
  /// If the Placeholder element is omitted, then the application shall use the name of the element 
  /// to generate default placeholder text in its place.
  /// <para>
  /// If this element is omitted, then custom XML markup which does not contain a placeholder element 
  /// within its properties shall not display any placeholder text.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? AlwaysShowPlaceholderText
  {
    get => _DocumentSettings?.GetBoolVal<DXW.AlwaysShowPlaceholderText>();
    set => _ExistingSettings.SetBoolVal<DXW.AlwaysShowPlaceholderText>(value);
  }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around content contained in a WordprocessingML document 
  /// which is contained with custom XML markup specified via the customXml element when an application determines 
  /// that the current XML markup (or its contents) violate the constraints of the attached XML schema(s).
  /// <para>
  /// If this element is not present in a WordprocessingML document visual cues shall be displayed 
  /// on content contained in custom XML markup in a WordprocessingML document which 
  /// is considered to be invalid based on the associated XML schema(s).
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotDemarcateInvalidXml
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotDemarcateInvalidXml>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotDemarcateInvalidXml>(value);
  }

  /// <summary>
  /// This element specifies that the contents of this document shall be saved as an XML file containing only the custom XML markup 
  /// in this document in its regular form. The resulting document does not conform to /IEC 29500 
  /// (i.e. this is an export-only save option for a WordprocessingML document).
  /// <para>
  /// [Rationale: This setting is typically used to extract custom XML markup from a WordprocessingML document 
  /// for further processing by XML-enabled applications. end rationale]
  /// </para>
  /// <para>
  /// If this element is omitted, then the contents of the entire document (not just custom XML markup) 
  /// should be saved according to the definition of WordprocessingML in /IEC 29500.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? SaveXmlDataOnly
  {
    get => _DocumentSettings?.GetBoolVal<DXW.SaveXmlDataOnly>();
    set => _ExistingSettings.SetBoolVal<DXW.SaveXmlDataOnly>(value);
  }

  /// <summary>
  /// This element specifies that this document should be saved through the custom XSLT transform defined by the saveThroughXslt element 
  /// in this document when it is saved as a single XML file (not defined by /IEC 29500). 
  /// <para>
  /// [Guidance: Because this setting specifies behavior when saving to an alternative file format not defined by /IEC 29500, 
  /// this behavior is optional. end guidance]
  /// </para>
  /// <para>
  /// If the saveXmlDataOnly element (§17.15.1.77) is specified, then the single XML file to be transformed 
  /// is the custom XML markup of the document, otherwise, it a format outside the scope of /IEC 29500. 
  /// If the XSL transform specified by the saveThroughXslt element is not present, then this setting should be ignored.
  /// </para>
  /// <para>
  /// If this element is omitted, then this document should not be saved through a custom XSL transform when it is saved as a single XML file.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? UseXsltWhenSaving
  {
    get => _DocumentSettings?.GetBoolVal<DXW.UseXsltWhenSaving>();
    set => _ExistingSettings.SetBoolVal<DXW.UseXsltWhenSaving>(value);
  }

  /// <summary>
  /// This element specifies that some visual indicator shall be provided for the start and end locations 
  /// of custom XML markup present in this document, if any.
  /// <para>
  /// If this element is omitted, then applications should not provide any visual indicator of the locations 
  /// of custom XML markup start/end tags.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? ShowXmlTags
  {
    get => _DocumentSettings?.GetBoolVal<DXW.ShowXmlTags>();
    set => _ExistingSettings.SetBoolVal<DXW.ShowXmlTags>(value);
  }

  /// <summary>
  /// This element specifies whether custom XML markup specified via the customXml element which has no associated namespace 
  /// shall be treated as an error and moved into a special error namespace (for the purposes of XML schema validation) 
  /// when the document is opened. If this element is turned on, when an application determines that the current XML markup 
  /// is in the empty namespace, those elements shall not automatically be moved into an error namespace.
  /// <para>
  /// If this element is not present in a WordprocessingML document than custom XML markup which has no associated namespace 
  /// shall be treated as an error and moved into a special error namespace when the document is opened.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? AlwaysMergeEmptyNamespace
  {
    get => _DocumentSettings?.GetBoolVal<DXW.AlwaysMergeEmptyNamespace>();
    set => _ExistingSettings.SetBoolVal<DXW.AlwaysMergeEmptyNamespace>(value);
  }

  /// <summary>
  /// This element specifies whether the fields contained in this document should automatically have their field result recalculated 
  /// from the field codes when this document is opened by an application which supports field calculations. 
  /// <para>
  /// [Note: Some fields are always recalculated (e.g. the page numbering), 
  /// therefore this element only affects fields which are typically not automatically recalculated on opening the document. 
  /// Also note that this setting must not supersede any document Protection or WriteProtection settings. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? UpdateFieldsOnOpen
  {
    get => _DocumentSettings?.GetBoolVal<DXW.UpdateFieldsOnOpen>();
    set => _ExistingSettings.SetBoolVal<DXW.UpdateFieldsOnOpen>(value);
  }

  /// <summary>
  /// Disable Features Incompatible With Earlier Word Processing Formats. 
  /// </summary>
  [DataMember]
  public bool? UICompatibleWith97To2003
  {
    get => _DocumentSettings?.GetBoolVal<DXW.UICompatibleWith97To2003>();
    set => _ExistingSettings.SetBoolVal<DXW.UICompatibleWith97To2003>(value);
  }

  /// <summary>
  /// This element specifies if document content contained in text boxes, footnotes, and endnotes 
  /// shall be excluded when an application calculates a given document’s statistics 
  /// when these values are calculated and/or displayed by an application.
  /// <para>
  /// [Note: Some examples of document statistics that an application might chose to calculate are: 
  /// number of words, number of characters, number of paragraphs, number of pages, number of lines, and so on. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotIncludeSubdocsInStats
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotIncludeSubdocsInStats>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotIncludeSubdocsInStats>(value);
  }

  /// <summary>
  /// This element specifies that pictures in this document shall not automatically be compressed when saving the document
  /// in order to reduce the overall size of the resulting WordprocessingML document.
  /// <para>
  /// If this element is omitted, applications can perform basic compression on images before saving the contents of the document.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? DoNotAutoCompressPictures
  {
    get => _DocumentSettings?.GetBoolVal<DXW.DoNotAutoCompressPictures>();
    set => _ExistingSettings.SetBoolVal<DXW.DoNotAutoCompressPictures>(value);
  }

  /// <summary>
  /// This element specifies the exact set of page and text sizing parameters 
  /// which shall be used to display the contents of a WordprocessingML document. 
  /// <para>
  /// [Rationale: This setting is typically used for documents that have been annotated using ink. 
  /// This setting freezes the document's presentation such that the ink annotations 
  /// must exist at the same position of the WordprocessingML document irrespective of the monitor 
  /// on which the WordprocessingML document is rendered. end rationale]
  /// </para>
  /// <para>
  /// This element shall only affect the display of WordprocessingML documents as follows:
  /// </para>
  /// <list type="bullet">
  ///   <item>
  ///     When the actualPage attribute is specified with a value of true, 
  ///     the given WordprocessingML document's pages shall be rendered as they would normally be displayed. 
  ///     The resulting pages can have their magnification setting changed as desired. 
  ///     All other attributes shall be ignored.
  ///   </item>
  ///   <item>
  ///     When the actualPage attribute is specified with a value of false, 
  ///     the given WordprocessingML document's pages shall be rendered as virtual pages 
  ///     when loaded by a conforming hosting application irrespective of the given WordprocessingML document's view. 
  ///     Virtual pages are pages with no correlation with the printed layout of a given WordprocessingML document 
  ///     that have been scaled by a conforming hosting application to improve the readability 
  ///     of a given WordprocessingML document when it is displayed. 
  ///     Specifically, the w and h attributes specify the width and height of the virtual pages, 
  ///     and the fontSz attribute specifies the scaling to be applied to text within the given WordprocessingML document.
  ///   </item>
  /// </list>
  /// </summary>
  [DataMember]
  public bool? ReadModeInkLockDown
  {
    get => _DocumentSettings?.GetBoolVal<DXW.ReadModeInkLockDown>();
    set => _ExistingSettings.SetBoolVal<DXW.ReadModeInkLockDown>(value);
  }

  /// <summary>
  /// This element specifies the set of XML namespaces which have been associated 
  /// with the contents of the custom XML markup within the current Office Open XML document. 
  /// Each unique namespace which is referenced within the document can be referenced within this element 
  /// by a single schema element, regardless of the number of constituent XML schemas which comprise that namespace.
  /// </summary>
  [DataMember]
  public DMW.SchemaLibrary? SchemaLibrary
  {
    get => _DocumentSettings?.GetObject<DMW.SchemaLibrary, DXCXSR.SchemaLibrary>();
    set => _ExistingSettings.SetObject<DMW.SchemaLibrary, DXCXSR.SchemaLibrary>(value);
  }

  /// <summary>
  /// This element specifies the classification of a given WordprocessingML document.
  /// <para>
  /// [Note: This element can be used by hosting applications to facilitate customized user interface and/or automatic formatting behaviors based on the 'type' of a given WordprocessingML document. end note]
  /// If this element is omitted, then the document shall be classified as a general document.
  /// </para>
  /// </summary>
  [DataMember]
  public DMW.DocumentKind? DocumentType
  {
    get => _DocumentSettings?.GetEnumVal<DMW.DocumentKind, DXW.DocumentType>();
    set => _ExistingSettings.SetEnumVal<DMW.DocumentKind, DXW.DocumentType>(value);
  }

  /// <summary>
  /// This element specifies the presence of documentvariables in a WordprocessingML. 
  /// A document variable is a storage location for arbitrary customer data in name/value pairs 
  /// that is persisted in a given WordprocessingML document.
  /// <para>
  /// [Note: This mechanism is maintained for legacy compatibility only, 
  /// and should be avoided in favor of the custom XML data support defined in /IEC 29500. end note]
  /// </para>
  /// </summary>
  [Obsolete]
  [DataMember]
  public DMW.DocumentVariables? DocumentVariables
  {
    get => _DocumentSettings?.GetObject<DMW.DocumentVariables, DXW.DocumentVariables>();
    set => _ExistingSettings.SetObject<DMW.DocumentVariables, DXW.DocumentVariables>(value);
  }

  /// <summary>
  /// This element specifies the endnote properties for the current document. 
  /// These properties can be overridden for a specific section via the section-wide EndnotePr element.
  /// </summary>
  [DataMember]
  public DMW.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get => _DocumentSettings?.GetObject<DMW.EndnoteDocumentWideProperties, DXW.EndnoteDocumentWideProperties>();
    set => _ExistingSettings.SetObject<DMW.EndnoteDocumentWideProperties, DXW.EndnoteDocumentWideProperties>(value);
  }

  /// <summary>
  /// This element specifies the footnote properties for the current document. 
  /// These properties can be overridden for a specific section via the section-wide FootnotePr element.
  /// </summary>
  [DataMember]
  public DMW.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get => _DocumentSettings?.GetObject<DMW.FootnoteDocumentWideProperties, DXW.FootnoteDocumentWideProperties>();
    set => _ExistingSettings.SetObject<DMW.FootnoteDocumentWideProperties, DXW.FootnoteDocumentWideProperties>(value);
  }

  /// <summary>
  /// This element specifies all of the mail merge information for a document that has been connected 
  /// to an external data source as part of a mail merge operation.
  /// </summary>
  [DataMember]
  public DMW.MailMerge? MailMerge
  {
    get => _DocumentSettings?.GetObject<DMW.MailMerge, DXW.MailMerge>();
    set => _ExistingSettings.SetObject<DMW.MailMerge, DXW.MailMerge>(value);
  }

  /// <summary>
  /// This element shall be used in conjunction with the bookFoldPrinting and bookFoldRevPrinting elements 
  /// to specify the number of pages to be included in each booklet when printing a series of signatures. 
  /// Signatures are printed sheets, which depict several pages of a document that are to be folded 
  /// and bound with other signatures to form a booklet. Booklets can be bound together to form a book like publication.
  /// <para>
  ///   If this element is omitted, then its default behavior shall be to print the contents of the content on a single sheet. 
  ///   A sheet is a single piece of paper which is folded and cut to produce a book.
  /// </para>
  /// </summary>
  [DataMember]
  public int? BookFoldPrintingSheets
  {
    get => _DocumentSettings?.GetIntVal<DXW.BookFoldPrintingSheets>();
    set => _ExistingSettings.SetIntVal<DXW.BookFoldPrintingSheets>(value);
  }

  /// <summary>
  /// This element specifies that the document was last saved while the placeholder text of all structured document tags 
  /// in this document were being edited. This means that the placeholder text currently displayed 
  /// in all structured document tags which are displaying the showingPlcHdr element 
  /// shall be committed to the corresponding glossary document entry as specified using the docPart element 
  /// when this document is opened, in order to ensure that the most recent placeholder text is stored in the glossary document entry. 
  /// If the current placeholder text cannot be saved as a glossary document entry, then it should be modified as needed before saving.
  /// <para>
  //  If this element is omitted, then the placeholder text in this document should not automatically be resaved when the document is opened.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? FormsDesign
  {
    get => _DocumentSettings?.GetBoolVal<DXW.FormsDesign>();
    set => _ExistingSettings.SetBoolVal<DXW.FormsDesign>(value);
  }

  /// <summary>
  /// This element specifies that styles in the given document shall be updated to match the styles in the attached template 
  /// specified using the AttachedTemplate element when the document is opened by a hosting application. 
  /// This setting enables the styles contained in documents with attached templates to stay synchronized with the styles 
  /// used in the attached template.
  /// <para>
  /// If this element is omitted, then styles shall not be updated based on the document template regardless of its availability. 
  /// f the attached template cannot be located or is not a valid file, then this setting should be silently ignored.
  /// </para>
  /// </summary>
  [DataMember]
  public bool? LinkStyles
  {
    get => _DocumentSettings?.GetBoolVal<DXW.LinkStyles>();
    set => _ExistingSettings.SetBoolVal<DXW.LinkStyles>(value);
  }

  /// <summary>
  /// This element specifies whether applications shall prevent the modification of the document's theme information
  /// stored in the Theme part when editing this document. This setting should not preclude the use of the theme information, 
  /// instead, it should only prevent the modification of the theme part in a single operation 
  /// (either through a user interface or a programmatic operation).
  /// </summary>
  [DataMember]
  public bool? StyleLockThemesPart
  {
    get => _DocumentSettings?.GetBoolVal<DXW.StyleLockThemesPart>();
    set => _ExistingSettings.SetBoolVal<DXW.StyleLockThemesPart>(value);
  }

  /// <summary>
  /// This element specifies whether applications shall prevent the replacement of the complete set of styles 
  /// stored in the Styles part when editing this document. This setting should not preclude the editing or removal of individual styles, 
  /// instead, it should only prevent the removal and replacement of the entire styles part in a single operation 
  /// (either through a user interface or a programmatic operation).
  /// </summary>
  [DataMember]
  public bool? StyleLockStylesPart
  {
    get => _DocumentSettings?.GetBoolVal<DXW.StyleLockStylesPart>();
    set => _ExistingSettings.SetBoolVal<DXW.StyleLockStylesPart>(value);
  }

  /// <summary>
  /// This element specifies the location of a document template which shall be attached to the current WordprocessingML document 
  /// if it is accessible and of a format supported by an application. Specifically, this element 
  /// shall contain the file path of the associated document template.
  /// <para>
  /// If this element is omitted, then the document shall not have an attached document template, 
  /// and applications should use their default template in its place.
  /// </para>
  /// </summary>
  [DataMember]
  public Reference? AttachedTemplate
  {
    get => _DocumentSettings?.GetRefId<DXW.AttachedTemplate>();
    set => _ExistingSettings.SetRefId<DXW.AttachedTemplate>(value);
  }

  /// <summary>
  /// This element specifies whether applications shall prevent the replacement of the complete set of styles 
  /// stored in the Styles part when editing this document. This setting should not preclude the editing or removal of individual styles, 
  /// instead, it should only prevent the removal and replacement of the entire styles part in a single operation 
  /// (either through a user interface or a programmatic operation).
  /// </summary>
  [DataMember]
  public SaveThroughXslt? SaveThroughXslt
  {
    get => _DocumentSettings?.GetObject<DMW.SaveThroughXslt, DXW.SaveThroughXslt>();
    set => _ExistingSettings.SetObject<DMW.SaveThroughXslt, DXW.SaveThroughXslt>(value);
  }

  /// <summary>
  /// This element specifies that the custom XML schema whose target namespace matches the specified value 
  /// should be associated with this document when it is loaded, if such a schema is available to the hosting application. 
  /// Applications can also load and utilize any additional schemas as well as those explicitly mentioned here. 
  /// <para>
  /// [Note: These custom XML schemas can then be used to validate the structure of the custom XML markup in the document, etc. end note]
  /// </para>
  /// </summary>
  [DataMember]
  public string? AttachedSchema
  {
    get => _DocumentSettings?.GetStringVal<DXW.SaveThroughXslt>();
    set => _ExistingSettings.SetStringVal<DXW.SaveThroughXslt>(value);
  }

  /// <summary>
  /// This element specifies the paragraph style, specified using the style element, which shall be applied to paragraphs 
  /// which are automatically created when text is inserted into a WordprocessingML document in an area of the document 
  /// that has no other style associated with it. This style is referenced via the val attribute, 
  /// which stores the style ID of the style (stored in the styleId attribute on the style definition).
  /// <para>
  /// [Guidance: Consider a WordprocessingML document opened in an application that allows users to place their cursor 
  /// anywhere within the document editing canvas and enter text. The clickAndTypeStyle element should be used 
  /// to specify the paragraph style to be associated with the paragraph of text entered after a user places 
  /// their cursor somewhere in the blank document that results in the generation of new paragraphs. end guidance]
  /// </para>
  /// <para>
  /// If this element is omitted, then the default paragraph style (the paragraph style whose default attribute is set to true), 
  /// shall be used for automatically generated paragraphs. If the style whose styleId is specified using the value 
  /// is not a paragraph style or does not exist in the document, then the default paragraph style shall be used instead.
  /// </para>
  /// </summary>
  [DataMember]
  public string? ClickAndTypeStyle
  {
    get => _DocumentSettings?.GetStringVal<DXW.ClickAndTypeStyle>();
    set => _ExistingSettings.SetStringVal<DXW.ClickAndTypeStyle>(value);
  }

  /// <summary>
  /// This element specifies the table style which shall automatically be applied to the table properties of tables 
  /// added to this document by an application. Note that it does not change the table style applied to tables 
  /// which do not reference a style, instead, it automatically applies the style to that table via the tblStyle element. 
  /// This link is made by referencing the styleId attribute value of the table style which shall be used to format newly inserted tables.
  /// <para>
  /// If this element is omitted, then no table style shall automatically be applied to inserted tables 
  /// (therefore inheriting the default table style). If the referenced style is not present or not a table style, 
  /// then no table style shall automatically be applied to inserted tables.
  /// </para>
  /// </summary>
  [DataMember]
  public string? DefaultTableStyle
  {
    get => _DocumentSettings?.GetStringVal<DXW.DefaultTableStyle>();
    set => _ExistingSettings.SetStringVal<DXW.DefaultTableStyle>(value);
  }

  /// <summary>
  /// This element specifies a sorting which should be applied to the list of styles in this document 
  /// if the styles are displayed in a user interface.
  /// </summary>
  [DataMember]
  public string? StylePaneSortMethods
  {
    get => _DocumentSettings?.GetStringVal<DXW.StylePaneSortMethods>();
    set => _ExistingSettings.SetStringVal<DXW.StylePaneSortMethods>(value);
  }

  /// <summary>
  /// This element specifies which forms of annotations shall be visible for a WordprocessingML document when it is displayed. 
  /// This setting shall not affect whether annotations are added or persisted, 
  /// it shall only affect the display of the annotations which exist in the document's contents (persisted or in memory).
  /// </summary>
  [DataMember]
  public RevisionView? RevisionView
  {
    get => _DocumentSettings?.GetObject<DMW.RevisionView, DXW.RevisionView>();
    set => _ExistingSettings.SetObject<DMW.RevisionView, DXW.RevisionView>(value);
  }

  /// <summary>
  /// This element specifies the width of horizontal grid units in this document. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document.
  /// <para>
  /// If this element is omitted, then each horizontal grid unit shall be 180 twentieths of a point (0.125") in width.
  /// </para>
  /// </summary>
  [DataMember]
  public Twips? DrawingGridHorizontalSpacing
  {
    get => _DocumentSettings?.GetTwipsVal<DXW.DrawingGridHorizontalSpacing>();
    set => _ExistingSettings.SetTwipsVal<DXW.DrawingGridHorizontalSpacing>(value);
  }

  /// <summary>
  /// This element specifies the width of vertical grid units in this document. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document.
  /// <para>
  /// If this element is omitted, then each vertical grid unit shall be 180 twentieths of a point (0.125") in width.
  /// </para>
  /// </summary>
  [DataMember]
  public Twips? DrawingGridVerticalSpacing
  {
    get => _DocumentSettings?.GetTwipsVal<DXW.DrawingGridVerticalSpacing>();
    set => _ExistingSettings.SetTwipsVal<DXW.DrawingGridVerticalSpacing>(value);
  }

  /// <summary>
  /// This element specifies the distance from of the left edge of the page which shall be used as the origin 
  /// for the horizontal gridlines used by the drawing grid. 
  /// The drawing grid is a virtual grid which might be used by applications to specify 
  /// where drawing objects shall be positioned on a page when inserted (i.e. to ensure objects are aligned, etc.). 
  /// Since the grid always covers the entire page when the DoNotUseMarginsForDrawingGridOrigin element is specified, 
  /// this element shall only affect the starting edge of the first horizontal gridline displayed 
  /// (i.e. it only adjusts the grid by the modulus of the value against the width of one grid unit).
  /// <para>
  /// If this element is omitted, then the gridlines shall start at the leftmost edge of the page. 
  /// If the SoNotUseMarginsForDrawingGridOrigin element is not specified, then this element is ignored.
  /// </para>
  /// </summary>
  [DataMember]
  public Twips? DrawingGridHorizontalOrigin
  {
    get => _DocumentSettings?.GetTwipsVal<DXW.DrawingGridHorizontalOrigin>();
    set => _ExistingSettings.SetTwipsVal<DXW.DrawingGridHorizontalOrigin>(value);
  }

  /// <summary>
  /// This element specifies the distance from of the top edge of the page which shall be used as the origin 
  /// for the vertical gridlines used by the drawing grid. 
  /// The drawing grid is a virtual grid which can be used by applications to specify 
  /// where drawing objects shall be positioned on a page when inserted (i.e. to ensure objects are aligned, etc.). 
  /// Since the grid always covers the entire page when the DoNotUseMarginsForDrawingGridOrigin element is specified, 
  /// this element shall only affect the starting edge of the first vertical gridline displayed 
  /// (i.e. it only adjusts the grid by the modulus of the value against the width of one grid unit).
  /// <para>
  /// If this element is omitted, then the gridlines shall start at the topmost edge of the page. 
  /// If the DoNotUseMarginsForDrawingGridOrigin element is not specified, then this element is ignored.
  /// </para>
  /// </summary>
  [DataMember]
  public Twips? DrawingGridVerticalOrigin
  {
    get => _DocumentSettings?.GetTwipsVal<DXW.DrawingGridVerticalOrigin>();
    set => _ExistingSettings.SetTwipsVal<DXW.DrawingGridVerticalOrigin>(value);
  }

  /// <summary>
  /// This element specifies the number of horizontal grid units defined using the DrawingGridHorizontalSpacing element 
  /// which shall be allowed between subsequent visible horizontal drawing grid lines in this document, 
  /// if gridlines are being shown. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document.
  /// <para>
  /// [Note: The display of gridlines is an application-level setting not specified in /IEC 29500. end note] 
  /// </para>
  /// <para>
  /// If this element is omitted, then gridlines shall be displayed for each horizontal grid unit.
  /// </para>
  /// </summary>
  [DataMember]
  public int? DisplayHorizontalDrawingGrid
  {
    get => _DocumentSettings?.GetIntVal<DXW.DisplayHorizontalDrawingGrid>();
    set => _ExistingSettings.SetIntVal<DXW.DisplayHorizontalDrawingGrid>(value);
  }

  /// <summary>
  /// This element specifies the number of vertical grid units defined using the DrawingGridVerticalSpacing element 
  /// which shall be allowed between subsequent visible vertical drawing grid lines in this document, 
  /// if gridlines are being shown. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document.
  /// <para>
  /// [Note: The display of gridlines is an application-level setting not specified in /IEC 29500. end note] 
  /// </para>
  /// <para>
  /// If this element is omitted, then gridlines shall be displayed for each vertical grid unit.
  /// </para>
  /// </summary>
  [DataMember]
  public int? DisplayVerticalDrawingGrid
  {
    get => _DocumentSettings?.GetIntVal<DXW.DisplayVerticalDrawingGrid>();
    set => _ExistingSettings.SetIntVal<DXW.DisplayVerticalDrawingGrid>(value);
  }

  /// <summary>
  /// This element specifies the size for automatic document summaries performed on the content of a WordprocessingML document. 
  /// An automatic document summary is a subset of text contained in a document deemed by the hosting application 
  /// to summarize the content of the WordprocessingML document. The val attribute of this element specifies the size 
  /// of an automatic document summary to be performed on a given WordprocessingML document 
  /// as a percentage of the total size of the given WordprocessingML document. 
  /// Performing an automatic document summary is a runtime operation outside the scope of /IEC 29500.
  /// <para>
  /// If this element is omitted, then applications can summarize this document to any desired size.
  /// </para>
  /// </summary>
  [DataMember]
  public Percent? SummaryLength
  {
    get => _DocumentSettings?.GetIntVal<DXW.SummaryLength>();
    set => _ExistingSettings.SetIntVal<DXW.SummaryLength>(value);
  }

  /// <summary>
  /// This element specifies the maximum number of consecutive lines of text that can end with a hyphen 
  /// when the contents of this document are displayed. Once this limit has been reached, 
  /// the following line shall not be hyphenated regardless of whether or not it meets the criteria needed for hyphenation.
  /// <para>
  /// If this element is omitted or has its val attribute equal to 0, 
  /// the given WordprocessingML document shall have no limit on the number of consecutive lines of text that can end with a hyphen.
  /// </para>
  /// </summary>
  [DataMember]
  public int? ConsecutiveHyphenLimit
  {
    get => _DocumentSettings?.GetIntVal<DXW.ConsecutiveHyphenLimit>();
    set => _ExistingSettings.SetIntVal<DXW.ConsecutiveHyphenLimit>(value);
  }

  [DataMember]
  public ActiveWritingStyle? ActiveWritingStyle
  {
    get => _DocumentSettings?.GetObject<ActiveWritingStyle, DXW.ActiveWritingStyle>();
    set => _ExistingSettings.SetObject<ActiveWritingStyle, DXW.ActiveWritingStyle>(value);
  }

}


