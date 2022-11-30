namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public interface ISettings // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public DocumentModel.Wordprocessing.IWriteProtection? WriteProtection { get ; set; }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.ViewKind? View { get ; set; }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.IZoom? Zoom { get ; set; }
  
  /// <summary>
  /// Remove Personal Information from Document Properties.
  /// </summary>
  public System.Boolean? RemovePersonalInformation { get ; set; }
  
  /// <summary>
  /// Remove Date and Time from Annotations.
  /// </summary>
  public System.Boolean? RemoveDateAndTime { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Boundary For Header/Footer or Between Pages.
  /// </summary>
  public System.Boolean? DoNotDisplayPageBoundaries { get ; set; }
  
  /// <summary>
  /// Display Background Objects When Displaying Document.
  /// </summary>
  public System.Boolean? DisplayBackgroundShape { get ; set; }
  
  /// <summary>
  /// Print PostScript Codes With Document Text.
  /// </summary>
  public System.Boolean? PrintPostScriptOverText { get ; set; }
  
  /// <summary>
  /// Print Fractional Character Widths.
  /// </summary>
  public System.Boolean? PrintFractionalCharacterWidth { get ; set; }
  
  /// <summary>
  /// Only Print Form Field Content.
  /// </summary>
  public System.Boolean? PrintFormsData { get ; set; }
  
  /// <summary>
  /// Embed TrueType Fonts.
  /// </summary>
  public System.Boolean? EmbedTrueTypeFonts { get ; set; }
  
  /// <summary>
  /// Embed Common System Fonts.
  /// </summary>
  public System.Boolean? EmbedSystemFonts { get ; set; }
  
  /// <summary>
  /// Subset Fonts When Embedding.
  /// </summary>
  public System.Boolean? SaveSubsetFonts { get ; set; }
  
  /// <summary>
  /// Only Save Form Field Content.
  /// </summary>
  public System.Boolean? SaveFormsData { get ; set; }
  
  /// <summary>
  /// Mirror Page Margins.
  /// </summary>
  public System.Boolean? MirrorMargins { get ; set; }
  
  /// <summary>
  /// Align Paragraph and Table Borders with Page Border.
  /// </summary>
  public System.Boolean? AlignBorderAndEdges { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Header.
  /// </summary>
  public System.Boolean? BordersDoNotSurroundHeader { get ; set; }
  
  /// <summary>
  /// Page Border Excludes Footer.
  /// </summary>
  public System.Boolean? BordersDoNotSurroundFooter { get ; set; }
  
  /// <summary>
  /// Position Gutter At Top of Page.
  /// </summary>
  public System.Boolean? GutterAtTop { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Spelling Errors.
  /// </summary>
  public System.Boolean? HideSpellingErrors { get ; set; }
  
  /// <summary>
  /// Do Not Display Visual Indication of Grammatical Errors.
  /// </summary>
  public System.Boolean? HideGrammaticalErrors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IActiveWritingStyle>? ActiveWritingStyles { get ; set; }
  
  public DocumentModel.Wordprocessing.IProofState? ProofState { get ; set; }
  
  public System.Boolean? FormsDesign { get ; set; }
  
  public DocumentModel.Wordprocessing.IRelationshipType? AttachedTemplate { get ; set; }
  
  public System.Boolean? LinkStyles { get ; set; }
  
  public DocumentModel.Wordprocessing.IStylePaneFormatFilter? StylePaneFormatFilter { get ; set; }
  
  public System.String? StylePaneSortMethods { get ; set; }
  
  public DocumentModel.Wordprocessing.DocumentKind? DocumentType { get ; set; }
  
  public DocumentModel.Wordprocessing.IMailMerge? MailMerge { get ; set; }
  
  public DocumentModel.Wordprocessing.IRevisionView? RevisionView { get ; set; }
  
  public System.Boolean? TrackRevisions { get ; set; }
  
  public System.Boolean? DoNotTrackMoves { get ; set; }
  
  public System.Boolean? DoNotTrackFormatting { get ; set; }
  
  public DocumentModel.Wordprocessing.IDocumentProtection? DocumentProtection { get ; set; }
  
  public System.Boolean? AutoFormatOverride { get ; set; }
  
  public System.Int16? DefaultTabStop { get ; set; }
  
  public System.Boolean? AutoHyphenation { get ; set; }
  
  public System.UInt16? ConsecutiveHyphenLimit { get ; set; }
  
  public System.String? HyphenationZone { get ; set; }
  
  public System.Boolean? DoNotHyphenateCaps { get ; set; }
  
  public System.Boolean? ShowEnvelope { get ; set; }
  
  public System.Int32? SummaryLength { get ; set; }
  
  public System.String? ClickAndTypeStyle { get ; set; }
  
  public System.String? DefaultTableStyle { get ; set; }
  
  public System.Boolean? EvenAndOddHeaders { get ; set; }
  
  public System.Boolean? BookFoldReversePrinting { get ; set; }
  
  public System.Boolean? BookFoldPrinting { get ; set; }
  
  public System.Int16? BookFoldPrintingSheets { get ; set; }
  
  public System.String? DrawingGridHorizontalSpacing { get ; set; }
  
  public System.String? DrawingGridVerticalSpacing { get ; set; }
  
  public System.Int32? DisplayHorizontalDrawingGrid { get ; set; }
  
  public System.Int32? DisplayVerticalDrawingGrid { get ; set; }
  
  public System.Boolean? DoNotUseMarginsForDrawingGridOrigin { get ; set; }
  
  public System.String? DrawingGridHorizontalOrigin { get ; set; }
  
  public System.String? DrawingGridVerticalOrigin { get ; set; }
  
  public System.Boolean? DoNotShadeFormData { get ; set; }
  
  public System.Boolean? NoPunctuationKerning { get ; set; }
  
  public DocumentModel.Wordprocessing.CharacterSpacingKind? CharacterSpacingControl { get ; set; }
  
  public System.Boolean? PrintTwoOnOne { get ; set; }
  
  public System.Boolean? StrictFirstAndLastChars { get ; set; }
  
  public DocumentModel.Wordprocessing.INoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get ; set; }
  
  public DocumentModel.Wordprocessing.INoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get ; set; }
  
  public System.Boolean? SavePreviewPicture { get ; set; }
  
  public System.Boolean? DoNotValidateAgainstSchema { get ; set; }
  
  public System.Boolean? SaveInvalidXml { get ; set; }
  
  public System.Boolean? IgnoreMixedContent { get ; set; }
  
  public System.Boolean? AlwaysShowPlaceholderText { get ; set; }
  
  public System.Boolean? DoNotDemarcateInvalidXml { get ; set; }
  
  public System.Boolean? SaveXmlDataOnly { get ; set; }
  
  public System.Boolean? UseXsltWhenSaving { get ; set; }
  
  public DocumentModel.Wordprocessing.ISaveThroughXslt? SaveThroughXslt { get ; set; }
  
  public System.Boolean? ShowXmlTags { get ; set; }
  
  public System.Boolean? AlwaysMergeEmptyNamespace { get ; set; }
  
  public System.Boolean? UpdateFieldsOnOpen { get ; set; }
  
  public DocumentModel.Wordprocessing.IHeaderShapeDefaults? HeaderShapeDefaults { get ; set; }
  
  public DocumentModel.Wordprocessing.IFootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IEndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.ICompatibility? Compatibility { get ; set; }
  
  public DocumentModel.Wordprocessing.IDocumentVariables? DocumentVariables { get ; set; }
  
  public DocumentModel.Wordprocessing.IRsids? Rsids { get ; set; }
  
  public DocumentModel.Math.IMathProperties? MathProperties { get ; set; }
  
  public System.Boolean? UICompatibleWith97To2003 { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.String>? AttachedSchemas { get ; set; }
  
  public DocumentModel.Wordprocessing.ILanguageType? ThemeFontLanguages { get ; set; }
  
  public DocumentModel.Wordprocessing.IColorSchemeMapping? ColorSchemeMapping { get ; set; }
  
  public System.Boolean? DoNotIncludeSubdocsInStats { get ; set; }
  
  public System.Boolean? DoNotAutoCompressPictures { get ; set; }
  
  public System.Boolean? ForceUpgrade { get ; set; }
  
  public DocumentModel.Wordprocessing.ICaptions? Captions { get ; set; }
  
  public DocumentModel.Wordprocessing.IReadModeInkLockDown? ReadModeInkLockDown { get ; set; }
  
  public DocumentModel.CustomXmlSchemaReferences.ISchemaLibrary? SchemaLibrary { get ; set; }
  
  public DocumentModel.Wordprocessing.IShapeDefaults? ShapeDefaults { get ; set; }
  
  public System.String? DecimalSymbol { get ; set; }
  
  public System.String? ListSeparator { get ; set; }
  
  public DocumentModel.IHexBinaryValue? DocumentId { get ; set; }
  
  public DocumentModel.Office2010.Word.OnOffKind? DiscardImageEditingData { get ; set; }
  
  public System.Int32? DefaultImageDpi { get ; set; }
  
  public DocumentModel.Office2010.Word.OnOffKind? ConflictMode { get ; set; }
  
  public System.Boolean? ChartTrackingRefBased { get ; set; }
  
  public System.String? PersistentDocumentId { get ; set; }
  
}
