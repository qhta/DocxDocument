namespace DocxDocument.Model;

public interface IDocumentSettings
{
  //DocumentFormat.OpenXml.Wordprocessing.Settings

  #region Automation settings
  /// <summary> 
  /// Do Not Include Content in Text Boxes, Footnotes, and Endnotes in Document Statistics
  ///</summary> 
  public bool? DoNotIncludeSubdocsInStats { get; set; }

  /// <summary> 
  /// Generate Thumbnail For Document On Save
  ///</summary> 
  public bool? SavePreviewPicture { get; set; }

  /// <summary> 
  /// Percentage of Document to Use When Generating Summary
  ///</summary> 
  public Percentage? SummaryLength { get; set; }

  #endregion

  #region Change Tracking settings
  /// <summary> 
  /// Track Revisions to Document
  ///</summary> 
  public bool? TrackRevisions { get; set; }
  /// <summary> 
  /// Do Not Track Formatting Revisions When Tracking Revisions
  ///</summary> 
  public bool? DoNotTrackFormatting { get; set; }

  /// <summary> 
  /// Do Not Use Move Syntax When Tracking Revisions
  ///</summary> 
  public bool? DoNotTrackMoves { get; set; }

  /// <summary> 
  /// Visibility of Annotation Types
  ///</summary> 
  public RevisionView? RevisionView { get; set; }
  #endregion

  #region Character Spacing settings
  /// <summary> 
  /// Character-Level Whitespace Compression
  ///</summary> 
  public DM.CharacterSpacing? CharacterSpacingControl { get; set; }

  /// <summary> 
  /// Never Kern Punctuation Characters
  ///</summary> 
  public bool? NoPunctuationKerning { get; set; }

  #endregion

  #region Compatibility settings

  /// <summary> 
  /// Compatibility settings
  ///</summary> 
  public ICompatibilitySettings? Compatibility { get; set; }

  /// <summary> 
  /// Upgrade Document on Open to Newest Application Version
  ///</summary> 
  public bool? ForceUpgrade { get; set; }

  #endregion

  #region Custom XML settings

  /// <summary> 
  /// Do Not Mark Custom XML Elements With No Namespace As Invalid
  ///</summary> 
  public bool? AlwaysMergeEmptyNamespace { get; set; }

  /// <summary> 
  /// Use Custom XML Element Names as Default Placeholder Text
  ///</summary> 
  public bool? AlwaysShowPlaceholderText { get; set; }

  /// <summary> 
  /// Show Visual Indicators for Custom XML Markup Start/End Locations
  ///</summary> 
  public bool? ShowXmlTags { get; set; }

  /// <summary> 
  /// Do Not Show Visual Indicator For Invalid Custom XML Markup
  ///</summary> 
  public bool? DoNotDemarcateInvalidXml { get; set; }

  /// <summary> 
  /// Do Not Validate Custom XML Markup Against Schemas
  ///</summary> 
  public bool? DoNotValidateAgainstSchema { get; set; }

  /// <summary> 
  /// Ignore Mixed Content When Validating Custom XML Markup
  ///</summary> 
  public bool? IgnoreMixedContent { get; set; }

  /// <summary> 
  /// Allow Saving Document As XML File When Custom XML Markup Is Invalid
  ///</summary> 
  public bool? SaveInvalidXml { get; set; }

  /// <summary> 
  /// Only Save Custom XML Markup
  ///</summary> 
  public bool? SaveXmlDataOnly { get; set; }

  /// <summary> 
  /// Save Document as XML File through Custom XSL Transform
  ///</summary> 
  public bool? UseXsltWhenSaving { get; set; }

  /// <summary> 
  /// Custom XSL Transform To Use When Saving As XML File
  ///</summary> 
  public ISaveThroughXslt? SaveThroughXslt { get; set; }

  /// <summary> 
  /// Attached Custom XML Schema
  ///</summary> 
  public string? AttachedSchema { get; set; }

  /// <summary> 
  /// Embedded Custom XML Schema Supplementary Data
  ///</summary> 
  public ISchemaLibrary? SchemaLibrary { get; set; }

  #endregion

  #region DisplayGrid settings

  /// <summary> 
  /// Drawing Grid Horizontal Origin Point
  ///</summary> 
  public Twips? DrawingGridHorizontalOrigin { get; set; }

  /// <summary> 
  /// Drawing Grid Horizontal Grid Unit Size
  ///</summary> 
  public Twips? DrawingGridHorizontalSpacing { get; set; }

  /// <summary> 
  /// Drawing Grid Vertical Origin Point
  ///</summary> 
  public Twips? DrawingGridVerticalOrigin { get; set; }

  /// <summary> 
  /// Drawing Grid Vertical Grid Unit Size
  ///</summary> 
  public Twips? DrawingGridVerticalSpacing { get; set; }

  /// <summary> 
  /// Distance between Horizontal Gridlines
  ///</summary> 
  public int? DisplayHorizontalDrawingGrid { get; set; }

  /// <summary> 
  /// Distance between Vertical Gridlines
  ///</summary> 
  public int? DisplayVerticalDrawingGrid { get; set; }

  /// <summary> 
  /// Do Not Use Margins for Drawing Grid Origin
  ///</summary> 
  public bool? DoNotUseMarginsForDrawingGridOrigin { get; set; }

  #endregion

  #region Mailing settings

  /// <summary> 
  /// Document Classification
  ///</summary> 
  public DM.MailMergeDocumentType? DocumentType { get; set; }
  
  /// <summary> 
  /// Show E-Mail Message Header
  ///</summary> 
  public bool? ShowEnvelope { get; set; }

  /// <summary> 
  /// Mail Merge Settings
  ///</summary> 
  public IMailMergeSettings? MailMerge { get; set; }

  #endregion

  #region Field evaluation

  /// <summary> 
  /// Radix Point for Field Code Evaluation
  ///</summary> 
  public string? DecimalSymbol { get; set; }

  /// <summary> 
  /// List Separator for Field Code Evaluation
  ///</summary> 
  public string? ListSeparator { get; set; }

  /// <summary> 
  /// Automatically Recalculate Fields on Open
  ///</summary> 
  public bool? UpdateFieldsOnOpen { get; set; }

  #endregion

  #region Forms settings

  /// <summary> 
  /// Do Not Show Visual Indicator For Form Fields
  ///</summary> 
  public bool? DoNotShadeFormData { get; set; }

  /// <summary> 
  /// Only Save Form Field Content
  ///</summary> 
  public bool? SaveFormsData { get; set; }

  /// <summary> 
  /// Structured Document Tag Placeholder Text Should be Resaved
  ///</summary> 
  public bool? FormsDesign { get; set; }

  #endregion

  #region Embed Fonts settings

  /// <summary> 
  /// Subset Fonts When Embedding
  ///</summary> 
  public bool? SaveSubsetFonts { get; set; }

  /// <summary> 
  /// Embed Common System Fonts
  ///</summary> 
  public bool? EmbedSystemFonts { get; set; }

  /// <summary> 
  /// Embed TrueType Fonts
  ///</summary> 
  public bool? EmbedTrueTypeFonts { get; set; }

  #endregion

  #region Images settings

  /// <summary> 
  /// Do Not Automatically Compress Images
  ///</summary> 
  public bool? DoNotAutoCompressPictures { get; set; }

  /// <summary> 
  /// This setting is ignored by images that have dots per inch (DPI) specified by useLocalDpi .
  /// This setting is also ignored when doNotAutoCompressPictures is set to true.
  ///</summary> 
  public int? DefaultImageDpi { get; set; }

  /// <summary> 
  /// When true, the cropped-out areas of the images are not to be saved.
  /// Rather, the images saved are the results of applying imgProps on the original images. 
  ///</summary> 
  public bool? DiscardImageEditingData { get; set; }

  #endregion

  #region Hyphenation settings

  /// <summary> 
  /// Automatically Hyphenate Document Contents When Displayed
  ///</summary> 
  public bool? AutoHyphenation { get; set; }

  /// <summary> 
  /// Do Not Hyphenate Words in ALL CAPITAL LETTERS
  ///</summary> 
  public bool? DoNotHyphenateCaps { get; set; }

  /// <summary> 
  /// Maximum Number of Consecutively Hyphenated Lines
  ///</summary> 
  public int? ConsecutiveHyphenLimit { get; set; }

  /// <summary>
  /// This element specifies the hyphenation zone which shall be used when automatically or manually hyphenating the contents of this document.
  /// The hyphenation zone is the amount of whitespace which can be left at the end of a line (or added to justified lines)
  /// before hyphenation should be attempted on the next word in the document (in order to reduce the amount of whitespace on the line).
  /// A smaller hyphenation zone should reduce the raggedness of the right edge of a given document's body text, as more words is hyphenated.
  /// Conversely, a larger hyphenation zone should increase the raggedness of the right edge of a given document's text, as fewer words is hyphenated.
  /// </summary>
  public Twips? HyphenationZone { get; set; }


  #endregion

  #region Kinsoku line breaking settings

  /// <summary> 
  /// Use Strict Kinsoku Rules for Japanese Text
  ///</summary> 
  public bool? StrictFirstAndLastChars { get; set; }

  /// <summary> 
  /// Custom Set of Characters Which Cannot End a Line
  ///</summary> 
  public LangText? NoLineBreaksAfter { get; set; }

  /// <summary> 
  /// Custom Set Of Characters Which Cannot Begin A Line
  ///</summary> 
  public LangText? NoLineBreaksBefore { get; set; }

  #endregion

  #region Layout settings

  /// <summary> 
  /// Mirror Page Margins
  ///</summary> 
  public bool? MirrorMargins { get; set; }

  /// <summary> 
  /// Different Even/Odd Page Headers and Footers
  ///</summary> 
  public bool? EvenAndOddHeaders { get; set; }

  /// <summary> 
  /// Page Border Excludes Footer
  ///</summary> 
  public bool? BordersDoNotSurroundFooter { get; set; }

  /// <summary> 
  /// Page Border Excludes Header
  ///</summary> 
  public bool? BordersDoNotSurroundHeader { get; set; }

  /// <summary> 
  /// Align Paragraph and Table Borders with Page Border
  ///</summary> 
  public bool? AlignBorderAndEdges { get; set; }

  /// <summary> 
  /// Display Background Objects When Displaying Document
  ///</summary> 
  public bool? DisplayBackgroundShape { get; set; }

  /// <summary> 
  /// Position Gutter At Top of Page
  ///</summary> 
  public bool? GutterAtTop { get; set; }

  /// <summary> 
  /// Distance Between Automatic Tab Stops
  ///</summary> 
  public Twips? DefaultTabStop { get; set; }

  /// <summary> 
  /// Freeze Document Layout
  ///</summary> 
  public IReadModeInkLockDown? ReadModeInkLockDown { get; set; }
  #endregion

  #region Printing settings

  /// <summary> 
  /// Only Print Form Field Content
  ///</summary> 
  public bool? PrintFormsData { get; set; }

  /// <summary> 
  /// Print Fractional Character Widths
  ///</summary> 
  public bool? PrintFractionalCharacterWidth { get; set; }

  /// <summary> 
  /// Print PostScript Codes With Document Text
  ///</summary> 
  public bool? PrintPostScriptOverText { get; set; }

  /// <summary> 
  /// Print Two Pages Per Sheet
  ///</summary> 
  public bool? PrintTwoOnOne { get; set; }

  /// <summary> 
  /// Book Fold Printing
  ///</summary> 
  public bool? BookFoldPrinting { get; set; }
  /// <summary> 
  /// Reverse Book Fold Printing
  ///</summary> 
  public bool? BookFoldReversePrinting { get; set; }

  /// <summary> 
  /// Number of Pages Per Booklet
  ///</summary> 
  public int? BookFoldPrintingSheets { get; set; }
  #endregion

  #region Proofing settings

  /// <summary> 
  /// Grammar Checking Settings
  ///</summary> 
  public IWritingStyle? ActiveWritingStyle { get; set; }

  /// <summary> 
  /// Do Not Display Visual Indication of Grammatical Errors
  ///</summary> 
  public bool? HideGrammaticalErrors { get; set; }

  /// <summary> 
  /// Do Not Display Visual Indication of Spelling Errors
  ///</summary> 
  public bool? HideSpellingErrors { get; set; }


  /// <summary> 
  /// Spelling and Grammatical Checking State
  ///</summary> 
  public DM.ProofState? ProofState { get; set; }

  #endregion

  #region Document Protection settings

  /// <summary> 
  /// Document Editing Restrictions
  ///</summary> 
  public IDocumentProtection? DocumentProtection { get; set; }

  /// <summary> 
  /// Write Protection
  ///</summary> 
  public IWriteProtection? WriteProtection { get; set; }

  /// <summary> 
  /// Remove Date and Time from Annotations
  ///</summary> 
  public bool? RemoveDateAndTime { get; set; }

  /// <summary> 
  /// Remove Personal Information from Document Properties
  ///</summary> 
  public bool? RemovePersonalInformation { get; set; }

  /// <summary> 
  /// Allow Automatic Formatting to Override Formatting Protection Settings
  ///</summary> 
  public bool? AutoFormatOverride { get; set; }

  #endregion

  #region Style and Theme settings

  /// <summary> 
  /// Prevent Replacement of Styles Part
  ///</summary> 
  public bool? StyleLockStylesPart { get; set; }

  /// <summary> 
  /// Prevent Modification of Themes Part
  ///</summary> 
  public bool? StyleLockThemesPart { get; set; }

  /// <summary> 
  /// Paragraph Style Applied to Automatically Generated Paragraphs
  ///</summary> 
  public string? ClickAndTypeStyle { get; set; }

  /// <summary> 
  /// Default Table Style for Newly Inserted Tables
  ///</summary> 
  public string? DefaultTableStyle { get; set; }

  /// <summary> 
  /// Automatically Update Styles From Document Template
  ///</summary> 
  public bool? LinkStyles { get; set; }

  /// <summary> 
  /// Attached Document Template
  ///</summary> 
  public Relationship? AttachedTemplate { get; set; }

  /// <summary> 
  /// Theme Color Mappings
  ///</summary> 
  public IColorSchemeMapping? ColorSchemeMapping { get; set; }

  /// <summary> 
  /// Theme Font Languages
  ///</summary> 
  public IScriptTypeLanguage? ThemeFontLanguages { get; set; }

  /// <summary> 
  /// Suggested Filtering for List of Document Styles
  ///</summary> 
  public StylePaneFormatFilter? StylePaneFormatFilter { get; set; }

  /// <summary> 
  /// Suggested Sorting for List of Document Styles
  ///</summary> 
  public DM.StylePaneSortMethods? StylePaneSortMethods { get; set; }

  #endregion

  #region Document View settings

  /// <summary> 
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages
  ///</summary> 
  public bool? DoNotDisplayPageBoundaries { get; set; }

  /// <summary> 
  /// Document View Setting
  ///</summary> 
  public DM.DocView? View { get; set; }

  /// <summary> 
  /// Magnification Setting
  ///</summary> 
  public IZoom? Zoom { get; set; }

  #endregion

  #region Other settings

  /// <summary> 
  /// Caption Settings
  ///</summary> 
  public ICaptions? Captions { get; set; }

  /// <summary> 
  /// Document Variables
  ///</summary> 
  public IDocumentVariables? DocumentVariables { get; set; }

  /// <summary> 
  /// Document-Wide Endnote Properties
  ///</summary> 
  public IEndnoteProperties? EndnoteDocumentWideProperties { get; set; }

  /// <summary> 
  /// Document-Wide Footnote Properties
  ///</summary> 
  public IFootnoteProperties? FootnoteDocumentWideProperties { get; set; }

  /// <summary> 
  /// Math Properties
  ///</summary> 
  public IMathProperties? MathProperties { get; set; }

  #endregion

  #region Defined as IExtraProperties interface
  ///// <summary> 
  ///// A LongHexNumber element that specifies an arbitrary identifier for the context of the paragraph identifiers in the document.
  ///// Values MUST be greater than 0 and less than 0x80000000.
  /////</summary> 
  //public int? DocumentId { get; set; }

  ///// <summary> 
  ///// Specifies a unique identifier for a set of documents derived from a common source.
  /////</summary> 
  //public Guid? PersistentDocumentId { get; set; }

  ///// <summary> 
  ///// When true, specifies that the user was resolving conflicting edits when the document was saved.
  /////</summary> 
  //public bool? ConflictMode { get; set; }

  ///// <summary>
  ///// List of all revisions
  ///// </summary>
  //public RsIds? RsIds { get; set; }

  #endregion

}