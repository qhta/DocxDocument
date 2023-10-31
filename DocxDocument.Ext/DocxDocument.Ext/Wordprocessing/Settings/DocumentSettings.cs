namespace DocumentModel.Wordprocessing;
public partial class DocumentSettings
{

  public DocumentSettings(DMW.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    Load();
  }

  internal DXP.WordprocessingDocument WordprocessingDocument { get; private set; }

  //#region DocumentSettings
  internal DXW.Settings? _DocumentSettings { get; private set; }
  internal DXW.Settings _ExistingSettings
  {
    get
    {
      if (_DocumentSettings == null) Load();
      Debug.Assert(_DocumentSettings != null);
      return _DocumentSettings;
    }
  }

  public void Load()
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
    var settingsPart = mainDocumentPart.DocumentSettingsPart;
    if (settingsPart == null)
      settingsPart = mainDocumentPart.AddNewPart<DXP.DocumentSettingsPart>();
    var settings = settingsPart.Settings;
    if (settings == null)
    {
      settings = new DXW.Settings();
      settingsPart.Settings = settings;
    }
    _DocumentSettings = settings;
  }

  /// <summary>
  /// Specifies the write protection settings which have been applied to a WordprocessingML document. 
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
  public DMW.WriteProtection? WriteProtection
  {
    get => _DocumentSettings?.GetObject<WriteProtection, DXW.WriteProtection>();
    set => _ExistingSettings.SetObject<WriteProtection, DXW.WriteProtection>(value);
  }

  /// <summary>
  /// Specifies the manner in which the contents of this document should be displayed when opened by an application.
  /// </summary>
  public DXW.ViewValues? View
  {
    get => _DocumentSettings?.GetEnumVal<DXW.ViewValues, DXW.View>();
    set => _ExistingSettings?.SetEnumVal<DXW.ViewValues, DXW.View>(value);
  }

  /// <summary>
  /// Specifies that hosting applications shall remove all personal information of document authors upon saving
  /// a given WordprocessingML document. The definition and extent of personal information is not defined by /IEC 29500.
  /// </summary>
  public Boolean? RemovePersonalInformation
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.RemovePersonalInformation>();
    set => _ExistingSettings.SetBooleanVal<DXW.RemovePersonalInformation>(value);
  }

  /// <summary>
  /// Specifies that the date and time information shall be removed from all annotations 
  /// which are present in the current document when it is saved. 
  /// Annotations store this information in the date attribute on the annotation's XML element.
  /// </summary>
  public Boolean? RemoveDateAndTime
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.RemoveDateAndTime>();
    set => _ExistingSettings.SetBooleanVal<DXW.RemoveDateAndTime>(value);
  }

  /// <summary>
  /// Specifies whether applications displaying this document should display the contents of the header and footer 
  /// when displaying the document in print layout view (§17.15.1.92) or should collapse those areas 
  /// as well as the whitespace on all displayed pages so that the text extents are directly following one another. 
  /// [Rationale: Collapsing the ends of pages makes it easier to read the contents of the document, 
  /// since the text flows between pages without whitespace, while maintaining the WYSIWYG functionality 
  /// of print layout view for the document's main content. end rationale]
  /// </summary>
  public Boolean? DoNotDisplayPageBoundaries
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.DoNotDisplayPageBoundaries>();
    set => _ExistingSettings.SetBooleanVal<DXW.DoNotDisplayPageBoundaries>(value);
  }

  /// <summary>
  /// Specifies whether the images and colors defined in the document's background using the background element (§17.2.1) 
  /// shall be displayed when the document is displayed in print layout view as specified in the view element (§17.15.1.92).
  /// </summary>
  public Boolean? DisplayBackgroundShape
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.DisplayBackgroundShape>();
    set => _ExistingSettings.SetBooleanVal<DXW.DisplayBackgroundShape>(value);
  }

  /// <summary>
  /// Specifies that the PostScript codes specified in WordprocessingML documents containing PRINT fields shall be included in foreground 
  /// (on the same Z-order as text) with the data printed in the contents of a given WordprocessingML document.
  /// [Note: This setting is maintained to ensure compatibility of legacy word processing documents. 
  /// The PRINT field should not be used in lieu of newer technologies in /IEC 29500. end note]
  /// </summary>
  public Boolean? PrintPostScriptOverText
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.PrintPostScriptOverText>();
    set => _ExistingSettings.SetBooleanVal<DXW.PrintPostScriptOverText>(value);
  }

  /// <summary>
  /// Specifies the contents of this document shall be printed with fractional character widths. 
  /// Fractional character widths exist when the spacing between characters is not constant (i.e. a proportional font face is used).
  /// [Note: Fractional character widths are generally used in conjunction with large font sizes 
  /// to prevent characters from running together or having too much space between one another. end note]
  /// </summary>
  public Boolean? PrintFractionalCharacterWidth
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.PrintFractionalCharacterWidth>();
    set => _ExistingSettings.SetBooleanVal<DXW.PrintFractionalCharacterWidth>(value);
  }

  /// <summary>
  /// Specifies that printing the contents of this document shall only print the contents 
  /// of WordprocessingML form fields defined using the FORMTEXT, FORMCHECKBOX, and FORMDROPDOWN field codes 
  /// in their current locations on the page - all other document contents shall be suppressed.
  /// [Rationale: This setting is typically used to allow duplication of paper forms in electronic WordprocessingML document form, 
  /// allowing the resulting online document to be printed into the correct locations on the existing paper form. end rationale]
  /// </summary>
  public Boolean? PrintFormsData
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.PrintFormsData>();
    set => _ExistingSettings.SetBooleanVal<DXW.PrintFormsData>(value);
  }

  /// <summary>
  /// Specifies that applications shall embed the fonts in use in this document when it is saved. 
  /// These fonts shall be embedded subject to the algorithm specified in §17.8.1.
  /// </summary>
  public Boolean? EmbedTrueTypeFonts
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.EmbedTrueTypeFonts>();
    set => _ExistingSettings.SetBooleanVal<DXW.EmbedTrueTypeFonts>(value);
  }

  /// <summary>
  /// Specifies that applications shall embed common system fonts when they are in use 
  /// and font embedding is enabled for this document using the embedTrueTypeFonts element (§17.8.3.8). 
  /// Common system fonts refer to a set of fonts which are typically always present on a machine, and are not defined by /IEC 29500.
  /// </summary>
  public Boolean? EmbedSystemFonts
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.EmbedSystemFonts>();
    set => _ExistingSettings.SetBooleanVal<DXW.EmbedSystemFonts>(value);
  }

  /// <summary>
  /// Specifies that applications shall subset fonts when font embedding is enabled 
  /// for this document using the embedTrueTypeFonts element (§17.8.3.8). 
  /// Subsetting is a mechanism by which only the glyphs used in the contents of this WordprocessingML document are stored in an embedded font, 
  /// in order to prevent the file from becoming unnecessarily large from the use of a small number of glyphs from a large embedded font.
  /// </summary>
  public Boolean? SaveSubsetFonts
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.SaveSubsetFonts>();
    set => _ExistingSettings.SetBooleanVal<DXW.SaveSubsetFonts>(value);
  }

  /// <summary>
  /// Specifies that saving the contents of this document shall only save the contents of WordprocessingML form fields 
  /// defined using the FORMTEXT, FORMCHECKBOX, and FORMDROPDOWN field codes in a comma-delimited text format
  /// which does not conform to /IEC 29500 (i.e. it is a one-way export from a WordprocessingML document).
  /// [Rationale: This setting is typically used to allow duplication of paper forms in electronic WordprocessingML document form, 
  /// allowing the resulting content to be extracted as a comma-delimited text file. end rationale]
  /// </summary>
  public Boolean? SaveFormsData
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.SaveFormsData>();
    set => _ExistingSettings.SetBooleanVal<DXW.SaveFormsData>(value);
  }

  /// <summary>
  /// Specifies that the left and right margins defined in the section properties shall be swapped on facing pages.
  /// [Guidance: This setting is generally used when printing on both sides of pages and binding them like a book. end guidance]
  /// </summary>
  public Boolean? MirrorMargins
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.MirrorMargins>();
    set => _ExistingSettings.SetBooleanVal<DXW.MirrorMargins>(value);
  }

  /// <summary>
  /// Specifies that paragraph borders specified using the pBdr element (§17.3.1.24) and table borders using the tblBorders element (§17.4.40) 
  /// shall be adjusted to align with extents of the page border defined using the pgBorders element (§17.6.10) 
  /// if the spacing between these borders is less than or equal to 10.5 points (one character width) or less from the page border. 
  /// The presence of this setting shall ensure there are no gaps of one character width or less between adjoining page and paragraph/table borders, 
  /// as borders which are perfectly aligning shall not be displayed in favor of the intervening page border.
  /// </summary>
  public Boolean? AlignBorderAndEdges
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.AlignBorderAndEdges>();
    set => _ExistingSettings.SetBooleanVal<DXW.AlignBorderAndEdges>(value);
  }

  /// <summary>
  /// Specifies that a given WordprocessingML document’s page border specified using the pgBorders element (§17.6.10) 
  /// should not surround contents of the header.
  /// If this element is omitted, then the page border shall not exclude the header on the page. 
  /// As well, this element shall be ignored if the pgBorders element has an offsetFrom attribute which is not equal to text.
  /// [Note: If the pgBorders element has a offsetFrom attribute equal to page, the bordersDoNotSurroundHeader element is ignored 
  /// as specifying the pgBorders element with a offsetFrom attribute equal to page is to specify that the positioning of borders 
  /// within the document shall be calculated relative to the edge of the page and therefore irrespective of document content in the header. end note]
  /// </summary>
  public Boolean? BordersDoNotSurroundHeader
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.BordersDoNotSurroundHeader>();
    set => _ExistingSettings.SetBooleanVal<DXW.BordersDoNotSurroundHeader>(value);
  }

  /// <summary>
  /// Specifies that a given WordprocessingML document’s page border specified using the pgBorders element (§17.6.10) 
  /// should not surround contents of the footer.
  /// <para>
  /// If this element is omitted, then the page border shall not exclude the footer on the page. 
  /// As well, this element shall be ignored if the pgBorders element has an offsetFrom attribute which is not equal to text.
  /// </para>
  /// [Note: If the pgBorders element has a offsetFrom attribute equal to page, the bordersDoNotSurroundFooter element is ignored
  /// as specifying the pgBorders element with a offsetFrom attribute equal to page is to specify that the positioning of borders
  /// within the document shall be calculated relative to the edge of the page and therefore irrespective of document content in the footer. end note]
  /// </summary>
  public Boolean? BordersDoNotSurroundFooter
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.BordersDoNotSurroundFooter>();
    set => _ExistingSettings.SetBooleanVal<DXW.BordersDoNotSurroundFooter>(value);
  }

  /// <summary>
  /// Specifies that a given WordprocessingML document’s gutter shall be positioned at the top of the document’s pages when the document is displayed. 
  /// A gutter is the white space formed by the inner margins of two pages facing one another; 
  /// such as the white space between the text on pages of a book when the book is opened.
  /// <para>
  /// If this element is omitted, then the gutter shall not be positioned at the top of the page. 
  /// If the mirrorMargins (§17.15.1.57), bookFoldPrinting (§17.15.1.11), bookFoldRevPrinting (§17.15.1.13), or printTwoOnOne (§17.15.1.64) elements 
  /// are used within a given document, the gutterAtTop element shall not be used. 
  /// Rather, the gutter shall be positioned automatically as necessary to enable the printing and page layout capabilities of these settings.
  /// </para>
  /// </summary>
  public Boolean? GutterAtTop
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.GutterAtTop>();
    set => _ExistingSettings.SetBooleanVal<DXW.GutterAtTop>(value);
  }

  /// <summary>
  /// Specifies whether a visual cue should be displayed around run content contained in a WordprocessingML document 
  /// which has been flagged as a possible spelling error using the proofErr element (§17.13.8.1) or via the application's own spelling engine.
  /// If this element is not present in a WordprocessingML document, visual cues shall be displayed on content 
  /// contained in a WordprocessingML document which is considered to contain spelling errors.
  /// </summary>
  public Boolean? HideSpellingErrors
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.HideSpellingErrors>();
    set => _ExistingSettings.SetBooleanVal<DXW.HideSpellingErrors>(value);
  }

  /// <summary>
  /// Specifies whether a visual cue should be displayed around run content contained in a WordprocessingML document 
  /// which has been flagged as a possible grammatical error using the proofErr element (§17.13.8.1) or via the application's own grammar engine.
  /// If this element is not present in a WordprocessingML document, visual cues shall be displayed on content 
  /// contained in a WordprocessingML document which is considered to contain grammatical errors.
  /// </summary>
  public Boolean? HideGrammaticalErrors
  {
    get => _DocumentSettings?.GetBooleanVal<DXW.HideGrammaticalErrors>();
    set => _ExistingSettings.SetBooleanVal<DXW.HideGrammaticalErrors>(value);
  }

  public Boolean? ForceUpgrade
  {
    get => _DocumentSettings?.GetTrueIfExists<DXW.ForceUpgrade>();
    set => _ExistingSettings.SetExistsIfTrue<DXW.ForceUpgrade>(value);
  }

  /// <summary>
  /// Specifies the set of characters which shall be restricted from ending a line for runs of text 
  /// which shall be subject to custom line breaking logic using the kinsoku element (§17.3.1.16) 
  /// when the contents of the document are displayed. 
  /// This constraint shall only apply to text which has been flagged in the language of this rule via the lang element (§17.3.2.20) 
  /// or automatic detection methods outside the scope of /IEC 29500.
  /// </summary>
  public NoBreakKinsoku? NoLineBreaksAfterKinsoku
  {
    get => _DocumentSettings?.GetObject<NoBreakKinsoku, DXW.NoLineBreaksAfterKinsoku>();
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.NoLineBreaksAfterKinsoku>().FirstOrDefault();
        if (setting != null)
        {
          setting.Language = value.Lang;
          setting.Val = value.Val;
        }
        else
          _ExistingSettings.AppendChild(new DXW.NoLineBreaksAfterKinsoku { Language = value.Lang, Val = value.Val });
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.NoLineBreaksAfterKinsoku>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
      }
    }
  }

  /// <summary>
  /// Specifies the set of characters which shall be restricted from beginning a new line for runs of text 
  /// which shall be subject to custom line breaking logic using the kinsoku element (§17.3.1.16) 
  /// when the contents of the document are displayed. 
  /// This constraint shall only apply to text which has been flagged in the language of this rule via the lang element (§17.3.2.20) 
  /// or automatic detection methods outside the scope of /IEC 29500.
  /// </summary>
  public NoBreakKinsoku? NoLineBreaksBeforeKinsoku
  {
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.NoLineBreaksBeforeKinsoku>().FirstOrDefault();
      if (setting == null)
        return null;
      return new NoBreakKinsoku { Lang = setting.Language, Val = setting.Val };
    }
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.NoLineBreaksBeforeKinsoku>().FirstOrDefault();
        if (setting != null)
        {
          setting.Language = value.Lang;
          setting.Val = value.Val;
        }
        else
          _ExistingSettings.AppendChild(new DXW.NoLineBreaksBeforeKinsoku { Language = value.Lang, Val = value.Val });
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.NoLineBreaksBeforeKinsoku>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
      }
    }
  }

  /// <summary>
  /// Specifies the set of document protection restrictions which have been applied to the contents of a WordprocessingML document. 
  /// These restrictions should be enforced by applications editing this document when the enforcement attribute is turned on, 
  /// and ignored (but persisted) otherwise. 
  /// Document protection is a set of restrictions used to prevent unintentional changes to all or part of a WordprocessingML document. 
  /// [Note: This protection does not encrypt the document, and malicious applications might circumvent its use. 
  /// This protection is not intended as a security feature. end note]
  /// </summary>
  public DocumentProtection? DocumentProtection
  {
    get => _DocumentSettings?.GetObject<DocumentProtection, DXW.DocumentProtection>();
    set => _ExistingSettings.SetObject<DocumentProtection, DXW.DocumentProtection>(value);
  }

  /// <summary>
  /// Specifies the presence of information about captions in a given WordprocessingML document. 
  /// This information is divided into two components:
  /// <list type="bullet">
  ///   <item>The child elements Caption defines the format for a single type of caption to be automatically added to the document.</item>
  ///   <item>The child element AutoCaptions defines the types of objects to which a caption format shall automatically be applied.</item>
  /// </list>
  ///  This information should be used to determine the captions which are automatically added to objects when they are inserted into a WordprocessingML document. [Note: This setting is typically ignored unless it is specified in an application's default template. end note]
  /// </summary>
  public Captions? Captions
  {
    get => _DocumentSettings?.GetObject<Captions, DXW.Captions>();
    set => _ExistingSettings.SetObject<Captions, DXW.Captions>(value);
  }


  /// <summary>
  /// Specifies if the grammar and spell checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  public ProofState? ProofState
  {
    get => _DocumentSettings?.GetObject<ProofState, DXW.ProofState>();
    set => _ExistingSettings.SetObject<ProofState, DXW.ProofState>(value);
  }

  /// <summary>
  /// Specifies the magnification level which should be applied to a document when it is displayed by an application. 
  /// The zoom level is specified with the use of two attributes stored on this element:
  /// <list type="bullet">
  ///   <item>val, which stores the type of zoom applied to the document</item>
  ///   <item>percent, which stores the zoom percentage to be used when rendering the document</item>
  /// </list>
  /// If both attributes are present, then the percent attribute shall be treated as a 'cached' value and only used when the value none is specified for the val attribute.
  /// </summary>
  public Zoom? Zoom
  {
    get => _DocumentSettings?.GetObject<Zoom, DXW.Zoom>();
    set => _ExistingSettings.SetObject<Zoom, DXW.Zoom>(value);
  }

  /// <summary>
  /// Specifies if the grammar and spell checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get => _DocumentSettings?.GetObject<StylePaneFormatFilter, DXW.StylePaneFormatFilter>();
    set => _ExistingSettings.SetObject<StylePaneFormatFilter, DXW.StylePaneFormatFilter>(value);

  }

  /// <summary>
  /// Specifies the value which shall be used as the multiplier to generate automatic tab stops in this document. 
  /// Automatic tab stops refer to the tab stop locations which occur after all custom tab stops in the current paragraph have been surpassed.
  /// </summary>
  public Twips? DefaultTabStop
  {
    get => _DocumentSettings?.GetTwips<DXW.DefaultTabStop>();
    set => _ExistingSettings.SetTwips<DXW.DefaultTabStop>(value);
  }

  /// <summary>
  ///  Specifies the hyphenation zone which shall be used when automatically or manually hyphenating the contents of this document. 
  ///  The hyphenation zone is the amount of whitespace which can be left at the end of a line (or added to justified lines) 
  ///  before hyphenation should be attempted on the next word in the document (in order to reduce the amount of whitespace on the line). 
  ///  A smaller hyphenation zone should reduce the raggedness of the right edge of a given document's body text, as more words is hyphenated. 
  ///  Conversely, a larger hyphenation zone should increase the raggedness of the right edge of a given document's text, as fewer words is hyphenated.
  /// </summary>
  public Twips? HyphenationZone
  {
    get => _DocumentSettings?.GetTwips<DXW.HyphenationZone>();
    set => _ExistingSettings.SetTwips<DXW.HyphenationZone>(value);
  }

  /// <summary>
  /// Specifies the sets of characters which should be compressed when the contents of this document are displayed.
  /// </summary>
  public DXW.CharacterSpacingValues? CharacterSpacingControl
  {
    get => _DocumentSettings?.GetEnumVal<DXW.CharacterSpacingValues, DXW.CharacterSpacingControl>();
    set => _ExistingSettings.SetEnumVal<DXW.CharacterSpacingValues, DXW.CharacterSpacingControl>(value);
  }

  /// <summary>
  /// Specifies a set of optional compatibility options for the current document.
  /// </summary>
  public DMW.Compatibility? Compatibility
  {
    get => _DocumentSettings?.GetObject<DMW.Compatibility, DXW.Compatibility>();
    set => _ExistingSettings.SetObject<DMW.Compatibility, DXW.Compatibility>(value);
  }

  /// <summary>
  /// Specifies the set of revision save ID values for the current document. 
  /// Revision save ID values refer to four digit hexadecimal values which uniquely identify an editing session in the life of the current document. 
  /// An editing session is the period of time between two subsequent save operations by an application.
  /// [Guidance: The set of revision save IDs stored with a document only supplies information about the editing session 
  /// in which document components were last saved, which can be used by applications in any manner desired. end guidance]  
  /// </summary>
  public DMW.Rsids? Rsids
  {
    get => _DocumentSettings?.GetObject<DMW.Rsids, DXW.Rsids>();
    set => _ExistingSettings.SetObject<DMW.Rsids, DXW.Rsids>(value);
  }

  /// <summary>
  ///  Specifies the document-level properties for all math in the document. 
  /// </summary>
  public DMM.MathProperties? MathProperties
  {
    get => _DocumentSettings?.GetObject<DMM.MathProperties, DXM.MathProperties>();
    set => _ExistingSettings.SetObject<DMM.MathProperties, DXM.MathProperties>(value);
  }

  ///   <item><description><see cref="DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary" /> <c>&lt;sl:schemaLibrary></c></description></item>
  ///   <item><description><see cref=" DXW.ColorSchemeMapping" /> <c>&lt;w:clrSchemeMapping></c></description></item>
  ///   <item><description><see cref=" DXW.DocumentType" /> <c>&lt;w:documentType></c></description></item>
  ///   <item><description><see cref=" DXW.DocumentVariables" /> <c>&lt;w:docVars></c></description></item>
  ///   <item><description><see cref=" DXW.EndnoteDocumentWideProperties" /> <c>&lt;w:endnotePr></c></description></item>
  ///   <item><description><see cref=" DXW.FootnoteDocumentWideProperties" /> <c>&lt;w:footnotePr></c></description></item>

  ///   <item><description><see cref=" DXW.ThemeFontLanguages" /> <c>&lt;w:themeFontLang></c></description></item>
  ///   <item><description><see cref=" DXW.MailMerge" /> <c>&lt;w:mailMerge></c></description></item>
  ///   <item><description><see cref=" DXW.BookFoldPrintingSheets" /> <c>&lt;w:bookFoldPrintingSheets></c></description></item>
  ///   <item><description><see cref=" DXW.RemovePersonalInformation" /> <c>&lt;w:removePersonalInformation></c></description></item>
  ///   <item><description><see cref=" DXW.RemoveDateAndTime" /> <c>&lt;w:removeDateAndTime></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotDisplayPageBoundaries" /> <c>&lt;w:doNotDisplayPageBoundaries></c></description></item>
  ///   <item><description><see cref=" DXW.DisplayBackgroundShape" /> <c>&lt;w:displayBackgroundShape></c></description></item>
  ///   <item><description><see cref=" DXW.PrintPostScriptOverText" /> <c>&lt;w:printPostScriptOverText></c></description></item>
  ///   <item><description><see cref=" DXW.PrintFractionalCharacterWidth" /> <c>&lt;w:printFractionalCharacterWidth></c></description></item>
  ///   <item><description><see cref=" DXW.PrintFormsData" /> <c>&lt;w:printFormsData></c></description></item>
  ///   <item><description><see cref=" DXW.EmbedTrueTypeFonts" /> <c>&lt;w:embedTrueTypeFonts></c></description></item>
  ///   <item><description><see cref=" DXW.EmbedSystemFonts" /> <c>&lt;w:embedSystemFonts></c></description></item>
  ///   <item><description><see cref=" DXW.SaveSubsetFonts" /> <c>&lt;w:saveSubsetFonts></c></description></item>
  ///   <item><description><see cref=" DXW.SaveFormsData" /> <c>&lt;w:saveFormsData></c></description></item>
  ///   <item><description><see cref=" DXW.MirrorMargins" /> <c>&lt;w:mirrorMargins></c></description></item>
  ///   <item><description><see cref=" DXW.AlignBorderAndEdges" /> <c>&lt;w:alignBordersAndEdges></c></description></item>
  ///   <item><description><see cref=" DXW.BordersDoNotSurroundHeader" /> <c>&lt;w:bordersDoNotSurroundHeader></c></description></item>
  ///   <item><description><see cref=" DXW.BordersDoNotSurroundFooter" /> <c>&lt;w:bordersDoNotSurroundFooter></c></description></item>
  ///   <item><description><see cref=" DXW.GutterAtTop" /> <c>&lt;w:gutterAtTop></c></description></item>
  ///   <item><description><see cref=" DXW.HideSpellingErrors" /> <c>&lt;w:hideSpellingErrors></c></description></item>
  ///   <item><description><see cref=" DXW.HideGrammaticalErrors" /> <c>&lt;w:hideGrammaticalErrors></c></description></item>
  ///   <item><description><see cref=" DXW.FormsDesign" /> <c>&lt;w:formsDesign></c></description></item>
  ///   <item><description><see cref=" DXW.LinkStyles" /> <c>&lt;w:linkStyles></c></description></item>
  ///   <item><description><see cref=" DXW.TrackRevisions" /> <c>&lt;w:trackRevisions></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotTrackMoves" /> <c>&lt;w:doNotTrackMoves></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotTrackFormatting" /> <c>&lt;w:doNotTrackFormatting></c></description></item>
  ///   <item><description><see cref=" DXW.AutoFormatOverride" /> <c>&lt;w:autoFormatOverride></c></description></item>
  ///   <item><description><see cref=" DXW.StyleLockThemesPart" /> <c>&lt;w:styleLockTheme></c></description></item>
  ///   <item><description><see cref=" DXW.StyleLockStylesPart" /> <c>&lt;w:styleLockQFSet></c></description></item>
  ///   <item><description><see cref=" DXW.AutoHyphenation" /> <c>&lt;w:autoHyphenation></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotHyphenateCaps" /> <c>&lt;w:doNotHyphenateCaps></c></description></item>
  ///   <item><description><see cref=" DXW.ShowEnvelope" /> <c>&lt;w:showEnvelope></c></description></item>
  ///   <item><description><see cref=" DXW.EvenAndOddHeaders" /> <c>&lt;w:evenAndOddHeaders></c></description></item>
  ///   <item><description><see cref=" DXW.BookFoldReversePrinting" /> <c>&lt;w:bookFoldRevPrinting></c></description></item>
  ///   <item><description><see cref=" DXW.BookFoldPrinting" /> <c>&lt;w:bookFoldPrinting></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotUseMarginsForDrawingGridOrigin" /> <c>&lt;w:doNotUseMarginsForDrawingGridOrigin></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotShadeFormData" /> <c>&lt;w:doNotShadeFormData></c></description></item>
  ///   <item><description><see cref=" DXW.NoPunctuationKerning" /> <c>&lt;w:noPunctuationKerning></c></description></item>
  ///   <item><description><see cref=" DXW.PrintTwoOnOne" /> <c>&lt;w:printTwoOnOne></c></description></item>
  ///   <item><description><see cref=" DXW.StrictFirstAndLastChars" /> <c>&lt;w:strictFirstAndLastChars></c></description></item>
  ///   <item><description><see cref=" DXW.SavePreviewPicture" /> <c>&lt;w:savePreviewPicture></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotValidateAgainstSchema" /> <c>&lt;w:doNotValidateAgainstSchema></c></description></item>
  ///   <item><description><see cref=" DXW.SaveInvalidXml" /> <c>&lt;w:saveInvalidXml></c></description></item>
  ///   <item><description><see cref=" DXW.IgnoreMixedContent" /> <c>&lt;w:ignoreMixedContent></c></description></item>
  ///   <item><description><see cref=" DXW.AlwaysShowPlaceholderText" /> <c>&lt;w:alwaysShowPlaceholderText></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotDemarcateInvalidXml" /> <c>&lt;w:doNotDemarcateInvalidXml></c></description></item>
  ///   <item><description><see cref=" DXW.SaveXmlDataOnly" /> <c>&lt;w:saveXmlDataOnly></c></description></item>
  ///   <item><description><see cref=" DXW.UseXsltWhenSaving" /> <c>&lt;w:useXSLTWhenSaving></c></description></item>
  ///   <item><description><see cref=" DXW.ShowXmlTags" /> <c>&lt;w:showXMLTags></c></description></item>
  ///   <item><description><see cref=" DXW.AlwaysMergeEmptyNamespace" /> <c>&lt;w:alwaysMergeEmptyNamespace></c></description></item>
  ///   <item><description><see cref=" DXW.UpdateFieldsOnOpen" /> <c>&lt;w:updateFields></c></description></item>
  ///   <item><description><see cref=" DXW.UICompatibleWith97To2003" /> <c>&lt;w:uiCompat97To2003></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotIncludeSubdocsInStats" /> <c>&lt;w:doNotIncludeSubdocsInStats></c></description></item>
  ///   <item><description><see cref=" DXW.DoNotAutoCompressPictures" /> <c>&lt;w:doNotAutoCompressPictures></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased" /> <c>&lt;w15:chartTrackingRefBased></c></description></item>
  ///   <item><description><see cref=" DXW.ReadModeInkLockDown" /> <c>&lt;w:readModeInkLockDown></c></description></item>
  ///   <item><description><see cref=" DXW.AttachedTemplate" /> <c>&lt;w:attachedTemplate></c></description></item>
  ///   <item><description><see cref=" DXW.SaveThroughXslt" /> <c>&lt;w:saveThroughXslt></c></description></item>
  ///   <item><description><see cref=" DXW.HeaderShapeDefaults" /> <c>&lt;w:hdrShapeDefaults></c></description></item>
  ///   <item><description><see cref=" DXW.ShapeDefaults" /> <c>&lt;w:shapeDefaults></c></description></item>
  ///   <item><description><see cref=" DXW.AttachedSchema" /> <c>&lt;w:attachedSchema></c></description></item>
  ///   <item><description><see cref=" DXW.DecimalSymbol" /> <c>&lt;w:decimalSymbol></c></description></item>
  ///   <item><description><see cref=" DXW.ListSeparator" /> <c>&lt;w:listSeparator></c></description></item>
  ///   <item><description><see cref=" DXW.ClickAndTypeStyle" /> <c>&lt;w:clickAndTypeStyle></c></description></item>
  ///   <item><description><see cref=" DXW.DefaultTableStyle" /> <c>&lt;w:defaultTableStyle></c></description></item>
  ///   <item><description><see cref=" DXW.StylePaneFormatFilter" /> <c>&lt;w:stylePaneFormatFilter></c></description></item>
  ///   <item><description><see cref=" DXW.StylePaneSortMethods" /> <c>&lt;w:stylePaneSortMethod></c></description></item>
  ///   <item><description><see cref=" DXW.RevisionView" /> <c>&lt;w:revisionView></c></description></item>
  ///   <item><description><see cref=" DXW.DrawingGridHorizontalSpacing" /> <c>&lt;w:drawingGridHorizontalSpacing></c></description></item>
  ///   <item><description><see cref=" DXW.DrawingGridVerticalSpacing" /> <c>&lt;w:drawingGridVerticalSpacing></c></description></item>
  ///   <item><description><see cref=" DXW.DrawingGridHorizontalOrigin" /> <c>&lt;w:drawingGridHorizontalOrigin></c></description></item>
  ///   <item><description><see cref=" DXW.DrawingGridVerticalOrigin" /> <c>&lt;w:drawingGridVerticalOrigin></c></description></item>
  ///   <item><description><see cref=" DXW.SummaryLength" /> <c>&lt;w:summaryLength></c></description></item>
  ///   <item><description><see cref=" DXW.DisplayHorizontalDrawingGrid" /> <c>&lt;w:displayHorizontalDrawingGridEvery></c></description></item>
  ///   <item><description><see cref=" DXW.DisplayVerticalDrawingGrid" /> <c>&lt;w:displayVerticalDrawingGridEvery></c></description></item>
  ///   <item><description><see cref=" DXW.ConsecutiveHyphenLimit" /> <c>&lt;w:consecutiveHyphenLimit></c></description></item>
  ///   <item><description><see cref=" DXW.View" /> <c>&lt;w:view></c></description></item>
  ///   <item><description><see cref=" DXW.WriteProtection" /> <c>&lt;w:writeProtection></c></description></item>
  ///   <item><description><see cref=" DXW.ActiveWritingStyle" /> <c>&lt;w:activeWritingStyle></c></description></item>
  ///   <item><description><see cref=" DXW.Zoom" /> <c>&lt;w:zoom></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi" /> <c>&lt;w14:defaultImageDpi></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DocumentId" /> <c>&lt;w14:docId></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData" /> <c>&lt;w14:discardImageEditingData></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.ConflictMode" /> <c>&lt;w14:conflictMode></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId" /> <c>&lt;w15:docId></c></description></item>

  //#endregion
}


