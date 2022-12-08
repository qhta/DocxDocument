namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public class SettingsImpl: ModelElementImpl, Settings
{
  public DocumentFormat.OpenXml.Wordprocessing.Settings? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Settings?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Write Protection.
  /// </summary>
  public WriteProtection? WriteProtection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public ViewKind? View
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
        return (ViewKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.ViewValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.View{ Val = (DocumentFormat.OpenXml.Wordprocessing.ViewValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public Zoom? Zoom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public Boolean? RemovePersonalInformation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public Boolean? RemoveDateAndTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public Boolean? DoNotDisplayPageBoundaries
  {
    get;
    set;
  }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public Boolean? DisplayBackgroundShape
  {
    get;
    set;
  }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public Boolean? PrintPostScriptOverText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public Boolean? PrintFractionalCharacterWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public Boolean? PrintFormsData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public Boolean? EmbedTrueTypeFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public Boolean? EmbedSystemFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public Boolean? SaveSubsetFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public Boolean? SaveFormsData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public Boolean? MirrorMargins
  {
    get;
    set;
  }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public Boolean? AlignBorderAndEdges
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public Boolean? BordersDoNotSurroundHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public Boolean? BordersDoNotSurroundFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public Boolean? GutterAtTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public Boolean? HideSpellingErrors
  {
    get;
    set;
  }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public Boolean? HideGrammaticalErrors
  {
    get;
    set;
  }
  
  public Collection<ActiveWritingStyle>? ActiveWritingStyles
  {
    get;
    set;
  }
  
  public ProofState? ProofState
  {
    get;
    set;
  }
  
  public Boolean? FormsDesign
  {
    get;
    set;
  }
  
  public RelationshipType? AttachedTemplate
  {
    get;
    set;
  }
  
  public Boolean? LinkStyles
  {
    get;
    set;
  }
  
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get;
    set;
  }
  
  public String? StylePaneSortMethods
  {
    get;
    set;
  }
  
  public DocumentKind? DocumentType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
        return (DocumentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DocumentType{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public MailMerge? MailMerge
  {
    get;
    set;
  }
  
  public RevisionView? RevisionView
  {
    get;
    set;
  }
  
  public Boolean? TrackRevisions
  {
    get;
    set;
  }
  
  public Boolean? DoNotTrackMoves
  {
    get;
    set;
  }
  
  public Boolean? DoNotTrackFormatting
  {
    get;
    set;
  }
  
  public DocumentProtection? DocumentProtection
  {
    get;
    set;
  }
  
  public Boolean? AutoFormatOverride
  {
    get;
    set;
  }
  
  public Int16? DefaultTabStop
  {
    get;
    set;
  }
  
  public Boolean? AutoHyphenation
  {
    get;
    set;
  }
  
  public UInt16? ConsecutiveHyphenLimit
  {
    get;
    set;
  }
  
  public String? HyphenationZone
  {
    get;
    set;
  }
  
  public Boolean? DoNotHyphenateCaps
  {
    get;
    set;
  }
  
  public Boolean? ShowEnvelope
  {
    get;
    set;
  }
  
  public Int32? SummaryLength
  {
    get;
    set;
  }
  
  public String? ClickAndTypeStyle
  {
    get;
    set;
  }
  
  public String? DefaultTableStyle
  {
    get;
    set;
  }
  
  public Boolean? EvenAndOddHeaders
  {
    get;
    set;
  }
  
  public Boolean? BookFoldReversePrinting
  {
    get;
    set;
  }
  
  public Boolean? BookFoldPrinting
  {
    get;
    set;
  }
  
  public Int16? BookFoldPrintingSheets
  {
    get;
    set;
  }
  
  public String? DrawingGridHorizontalSpacing
  {
    get;
    set;
  }
  
  public String? DrawingGridVerticalSpacing
  {
    get;
    set;
  }
  
  public Int32? DisplayHorizontalDrawingGrid
  {
    get;
    set;
  }
  
  public Int32? DisplayVerticalDrawingGrid
  {
    get;
    set;
  }
  
  public Boolean? DoNotUseMarginsForDrawingGridOrigin
  {
    get;
    set;
  }
  
  public String? DrawingGridHorizontalOrigin
  {
    get;
    set;
  }
  
  public String? DrawingGridVerticalOrigin
  {
    get;
    set;
  }
  
  public Boolean? DoNotShadeFormData
  {
    get;
    set;
  }
  
  public Boolean? NoPunctuationKerning
  {
    get;
    set;
  }
  
  public CharacterSpacingKind? CharacterSpacingControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
        return (CharacterSpacingKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl{ Val = (DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? PrintTwoOnOne
  {
    get;
    set;
  }
  
  public Boolean? StrictFirstAndLastChars
  {
    get;
    set;
  }
  
  public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku
  {
    get;
    set;
  }
  
  public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku
  {
    get;
    set;
  }
  
  public Boolean? SavePreviewPicture
  {
    get;
    set;
  }
  
  public Boolean? DoNotValidateAgainstSchema
  {
    get;
    set;
  }
  
  public Boolean? SaveInvalidXml
  {
    get;
    set;
  }
  
  public Boolean? IgnoreMixedContent
  {
    get;
    set;
  }
  
  public Boolean? AlwaysShowPlaceholderText
  {
    get;
    set;
  }
  
  public Boolean? DoNotDemarcateInvalidXml
  {
    get;
    set;
  }
  
  public Boolean? SaveXmlDataOnly
  {
    get;
    set;
  }
  
  public Boolean? UseXsltWhenSaving
  {
    get;
    set;
  }
  
  public SaveThroughXslt? SaveThroughXslt
  {
    get;
    set;
  }
  
  public Boolean? ShowXmlTags
  {
    get;
    set;
  }
  
  public Boolean? AlwaysMergeEmptyNamespace
  {
    get;
    set;
  }
  
  public Boolean? UpdateFieldsOnOpen
  {
    get;
    set;
  }
  
  public HeaderShapeDefaults? HeaderShapeDefaults
  {
    get;
    set;
  }
  
  public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get;
    set;
  }
  
  public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get;
    set;
  }
  
  public Compatibility? Compatibility
  {
    get;
    set;
  }
  
  public DocumentVariables? DocumentVariables
  {
    get;
    set;
  }
  
  public Rsids? Rsids
  {
    get;
    set;
  }
  
  public DocumentModel.Math.MathProperties? MathProperties
  {
    get;
    set;
  }
  
  public Boolean? UICompatibleWith97To2003
  {
    get;
    set;
  }
  
  public Collection<String>? AttachedSchemas
  {
    get;
    set;
  }
  
  public LanguageType? ThemeFontLanguages
  {
    get;
    set;
  }
  
  public ColorSchemeMapping? ColorSchemeMapping
  {
    get;
    set;
  }
  
  public Boolean? DoNotIncludeSubdocsInStats
  {
    get;
    set;
  }
  
  public Boolean? DoNotAutoCompressPictures
  {
    get;
    set;
  }
  
  public Boolean? ForceUpgrade
  {
    get;
    set;
  }
  
  public Captions? Captions
  {
    get;
    set;
  }
  
  public ReadModeInkLockDown? ReadModeInkLockDown
  {
    get;
    set;
  }
  
  public DocumentModel.CustomXml.SchemaLibrary? SchemaLibrary
  {
    get;
    set;
  }
  
  public ShapeDefaults? ShapeDefaults
  {
    get;
    set;
  }
  
  public String? DecimalSymbol
  {
    get;
    set;
  }
  
  public String? ListSeparator
  {
    get;
    set;
  }
  
  public DocumentModel.HexBinaryValue? DocumentId
  {
    get;
    set;
  }
  
  public OnOffKind? DiscardImageEditingData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
        return (OnOffKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Int32? DefaultImageDpi
  {
    get;
    set;
  }
  
  public OnOffKind? ConflictMode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
        return (OnOffKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.ConflictMode{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? ChartTrackingRefBased
  {
    get;
    set;
  }
  
  public String? PersistentDocumentId
  {
    get;
    set;
  }
  
}
