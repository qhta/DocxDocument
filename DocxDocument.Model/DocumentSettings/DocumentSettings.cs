using System.Runtime.CompilerServices;

using DocumentFormat.OpenXml.Spreadsheet;

namespace DocxDocument.Model;

public class DocumentSettings : IDocumentSettings, IEnumerable<KeyValuePair<string, object>> 
{
  [XmlIgnore]
  [JsonIgnore]
  public Document Document { get; set; } = null!;

  private Dictionary<string, object> Items = new();

  private void _Set(object? value, [CallerMemberName] string name = null!)
  {
    Set(name, value);
  }

  private object? _Get([CallerMemberName] string name = null!)
  {
    return Get(name);
  }

  private void Set(string name, object? value)
  {
    if (Items.ContainsKey(name))
    {
      if (value == null)
      {
        Items.Remove(name);
      }
      else
      {
        Items[name] = value;
      }
    }
    if (value !=null)
      Items.Add(name, value);
  }

  public object? Get(string name)
  {
    if (!Items.ContainsKey(name))
      return null;
    return Items[name];
  }

  #region Automation settings

  /// <summary> 
  /// Do Not Include Content in Text Boxes, Footnotes, and Endnotes in Document Statistics
  ///</summary> 
  public bool? DoNotIncludeSubdocsInStats
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Generate Thumbnail For Document On Save
  ///</summary> 
  public bool? SavePreviewPicture
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Percentage of Document to Use When Generating Summary
  ///</summary> 
  public Percentage? SummaryLength
  {
    get => (Percentage?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Change Tracking settings
  /// <summary> 
  /// Track Revisions to Document
  ///</summary> 
  public bool? TrackRevisions
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Track Formatting Revisions When Tracking Revisions
  ///</summary> 
  public bool? DoNotTrackFormatting
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Use Move Syntax When Tracking Revisions
  ///</summary> 
  public bool? DoNotTrackMoves
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Visibility of Annotation Types
  ///</summary> 
  public RevisionView? RevisionView
  {
    get => (RevisionView?)_Get();
    set => _Set(value);
  }
  #endregion

  #region Character Spacing settings
  /// <summary> 
  /// Character-Level Whitespace Compression
  ///</summary> 
  public CharacterSpacing? CharacterSpacingControl
  {
    get => (CharacterSpacing?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Never Kern Punctuation Characters
  ///</summary> 
  public bool? NoPunctuationKerning
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Compatibility settings

  /// <summary> 
  /// Compatibility settings
  ///</summary> 
  public ICompatibilitySettings? Compatibility
  {
    get => (ICompatibilitySettings?)_Get();
    set => _Set(value);
  }
  /// <summary> 
  /// Upgrade Document on Open to Newest Application Version
  ///</summary> 
  public bool? ForceUpgrade
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Custom XML settings

  /// <summary> 
  /// Do Not Mark Custom XML Elements With No Namespace As Invalid
  ///</summary> 
  public bool? AlwaysMergeEmptyNamespace
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Use Custom XML Element Names as Default Placeholder Text
  ///</summary> 
  public bool? AlwaysShowPlaceholderText
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Show Visual Indicators for Custom XML Markup Start/End Locations
  ///</summary> 
  public bool? ShowXmlTags
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Show Visual Indicator For Invalid Custom XML Markup
  ///</summary> 
  public bool? DoNotDemarcateInvalidXml
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Validate Custom XML Markup Against Schemas
  ///</summary> 
  public bool? DoNotValidateAgainstSchema
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Ignore Mixed Content When Validating Custom XML Markup
  ///</summary> 
  public bool? IgnoreMixedContent
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Allow Saving Document As XML File When Custom XML Markup Is Invalid
  ///</summary> 
  public bool? SaveInvalidXml
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Only Save Custom XML Markup
  ///</summary> 
  public bool? SaveXmlDataOnly
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Save Document as XML File through Custom XSL Transform
  ///</summary> 
  public bool? UseXsltWhenSaving
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Custom XSL Transform To Use When Saving As XML File
  ///</summary> 
  public string? SaveThroughXslt 
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Local Identifier for XSL Transform.
  ///</summary> 
  public string? SolutionId 
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Attached Custom XML Schema
  ///</summary> 
  public string? AttachedSchema 
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Embedded Custom XML Schema Supplementary Data
  ///</summary> 
  public ISchemaLibrary? SchemaLibrary 
  {
    get => (ISchemaLibrary?)_Get();
    set => _Set(value);
  }

  #endregion

  #region DisplayGrid settings

  /// <summary> 
  /// Drawing Grid Horizontal Origin Point
  ///</summary> 
  public Twips? DrawingGridHorizontalOrigin 
  {
    get => (Twips?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Drawing Grid Horizontal Grid Unit Size
  ///</summary> 
  public Twips? DrawingGridHorizontalSpacing 
  {
    get => (Twips?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Drawing Grid Vertical Origin Point
  ///</summary> 
  public Twips? DrawingGridVerticalOrigin 
  {
    get => (Twips?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Drawing Grid Vertical Grid Unit Size
  ///</summary> 
  public Twips? DrawingGridVerticalSpacing 
  {
    get => (Twips?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Distance between Horizontal Gridlines
  ///</summary> 
  public int? DisplayHorizontalDrawingGridEvery
  {
    get => (int?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Distance between Vertical Gridlines
  ///</summary> 
  public int? DisplayVerticalDrawingGridEvery
  {
    get => (int?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Use Margins for Drawing Grid Origin
  ///</summary> 
  public bool? DoNotUseMarginsForDrawingGridOrigin
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Mailing settings

  /// <summary> 
  /// Document Classification
  ///</summary> 
  public MailingType? DocumentType
  {
    get => (MailingType?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Show E-Mail Message Header
  ///</summary> 
  public bool? ShowEnvelope
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Mail Merge Settings
  ///</summary> 
  public IMailMergeSettings? MailMerge
  {
    get => (IMailMergeSettings?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Field evaluation

  /// <summary> 
  /// Radix Point for Field Code Evaluation
  ///</summary> 
  public string? DecimalSymbol
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// List Separator for Field Code Evaluation
  ///</summary> 
  public string? ListSeparator
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Automatically Recalculate Fields on Open
  ///</summary> 
  public bool? UpdateFields
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Forms settings

  /// <summary> 
  /// Do Not Show Visual Indicator For Form Fields
  ///</summary> 
  public bool? DoNotShadeFormData
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Only Save Form Field Content
  ///</summary> 
  public bool? SaveFormsData
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Structured Document Tag Placeholder Text Should be Resaved
  ///</summary> 
  public bool? FormsDesign
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Embed Fonts settings

  /// <summary> 
  /// Subset Fonts When Embedding
  ///</summary> 
  public bool? SaveSubsetFonts
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Embed Common System Fonts
  ///</summary> 
  public bool? EmbedSystemFonts
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Embed TrueType Fonts
  ///</summary> 
  public bool? EmbedTrueTypeFonts
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Images settings

  /// <summary> 
  /// Do Not Automatically Compress Images
  ///</summary> 
  public bool? DoNotAutoCompressPictures
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// This setting is ignored by images that have dots per inch (DPI) specified by useLocalDpi .
  /// This setting is also ignored when doNotAutoCompressPictures is set to true.
  ///</summary> 
  public int? DefaultImageDpi
  {
    get => (int?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// When true, the cropped-out areas of the images are not to be saved.
  /// Rather, the images saved are the results of applying imgProps on the original images. 
  ///</summary> 
  public bool? DiscardImageEditingData
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Hyphenation settings

  /// <summary> 
  /// Automatically Hyphenate Document Contents When Displayed
  ///</summary> 
  public bool? AutoHyphenation
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Hyphenate Words in ALL CAPITAL LETTERS
  ///</summary> 
  public bool? DoNotHyphenateCaps
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Maximum Number of Consecutively Hyphenated Lines
  ///</summary> 
  public int? ConsecutiveHyphenLimit
  {
    get => (int?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Kinsoku line breaking settings

  /// <summary> 
  /// Use Strict Kinsoku Rules for Japanese Text
  ///</summary> 
  public bool? StrictFirstAndLastChars
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Custom Set of Characters Which Cannot End a Line
  ///</summary> 
  public LangText? NoLineBreaksAfter
  {
    get => (LangText?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Custom Set Of Characters Which Cannot Begin A Line
  ///</summary> 
  public LangText? NoLineBreaksBefore
  {
    get => (LangText?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Layout settings

  /// <summary> 
  /// Mirror Page Margins
  ///</summary> 
  public bool? MirrorMargins
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Different Even/Odd Page Headers and Footers
  ///</summary> 
  public bool? EvenAndOddHeaders
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Page Border Excludes Footer
  ///</summary> 
  public bool? BordersDoNotSurroundFooter
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Page Border Excludes Header
  ///</summary> 
  public bool? BordersDoNotSurroundHeader
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Align Paragraph and Table Borders with Page Border
  ///</summary> 
  public bool? AlignBorderAndEdges
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Display Background Objects When Displaying Document
  ///</summary> 
  public bool? DisplayBackgroundShape
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Position Gutter At Top of Page
  ///</summary> 
  public bool? GutterAtTop
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Distance Between Automatic Tab Stops
  ///</summary> 
  public Twips? DefaultTabStop
  {
    get => (Twips?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Freeze Document Layout
  ///</summary> 
  public ReadModeInkLockDown? ReadModeInkLockDown
  {
    get => (ReadModeInkLockDown?)_Get();
    set => _Set(value);
  }
  #endregion

  #region Printing settings

  /// <summary> 
  /// Only Print Form Field Content
  ///</summary> 
  public bool? PrintFormsData
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Print Fractional Character Widths
  ///</summary> 
  public bool? PrintFractionalCharacterWidth
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Print PostScript Codes With Document Text
  ///</summary> 
  public bool? PrintPostScriptOverText
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Print Two Pages Per Sheet
  ///</summary> 
  public bool? PrintTwoOnOne
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Book Fold Printing
  ///</summary> 
  public bool? BookFoldPrinting
  {
    get => (bool?)_Get();
    set => _Set(value);
  }
  /// <summary> 
  /// Reverse Book Fold Printing
  ///</summary> 
  public bool? GetBookFoldReversePrinting
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Number of Pages Per Booklet
  ///</summary> 
  public int? BookFoldPrintingSheets
  {
    get => (int?)_Get();
    set => _Set(value);
  }
  #endregion

  #region Proofing settings

  /// <summary> 
  /// Grammar Checking Settings
  ///</summary> 
  public IWritingStyle? ActiveWritingStyle
  {
    get => (IWritingStyle?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Display Visual Indication of Grammatical Errors
  ///</summary> 
  public bool? HideGrammaticalErrors
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Do Not Display Visual Indication of Spelling Errors
  ///</summary> 
  public bool? HideSpellingErrors
  {
    get => (bool?)_Get();
    set => _Set(value);
  }


  /// <summary> 
  /// Spelling and Grammatical Checking State
  ///</summary> 
  public ProofState? ProofState
  {
    get => (ProofState?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Document Protection settings

  /// <summary> 
  /// Document Editing Restrictions
  ///</summary> 
  public IDocumentProtection? DocumentProtection
  {
    get => (IDocumentProtection?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Write Protection
  ///</summary> 
  public IWriteProtection? WriteProtection
  {
    get => (IWriteProtection?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Remove Date and Time from Annotations
  ///</summary> 
  public bool? RemoveDateAndTime
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Remove Personal Information from Document Properties
  ///</summary> 
  public bool? RemovePersonalInformation
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Allow Automatic Formatting to Override Formatting Protection Settings
  ///</summary> 
  public bool? AutoFormatOverride
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Style and Theme settings

  /// <summary> 
  /// Prevent Replacement of Styles Part
  ///</summary> 
  public bool? GetStyleLockStylesPart
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Prevent Modification of Themes Part
  ///</summary> 
  public bool? StyleLockThemesPart
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Paragraph Style Applied to Automatically Generated Paragraphs
  ///</summary> 
  public string? ClickAndTypeStyle
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Default Table Style for Newly Inserted Tables
  ///</summary> 
  public string? DefaultTableStyle
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Automatically Update Styles From Document Template
  ///</summary> 
  public bool? LinkStyles
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Attached Document Template
  ///</summary> 
  public string? AttachedTemplate
  {
    get => (string?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Theme Color Mappings
  ///</summary> 
  public IColorSchemeMapping? ColorSchemeMapping
  {
    get => (ColorSchemeMapping?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Theme Font Languages
  ///</summary> 
  public IScriptTypeLanguage? ThemeFontLanguages
  {
    get => (IScriptTypeLanguage?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Suggested Filtering for List of Document Styles
  ///</summary> 
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get => (StylePaneFormatFilter?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Suggested Sorting for List of Document Styles
  ///</summary> 
  public StylePaneSortMethods? StylePaneSortMethods
  {
    get => (StylePaneSortMethods?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Document View settings

  /// <summary> 
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages
  ///</summary> 
  public bool? DoNotDisplayPageBoundaries
  {
    get => (bool?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Document View Setting
  ///</summary> 
  public DocView? View
  {
    get => (DocView?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Magnification Setting
  ///</summary> 
  public Zoom? Zoom
  {
    get => (Zoom?)_Get();
    set => _Set(value);
  }

  #endregion

  #region Other settings

  /// <summary> 
  /// Caption Settings
  ///</summary> 
  public ICaptions? Captions
  {
    get => (ICaptions?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Document Variables
  ///</summary> 
  public IDocumentVariables? DocumentVariables
  {
    get => (IDocumentVariables?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Document-Wide Endnote Properties
  ///</summary> 
  public IEndnoteProperties? EndnoteDocumentWideProperties
  {
    get => (IEndnoteProperties?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Document-Wide Footnote Properties
  ///</summary> 
  public IFootnoteProperties? FootnoteDocumentWideProperties
  {
    get => (IFootnoteProperties?)_Get();
    set => _Set(value);
  }

  /// <summary> 
  /// Math Properties
  ///</summary> 
  public IMathProperties? MathProperties
  {
    get => (IMathProperties?)_Get();
    set => _Set(value);
  }

  #endregion

  public bool IsEmpty()
  {
    foreach (var propInfo in this.GetType().GetProperties())
      if (propInfo.GetCustomAttribute<XmlIgnoreAttribute>() == null && propInfo.GetValue(this, null) != null)
        return false;
    return true;
  }

  public int Count => Items.Count;


  public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}