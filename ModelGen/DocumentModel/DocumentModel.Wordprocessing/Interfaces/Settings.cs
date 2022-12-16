namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public interface Settings
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public DocumentModel.Wordprocessing.WriteProtection? WriteProtection { get ; set; }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.ViewKind? View { get ; set; }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.Zoom? Zoom { get ; set; }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public Boolean? RemovePersonalInformation { get ; set; }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public Boolean? RemoveDateAndTime { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public Boolean? DoNotDisplayPageBoundaries { get ; set; }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public Boolean? DisplayBackgroundShape { get ; set; }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public Boolean? PrintPostScriptOverText { get ; set; }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public Boolean? PrintFractionalCharacterWidth { get ; set; }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public Boolean? PrintFormsData { get ; set; }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public Boolean? EmbedTrueTypeFonts { get ; set; }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public Boolean? EmbedSystemFonts { get ; set; }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public Boolean? SaveSubsetFonts { get ; set; }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public Boolean? SaveFormsData { get ; set; }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public Boolean? MirrorMargins { get ; set; }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public Boolean? AlignBorderAndEdges { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public Boolean? BordersDoNotSurroundHeader { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public Boolean? BordersDoNotSurroundFooter { get ; set; }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public Boolean? GutterAtTop { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public Boolean? HideSpellingErrors { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public Boolean? HideGrammaticalErrors { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ActiveWritingStyle>? ActiveWritingStyles { get ; set; }
  
  public DocumentModel.Wordprocessing.ProofState? ProofState { get ; set; }
  
  public Boolean? FormsDesign { get ; set; }
  
  public DocumentModel.Wordprocessing.RelationshipType? AttachedTemplate { get ; set; }
  
  public Boolean? LinkStyles { get ; set; }
  
  public DocumentModel.Wordprocessing.StylePaneFormatFilter? StylePaneFormatFilter { get ; set; }
  
  public String? StylePaneSortMethods { get ; set; }
  
  public DocumentModel.Wordprocessing.DocumentKind? DocumentType { get ; set; }
  
  public DocumentModel.Wordprocessing.MailMerge? MailMerge { get ; set; }
  
  public DocumentModel.Wordprocessing.RevisionView? RevisionView { get ; set; }
  
  public Boolean? TrackRevisions { get ; set; }
  
  public Boolean? DoNotTrackMoves { get ; set; }
  
  public Boolean? DoNotTrackFormatting { get ; set; }
  
  public DocumentModel.Wordprocessing.DocumentProtection? DocumentProtection { get ; set; }
  
  public Boolean? AutoFormatOverride { get ; set; }
  
  public Int16? DefaultTabStop { get ; set; }
  
  public Boolean? AutoHyphenation { get ; set; }
  
  public UInt16? ConsecutiveHyphenLimit { get ; set; }
  
  public String? HyphenationZone { get ; set; }
  
  public Boolean? DoNotHyphenateCaps { get ; set; }
  
  public Boolean? ShowEnvelope { get ; set; }
  
  public Int32? SummaryLength { get ; set; }
  
  public String? ClickAndTypeStyle { get ; set; }
  
  public String? DefaultTableStyle { get ; set; }
  
  public Boolean? EvenAndOddHeaders { get ; set; }
  
  public Boolean? BookFoldReversePrinting { get ; set; }
  
  public Boolean? BookFoldPrinting { get ; set; }
  
  public Int16? BookFoldPrintingSheets { get ; set; }
  
  public String? DrawingGridHorizontalSpacing { get ; set; }
  
  public String? DrawingGridVerticalSpacing { get ; set; }
  
  public Int32? DisplayHorizontalDrawingGrid { get ; set; }
  
  public Int32? DisplayVerticalDrawingGrid { get ; set; }
  
  public Boolean? DoNotUseMarginsForDrawingGridOrigin { get ; set; }
  
  public String? DrawingGridHorizontalOrigin { get ; set; }
  
  public String? DrawingGridVerticalOrigin { get ; set; }
  
  public Boolean? DoNotShadeFormData { get ; set; }
  
  public Boolean? NoPunctuationKerning { get ; set; }
  
  public DocumentModel.Wordprocessing.CharacterSpacingKind? CharacterSpacingControl { get ; set; }
  
  public Boolean? PrintTwoOnOne { get ; set; }
  
  public Boolean? StrictFirstAndLastChars { get ; set; }
  
  public DocumentModel.Wordprocessing.NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get ; set; }
  
  public DocumentModel.Wordprocessing.NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get ; set; }
  
  public Boolean? SavePreviewPicture { get ; set; }
  
  public Boolean? DoNotValidateAgainstSchema { get ; set; }
  
  public Boolean? SaveInvalidXml { get ; set; }
  
  public Boolean? IgnoreMixedContent { get ; set; }
  
  public Boolean? AlwaysShowPlaceholderText { get ; set; }
  
  public Boolean? DoNotDemarcateInvalidXml { get ; set; }
  
  public Boolean? SaveXmlDataOnly { get ; set; }
  
  public Boolean? UseXsltWhenSaving { get ; set; }
  
  public DocumentModel.Wordprocessing.SaveThroughXslt? SaveThroughXslt { get ; set; }
  
  public Boolean? ShowXmlTags { get ; set; }
  
  public Boolean? AlwaysMergeEmptyNamespace { get ; set; }
  
  public Boolean? UpdateFieldsOnOpen { get ; set; }
  
  public DocumentModel.Wordprocessing.HeaderShapeDefaults? HeaderShapeDefaults { get ; set; }
  
  public DocumentModel.Wordprocessing.FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.Compatibility? Compatibility { get ; set; }
  
  public DocumentModel.Wordprocessing.DocumentVariables? DocumentVariables { get ; set; }
  
  public DocumentModel.Wordprocessing.Rsids? Rsids { get ; set; }
  
  public DocumentModel.Math.MathProperties? MathProperties { get ; set; }
  
  public Boolean? UICompatibleWith97To2003 { get ; set; }
  
  public Collection<System.String>? AttachedSchemas { get ; set; }
  
  public DocumentModel.Wordprocessing.LanguageType? ThemeFontLanguages { get ; set; }
  
  public DocumentModel.Wordprocessing.ColorSchemeMapping? ColorSchemeMapping { get ; set; }
  
  public Boolean? DoNotIncludeSubdocsInStats { get ; set; }
  
  public Boolean? DoNotAutoCompressPictures { get ; set; }
  
  public Boolean? ForceUpgrade { get ; set; }
  
  public DocumentModel.Wordprocessing.Captions? Captions { get ; set; }
  
  public DocumentModel.Wordprocessing.ReadModeInkLockDown? ReadModeInkLockDown { get ; set; }
  
  public DocumentModel.CustomXml.SchemaLibrary? SchemaLibrary { get ; set; }
  
  public DocumentModel.Wordprocessing.ShapeDefaults? ShapeDefaults { get ; set; }
  
  public String? DecimalSymbol { get ; set; }
  
  public String? ListSeparator { get ; set; }
  
  public DocumentModel.HexBinary? DocumentId { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffKind? DiscardImageEditingData { get ; set; }
  
  public Int32? DefaultImageDpi { get ; set; }
  
  public DocumentModel.Wordprocessing.OnOffKind? ConflictMode { get ; set; }
  
  public Boolean? ChartTrackingRefBased { get ; set; }
  
  public String? PersistentDocumentId { get ; set; }
  
}
