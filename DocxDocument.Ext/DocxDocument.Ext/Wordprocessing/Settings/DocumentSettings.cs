namespace DocumentModel.Wordprocessing;
public partial class DocumentSettings
{

  public DocumentSettings(DM.Document document)
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
  public DXW.WriteProtection? WriteProtection
  {
    get => _DocumentSettings?.WriteProtection;
    set => _ExistingSettings.WriteProtection = value;
  }

  public DXW.ViewValues? View
  {
    get => _DocumentSettings?.View?.Val?.Value;
    set
    {
      if (value != null)
        _ExistingSettings.View = new DXW.View { Val = value };
      else
        _ExistingSettings.View = null;
    }
  }

  public Boolean? RemovePersonalInformation
  {
    get => _DocumentSettings?.RemovePersonalInformation?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.RemovePersonalInformation = new DXW.RemovePersonalInformation { Val = value };
      else
        _ExistingSettings.RemovePersonalInformation = null;
    }
  }

  public Boolean? RemoveDateAndTime
  {
    get => _DocumentSettings?.RemoveDateAndTime?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.RemoveDateAndTime = new DXW.RemoveDateAndTime { Val = value };
      else
        _ExistingSettings.RemoveDateAndTime = null;
    }
  }

  public Boolean? DoNotDisplayPageBoundaries
  {
    get => _DocumentSettings?.DoNotDisplayPageBoundaries?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.DoNotDisplayPageBoundaries = new DXW.DoNotDisplayPageBoundaries { Val = value };
      else
        _ExistingSettings.DoNotDisplayPageBoundaries = null;
    }
  }

  public Boolean? DisplayBackgroundShape
  {
    get => _DocumentSettings?.DisplayBackgroundShape?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.DisplayBackgroundShape = new DXW.DisplayBackgroundShape { Val = value };
      else
        _ExistingSettings.DisplayBackgroundShape = null;
    }
  }

  public Boolean? PrintPostScriptOverText
  {
    get => _DocumentSettings?.PrintPostScriptOverText?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.PrintPostScriptOverText = new DXW.PrintPostScriptOverText { Val = value };
      else
        _ExistingSettings.PrintPostScriptOverText = null;
    }
  }

  public Boolean? PrintFractionalCharacterWidth
  {
    get => _DocumentSettings?.PrintFractionalCharacterWidth?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.PrintFractionalCharacterWidth = new DXW.PrintFractionalCharacterWidth { Val = value };
      else
        _ExistingSettings.PrintFractionalCharacterWidth = null;
    }
  }

  public Boolean? PrintFormsData
  {
    get => _DocumentSettings?.PrintFormsData?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.PrintFormsData = new DXW.PrintFormsData { Val = value };
      else
        _ExistingSettings.PrintFormsData = null;
    }
  }

  public Boolean? EmbedTrueTypeFonts
  {
    get => _DocumentSettings?.EmbedTrueTypeFonts?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.EmbedTrueTypeFonts = new DXW.EmbedTrueTypeFonts { Val = value };
      else
        _ExistingSettings.EmbedTrueTypeFonts = null;
    }
  }

  public Boolean? EmbedSystemFonts
  {
    get => _DocumentSettings?.EmbedSystemFonts?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.EmbedSystemFonts = new DXW.EmbedSystemFonts { Val = value };
      else
        _ExistingSettings.EmbedSystemFonts = null;
    }
  }

  public Boolean? SaveSubsetFonts
  {
    get => _DocumentSettings?.SaveSubsetFonts?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.SaveSubsetFonts = new DXW.SaveSubsetFonts { Val = value };
      else
        _ExistingSettings.SaveSubsetFonts = null;
    }
  }

  public Boolean? SaveFormsData
  {
    get => _DocumentSettings?.SaveFormsData?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.SaveFormsData = new DXW.SaveFormsData { Val = value };
      else
        _ExistingSettings.SaveFormsData = null;
    }
  }

  public Boolean? MirrorMargins
  {
    get => _DocumentSettings?.MirrorMargins?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.MirrorMargins = new DXW.MirrorMargins { Val = value };
      else
        _ExistingSettings.MirrorMargins = null;
    }
  }

  public Boolean? AlignBorderAndEdges
  {
    get => _DocumentSettings?.AlignBorderAndEdges?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.AlignBorderAndEdges = new DXW.AlignBorderAndEdges { Val = value };
      else
        _ExistingSettings.AlignBorderAndEdges = null;
    }
  }

  public Boolean? BordersDoNotSurroundHeader
  {
    get => _DocumentSettings?.BordersDoNotSurroundHeader?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.BordersDoNotSurroundHeader = new DXW.BordersDoNotSurroundHeader { Val = value };
      else
        _ExistingSettings.BordersDoNotSurroundHeader = null;
    }
  }

  public Boolean? BordersDoNotSurroundFooter
  {
    get => _DocumentSettings?.BordersDoNotSurroundFooter?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.BordersDoNotSurroundFooter = new DXW.BordersDoNotSurroundFooter { Val = value };
      else
        _ExistingSettings.BordersDoNotSurroundFooter = null;
    }
  }

  public Boolean? GutterAtTop
  {
    get => _DocumentSettings?.GutterAtTop?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.GutterAtTop = new DXW.GutterAtTop { Val = value };
      else
        _ExistingSettings.GutterAtTop = null;
    }
  }

  public Boolean? HideSpellingErrors
  {
    get => _DocumentSettings?.HideSpellingErrors?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.HideSpellingErrors = new DXW.HideSpellingErrors { Val = value };
      else
        _ExistingSettings.HideSpellingErrors = null;
    }
  }

  public Boolean? HideGrammaticalErrors
  {
    get => _DocumentSettings?.HideGrammaticalErrors?.Val?.AsBoolean();
    set
    {
      if (value != null)
        _ExistingSettings.HideGrammaticalErrors = new DXW.HideGrammaticalErrors { Val = value };
      else
        _ExistingSettings.HideGrammaticalErrors = null;
    }
  }

  public Boolean ForceUpgrade
  {
    get => _DocumentSettings?.Elements<DXW.ForceUpgrade>().FirstOrDefault() != null;
    set
    {
      if (value)
      {
        if (_ExistingSettings.Elements<DXW.ForceUpgrade>().FirstOrDefault() != null)
          return;
        else
          _ExistingSettings.AddChild(new DXW.ForceUpgrade());
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.ForceUpgrade>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
      }
    }
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
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.NoLineBreaksAfterKinsoku>().FirstOrDefault();
      if (setting == null)
        return null;
      return new NoBreakKinsoku { Lang = setting.Language, Val = setting.Val };
    }
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
          _ExistingSettings.AddChild(new DXW.NoLineBreaksAfterKinsoku { Language = value.Lang, Val = value.Val });
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.NoLineBreaksAfterKinsoku>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
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
          _ExistingSettings.AddChild(new DXW.NoLineBreaksBeforeKinsoku { Language = value.Lang, Val = value.Val });
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.NoLineBreaksBeforeKinsoku>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
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
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.DocumentProtection>().FirstOrDefault();
      if (setting == null)
        return null;
      return new DocumentProtection(setting);
    }
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.DocumentProtection>().FirstOrDefault();
        if (setting != null)
        {
          if (setting != value._Element)
          {
            setting.Remove();
            _ExistingSettings.AddChild(value._Element);
          }
        }
        else
          _ExistingSettings.AddChild(value._Element);
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.DocumentProtection>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
      }
    }
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
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.Captions>().FirstOrDefault();
      if (setting == null)
        return null;
      return new Captions(setting);
    }
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.Captions>().FirstOrDefault();
        if (setting != null)
        {
          if (setting != value._Element)
          {
            setting.Remove();
            _ExistingSettings.AddChild(value._Element);
          }
        }
        else
          _ExistingSettings.AddChild(value._Element);
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.Captions>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
      }
    }
  }


  /// <summary>
  /// This element specifies if the grammar and spell checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  public ProofState? ProofState
  {
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.ProofState>().FirstOrDefault();
      if (setting == null)
        return null;
      return new ProofState(setting);
    }
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.ProofState>().FirstOrDefault();
        if (setting != null)
        {
          if (setting != value._Element)
          {
            setting.Remove();
            _ExistingSettings.AddChild(value._Element);
          }
        }
        else
          _ExistingSettings.AddChild(value._Element);
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.ProofState>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
      }
    }
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
  public Zoom? Zoom
  {
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.Zoom>().FirstOrDefault();
      if (setting == null)
        return null;
      return new Zoom(setting);
    }
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.Zoom>().FirstOrDefault();
        if (setting != null)
        {
          if (setting != value._Element)
          {
            setting.Remove();
            _ExistingSettings.AddChild(value._Element);
          }
        }
        else
          _ExistingSettings.AddChild(value._Element);
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.Zoom>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
      }
    }
  }

  /// <summary>
  /// This element specifies if the grammar and spell checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of a the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get
    {
      if (_DocumentSettings == null)
        return null;
      var setting = _DocumentSettings?.Elements<DXW.StylePaneFormatFilter>().FirstOrDefault();
      if (setting == null)
        return null;
      return new StylePaneFormatFilter(setting);
    }
    set
    {
      if (value != null)
      {
        var setting = _ExistingSettings.Elements<DXW.StylePaneFormatFilter>().FirstOrDefault();
        if (setting != null)
        {
          if (setting != value._Element)
          {
            setting.Remove();
            _ExistingSettings.AddChild(value._Element);
          }
        }
        else
          _ExistingSettings.AddChild(value._Element);
      }
      else
      {
        var setting = _ExistingSettings.Elements<DXW.StylePaneFormatFilter>().FirstOrDefault();
        if (setting != null)
          setting.Remove();
        else
          return;
      }
    }
  }

  ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathProperties" /> <c>&lt;m:mathPr></c></description></item>
  ///   <item><description><see cref="DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary" /> <c>&lt;sl:schemaLibrary></c></description></item>
  ///   <item><description><see cref=" DXW.CharacterSpacingControl" /> <c>&lt;w:characterSpacingControl></c></description></item>
  ///   <item><description><see cref=" DXW.ColorSchemeMapping" /> <c>&lt;w:clrSchemeMapping></c></description></item>
  ///   <item><description><see cref=" DXW.Compatibility" /> <c>&lt;w:compat></c></description></item>
  ///   <item><description><see cref=" DXW.Rsids" /> <c>&lt;w:rsids></c></description></item>
  ///   <item><description><see cref=" DXW.DocumentType" /> <c>&lt;w:documentType></c></description></item>
  ///   <item><description><see cref=" DXW.DocumentVariables" /> <c>&lt;w:docVars></c></description></item>
  ///   <item><description><see cref=" DXW.EndnoteDocumentWideProperties" /> <c>&lt;w:endnotePr></c></description></item>
  ///   <item><description><see cref=" DXW.FootnoteDocumentWideProperties" /> <c>&lt;w:footnotePr></c></description></item>

  ///   <item><description><see cref=" DXW.ThemeFontLanguages" /> <c>&lt;w:themeFontLang></c></description></item>
  ///   <item><description><see cref=" DXW.MailMerge" /> <c>&lt;w:mailMerge></c></description></item>
  ///   <item><description><see cref=" DXW.DefaultTabStop" /> <c>&lt;w:defaultTabStop></c></description></item>
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
  ///   <item><description><see cref=" DXW.HyphenationZone" /> <c>&lt;w:hyphenationZone></c></description></item>
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


