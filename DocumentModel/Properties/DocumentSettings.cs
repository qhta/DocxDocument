using DocumentModel.CustomXml;
using DocumentModel.Math;
using DocumentModel.Wordprocessing;

namespace DocumentModel;

/// <summary>
///   Document Settings.
/// </summary>
public class DocumentSettings: KnownDocumentProperties
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
    public bool? RemovePersonalInformation { get; set; }

    /// <summary>
    ///   Remove Date and Time from Annotations.
    /// </summary>
    public bool? RemoveDateAndTime { get; set; }

    /// <summary>
    ///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
    /// </summary>
    public bool? DoNotDisplayPageBoundaries { get; set; }

    /// <summary>
    ///   Display Background Objects When Displaying Document.
    /// </summary>
    public bool? DisplayBackgroundShape { get; set; }

    /// <summary>
    ///   Print PostScript Codes With Document Text.
    /// </summary>
    public bool? PrintPostScriptOverText { get; set; }

    /// <summary>
    ///   Print Fractional Character Widths.
    /// </summary>
    public bool? PrintFractionalCharacterWidth { get; set; }

    /// <summary>
    ///   Only Print Form Field Content.
    /// </summary>
    public bool? PrintFormsData { get; set; }

    /// <summary>
    ///   Embed TrueType Fonts.
    /// </summary>
    public bool? EmbedTrueTypeFonts { get; set; }

    /// <summary>
    ///   Embed Common System Fonts.
    /// </summary>
    public bool? EmbedSystemFonts { get; set; }

    /// <summary>
    ///   Subset Fonts When Embedding.
    /// </summary>
    public bool? SaveSubsetFonts { get; set; }

    /// <summary>
    ///   Only Save Form Field Content.
    /// </summary>
    public bool? SaveFormsData { get; set; }

    /// <summary>
    ///   Mirror Page Margins.
    /// </summary>
    public bool? MirrorMargins { get; set; }

    /// <summary>
    ///   Align Paragraph and Table Borders with Page Border.
    /// </summary>
    public bool? AlignBorderAndEdges { get; set; }

    /// <summary>
    ///   Page Border Excludes Header.
    /// </summary>
    public bool? BordersDoNotSurroundHeader { get; set; }

    /// <summary>
    ///   Page Border Excludes Footer.
    /// </summary>
    public bool? BordersDoNotSurroundFooter { get; set; }

    /// <summary>
    ///   Position Gutter At Top of Page.
    /// </summary>
    public bool? GutterAtTop { get; set; }

    /// <summary>
    ///   Do Not Display Visual Indication of Spelling Errors.
    /// </summary>
    public bool? HideSpellingErrors { get; set; }

    /// <summary>
    ///   Do Not Display Visual Indication of Grammatical Errors.
    /// </summary>
    public bool? HideGrammaticalErrors { get; set; }

    public Collection<ActiveWritingStyle>? ActiveWritingStyles { get; set; }

    public ProofState? ProofState { get; set; }

    public bool? FormsDesign { get; set; }

    public RelationshipType? AttachedTemplate { get; set; }

    public bool? LinkStyles { get; set; }

    public StylePaneFormatFilter? StylePaneFormatFilter { get; set; }

    public string? StylePaneSortMethods { get; set; }

    public DocumentKind? DocumentType { get; set; }

    public MailMerge? MailMerge { get; set; }

    public RevisionView? RevisionView { get; set; }

    public bool? TrackRevisions { get; set; }

    public bool? DoNotTrackMoves { get; set; }

    public bool? DoNotTrackFormatting { get; set; }

    public DocumentProtection? DocumentProtection { get; set; }

    public bool? AutoFormatOverride { get; set; }

    public short? DefaultTabStop { get; set; }

    public bool? AutoHyphenation { get; set; }

    public ushort? ConsecutiveHyphenLimit { get; set; }

    public string? HyphenationZone { get; set; }

    public bool? DoNotHyphenateCaps { get; set; }

    public bool? ShowEnvelope { get; set; }

    public int? SummaryLength { get; set; }

    public string? ClickAndTypeStyle { get; set; }

    public string? DefaultTableStyle { get; set; }

    public bool? EvenAndOddHeaders { get; set; }

    public bool? BookFoldReversePrinting { get; set; }

    public bool? BookFoldPrinting { get; set; }

    public short? BookFoldPrintingSheets { get; set; }

    public string? DrawingGridHorizontalSpacing { get; set; }

    public string? DrawingGridVerticalSpacing { get; set; }

    public int? DisplayHorizontalDrawingGrid { get; set; }

    public int? DisplayVerticalDrawingGrid { get; set; }

    public bool? DoNotUseMarginsForDrawingGridOrigin { get; set; }

    public string? DrawingGridHorizontalOrigin { get; set; }

    public string? DrawingGridVerticalOrigin { get; set; }

    public bool? DoNotShadeFormData { get; set; }

    public bool? NoPunctuationKerning { get; set; }

    public CharacterSpacingKind? CharacterSpacingControl { get; set; }

    public bool? PrintTwoOnOne { get; set; }

    public bool? StrictFirstAndLastChars { get; set; }

    public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }

    public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }

    public bool? SavePreviewPicture { get; set; }

    public bool? DoNotValidateAgainstSchema { get; set; }

    public bool? SaveInvalidXml { get; set; }

    public bool? IgnoreMixedContent { get; set; }

    public bool? AlwaysShowPlaceholderText { get; set; }

    public bool? DoNotDemarcateInvalidXml { get; set; }

    public bool? SaveXmlDataOnly { get; set; }

    public bool? UseXsltWhenSaving { get; set; }

    public SaveThroughXslt? SaveThroughXslt { get; set; }

    public bool? ShowXmlTags { get; set; }

    public bool? AlwaysMergeEmptyNamespace { get; set; }

    public bool? UpdateFieldsOnOpen { get; set; }

    public HeaderShapeDefaults? HeaderShapeDefaults { get; set; }

    public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }

    public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }

    public Compatibility? Compatibility { get; set; }

    public DocumentVariables? DocumentVariables { get; set; }

    public Rsids? Rsids { get; set; }

    public MathProperties? MathProperties { get; set; }

    public bool? UICompatibleWith97To2003 { get; set; }

    public Collection<string>? AttachedSchemas { get; set; }

    public LanguageType? ThemeFontLanguages { get; set; }

    public ColorSchemeMapping? ColorSchemeMapping { get; set; }

    public bool? DoNotIncludeSubdocsInStats { get; set; }

    public bool? DoNotAutoCompressPictures { get; set; }

    public bool? ForceUpgrade { get; set; }

    public Captions? Captions { get; set; }

    public ReadModeInkLockDown? ReadModeInkLockDown { get; set; }

    public SchemaLibrary? SchemaLibrary { get; set; }

    public ShapeDefaults? ShapeDefaults { get; set; }

    public string? DecimalSymbol { get; set; }

    public string? ListSeparator { get; set; }

    public HexInt? DocumentId { get; set; }

    public OnOffKind? DiscardImageEditingData { get; set; }

    public int? DefaultImageDpi { get; set; }

    public OnOffKind? ConflictMode { get; set; }

    public bool? ChartTrackingRefBased { get; set; }

    public Guid? PersistentDocumentId { get; set; }
}