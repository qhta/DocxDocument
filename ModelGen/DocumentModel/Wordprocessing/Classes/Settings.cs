namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Settings.
/// </summary>
public partial class Settings
{
  
  /// <summary>
  ///   Write Protection.
  /// </summary>
  public WriteProtection? WriteProtection { get; set; }
  
  
  /// <summary>
  ///   Document View Setting.
  /// </summary>
  public ViewKind? View { get; set; }
  
  
  /// <summary>
  ///   Magnification Setting.
  /// </summary>
  public Zoom? Zoom { get; set; }
  
  
  /// <summary>
  ///   Remove Personal Information from Document Properties.
  /// </summary>
  public Boolean? RemovePersonalInformation { get; set; }
  
  
  /// <summary>
  ///   Remove Date and Time from Annotations.
  /// </summary>
  public Boolean? RemoveDateAndTime { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public Boolean? DoNotDisplayPageBoundaries { get; set; }
  
  
  /// <summary>
  ///   Display Background Objects When Displaying Document.
  /// </summary>
  public Boolean? DisplayBackgroundShape { get; set; }
  
  
  /// <summary>
  ///   Print PostScript Codes With Document Text.
  /// </summary>
  public Boolean? PrintPostScriptOverText { get; set; }
  
  
  /// <summary>
  ///   Print Fractional Character Widths.
  /// </summary>
  public Boolean? PrintFractionalCharacterWidth { get; set; }
  
  
  /// <summary>
  ///   Only Print Form Field Content.
  /// </summary>
  public Boolean? PrintFormsData { get; set; }
  
  
  /// <summary>
  ///   Embed TrueType Fonts.
  /// </summary>
  public Boolean? EmbedTrueTypeFonts { get; set; }
  
  
  /// <summary>
  ///   Embed Common System Fonts.
  /// </summary>
  public Boolean? EmbedSystemFonts { get; set; }
  
  
  /// <summary>
  ///   Subset Fonts When Embedding.
  /// </summary>
  public Boolean? SaveSubsetFonts { get; set; }
  
  
  /// <summary>
  ///   Only Save Form Field Content.
  /// </summary>
  public Boolean? SaveFormsData { get; set; }
  
  
  /// <summary>
  ///   Mirror Page Margins.
  /// </summary>
  public Boolean? MirrorMargins { get; set; }
  
  
  /// <summary>
  ///   Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public Boolean? AlignBorderAndEdges { get; set; }
  
  
  /// <summary>
  ///   Page Border Excludes Header.
  /// </summary>
  public Boolean? BordersDoNotSurroundHeader { get; set; }
  
  
  /// <summary>
  ///   Page Border Excludes Footer.
  /// </summary>
  public Boolean? BordersDoNotSurroundFooter { get; set; }
  
  
  /// <summary>
  ///   Position Gutter At Top of Page.
  /// </summary>
  public Boolean? GutterAtTop { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public Boolean? HideSpellingErrors { get; set; }
  
  
  /// <summary>
  ///   Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public Boolean? HideGrammaticalErrors { get; set; }
  
  public ProofState? ProofState { get; set; }
  
  public Boolean? FormsDesign { get; set; }
  
  public RelationshipType? AttachedTemplate { get; set; }
  
  public Boolean? LinkStyles { get; set; }
  
  public StylePaneFormatFilter? StylePaneFormatFilter { get; set; }
  
  public StylePaneSortMethods? StylePaneSortMethods { get; set; }
  
  public DocumentTypeKind? DocumentType { get; set; }
  
  public MailMerge? MailMerge { get; set; }
  
  public RevisionView? RevisionView { get; set; }
  
  public Boolean? TrackRevisions { get; set; }
  
  public Boolean? DoNotTrackMoves { get; set; }
  
  public Boolean? DoNotTrackFormatting { get; set; }
  
  public DocumentProtection? DocumentProtection { get; set; }
  
  public Boolean? AutoFormatOverride { get; set; }
  
  public Int16? DefaultTabStop { get; set; }
  
  public Boolean? AutoHyphenation { get; set; }
  
  public UInt16? ConsecutiveHyphenLimit { get; set; }
  
  public String? HyphenationZone { get; set; }
  
  public Boolean? DoNotHyphenateCaps { get; set; }
  
  public Boolean? ShowEnvelope { get; set; }
  
  public Int32? SummaryLength { get; set; }
  
  public String? ClickAndTypeStyle { get; set; }
  
  public String? DefaultTableStyle { get; set; }
  
  public Boolean? EvenAndOddHeaders { get; set; }
  
  public Boolean? BookFoldReversePrinting { get; set; }
  
  public Boolean? BookFoldPrinting { get; set; }
  
  public Int16? BookFoldPrintingSheets { get; set; }
  
  public String? DrawingGridHorizontalSpacing { get; set; }
  
  public String? DrawingGridVerticalSpacing { get; set; }
  
  public HexInt? DisplayHorizontalDrawingGrid { get; set; }
  
  public HexInt? DisplayVerticalDrawingGrid { get; set; }
  
  public Boolean? DoNotUseMarginsForDrawingGridOrigin { get; set; }
  
  public String? DrawingGridHorizontalOrigin { get; set; }
  
  public String? DrawingGridVerticalOrigin { get; set; }
  
  public Boolean? DoNotShadeFormData { get; set; }
  
  public Boolean? NoPunctuationKerning { get; set; }
  
  public CharacterSpacingKind? CharacterSpacingControl { get; set; }
  
  public Boolean? PrintTwoOnOne { get; set; }
  
  public Boolean? StrictFirstAndLastChars { get; set; }
  
  public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }
  
  public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }
  
  public Boolean? SavePreviewPicture { get; set; }
  
  public Boolean? DoNotValidateAgainstSchema { get; set; }
  
  public Boolean? SaveInvalidXml { get; set; }
  
  public Boolean? IgnoreMixedContent { get; set; }
  
  public Boolean? AlwaysShowPlaceholderText { get; set; }
  
  public Boolean? DoNotDemarcateInvalidXml { get; set; }
  
  public Boolean? SaveXmlDataOnly { get; set; }
  
  public Boolean? UseXsltWhenSaving { get; set; }
  
  public SaveThroughXslt? SaveThroughXslt { get; set; }
  
  public Boolean? ShowXmlTags { get; set; }
  
  public Boolean? AlwaysMergeEmptyNamespace { get; set; }
  
  public Boolean? UpdateFieldsOnOpen { get; set; }
  
  public HeaderShapeDefaults? HeaderShapeDefaults { get; set; }
  
  public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }
  
  public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }
  
  public Compatibility? Compatibility { get; set; }
  
  public DocumentVariables? DocumentVariables { get; set; }
  
  public Rsids? Rsids { get; set; }
  
  public MathProperties? MathProperties { get; set; }
  
  public Boolean? UICompatibleWith97To2003 { get; set; }
  
  public LanguageType? ThemeFontLanguages { get; set; }
  
  public ColorSchemeMapping? ColorSchemeMapping { get; set; }
  
  public Boolean? DoNotIncludeSubdocsInStats { get; set; }
  
  public Boolean? DoNotAutoCompressPictures { get; set; }
  
  public Boolean? ForceUpgrade { get; set; }
  
  public Captions? Captions { get; set; }
  
  public ReadModeInkLockDown? ReadModeInkLockDown { get; set; }
  
  public SchemaLibrary? SchemaLibrary { get; set; }
  
  public ShapeDefaults? ShapeDefaults { get; set; }
  
  public String? DecimalSymbol { get; set; }
  
  public String? ListSeparator { get; set; }
  
  public HexBinary? DocumentId { get; set; }
  
  public Boolean? DiscardImageEditingData { get; set; }
  
  public Int32? DefaultImageDpi { get; set; }
  
  public Boolean? ConflictMode { get; set; }
  
  public Boolean? ChartTrackingRefBased { get; set; }
  
  public String? PersistentDocumentId { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
