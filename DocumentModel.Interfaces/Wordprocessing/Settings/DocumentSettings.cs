using DocumentModel.CustomXml;
using DocumentModel.Math;
using DocumentModel.Wordprocessing;
using DocumentModel.Wordprocessing.Settings;
namespace DocumentModel;

/// <summary>
/// Specifies all document-level properties which affect the handling of the current document.
/// This interface provides access to settings for proofing, borders, custom XML, templates, protection, printing, captions, compatibility, styles, and more, enabling advanced configuration and management of Wordprocessing document behavior and appearance.
/// </summary>
public interface DocumentSettings : DocumentProperties
{
  
  /// <summary>
  /// Information about the parameters of the grammar checking performed on the contents of the current document.
  /// </summary>
  [Category("Proofing")]
  public ActiveWritingStyles? ActiveWritingStyles { get; set; }
  
  /// <summary>
  /// Specifies that paragraph and table borders shall be adjusted to align with page borders if spacing is less than or equal to 10.5 points.
  /// </summary>
  [Category("Page borders")]
  public bool? AlignBorderAndEdges { get; set; }
  
  /// <summary>
  /// Specifies whether custom XML markup with no associated namespace is treated as an error and moved into a special error namespace.
  /// </summary>
  [Category("CustomXml")]
  public bool? AlwaysMergeEmptyNamespace { get; set; }
  
  /// <summary>
  /// Specifies that custom XML elements always show placeholder text when they contain no run content.
  /// </summary>
  [Category("CustomXml")]
  public bool? AlwaysShowPlaceholderText { get; set; }
  
  /// <summary>
  /// Specifies the custom XML schemas to be associated with this document when loaded.
  /// </summary>
  [Category("CustomXml")]
  public AttachedSchemas? AttachedSchemas { get; set; }
  
  /// <summary>
  /// Specifies the location of a document template to be attached to the current document.
  /// </summary>
  [Category("Template")]
  public AttachedTemplate? AttachedTemplate { get; set; }
  
  /// <summary>
  /// Specifies whether automatically applied formatting can override formatting protection.
  /// </summary>
  [Category("Protection")]
  public bool? AutoFormatOverride { get; set; }
  
  /// <summary>
  /// Specifies whether the document should automatically be hyphenated by the hosting application.
  /// </summary>
  [Category("Hyphenation")]
  public bool? AutoHyphenation { get; set; }
  
  /// <summary>
  /// Specifies if the document should be printed as signatures for booklet binding.
  /// </summary>
  [Category("Printing")]
  public bool? BookFoldPrinting { get; set; }
  
  /// <summary>
  /// Specifies the number of pages to be included in each booklet when printing signatures.
  /// </summary>
  [Category("Printing")]
  public short? BookFoldPrintingSheets { get; set; }
  
  /// <summary>
  /// Specifies if pages are to be printed as signatures in reverse order.
  /// </summary>
  [Category("Printing")]
  public bool? BookFoldReversePrinting { get; set; }
  
  /// <summary>
  /// Specifies that the page border should not surround contents of the footer.
  /// </summary>
  [Category("Page borders")]
  public bool? BordersDoNotSurroundFooter { get; set; }
  
  /// <summary>
  /// Specifies that the page border should not surround contents of the header.
  /// </summary>
  [Category("Page borders")]
  public bool? BordersDoNotSurroundHeader { get; set; }
  
  /// <summary>
  /// Information about captions in the document.
  /// </summary>
  public Captions? Captions { get; set; }
  
  /// <summary>
  /// Specifies how full-width characters should be compressed to remove additional whitespace.
  /// </summary>
  public CharacterSpacingKind? CharacterSpacingControl { get; set; }
  
  /// <summary>
  /// Specifies how chart datapoint properties and data labels behave in all charts in the document.
  /// </summary>
  [Category("Tracking")]
  public bool? ChartTrackingRefBased { get; set; }
  
  /// <summary>
  /// Specifies the paragraph style to be applied to automatically created paragraphs with no other style.
  /// </summary>
  public string? ClickAndTypeStyle { get; set; }
  
  /// <summary>
  /// Specifies the theme color mapping for the document.
  /// </summary>
  public ColorSchemeMapping? ColorSchemeMapping { get; set; }
  
  /// <summary>
  /// Specifies a set of optional compatibility options for the document.
  /// </summary>
  public Compatibility? Compatibility { get; set; }
  
  /// <summary>
  /// Specifies that the user was resolving conflicting edits when the document was saved.
  /// </summary>
  public bool? ConflictMode { get; set; }
  
  /// <summary>
  /// Specifies the maximum number of consecutive lines ending with a hyphen.
  /// </summary>
  [Category("Hyphenation")]
  public ushort? ConsecutiveHyphenLimit { get; set; }
  
  /// <summary>
  /// Specifies the character to be interpreted as the radix point in fields.
  /// </summary>
  public string? DecimalSymbol { get; set; }
  
  /// <summary>
  /// Specifies the resolution in DPI at which images will be saved.
  /// </summary>
  [Category("Images")]
  public int? DefaultImageDpi { get; set; }
  
  /// <summary>
  /// Specifies the table style to be automatically applied to newly inserted tables.
  /// </summary>
  [Category("Styling")]
  public string? DefaultTableStyle { get; set; }
  
  /// <summary>
  /// Specifies the multiplier for automatic tab stops in the document.
  /// </summary>
  public short? DefaultTabStop { get; set; }
  
  /// <summary>
  /// Specifies that cropped-out areas of images are not to be saved.
  /// </summary>
  [Category("Images")]
  public bool? DiscardImageEditingData { get; set; }
  
  /// <summary>
  /// Specifies whether background images and colors are displayed in print layout view.
  /// </summary>
  [Category("View")]
  public bool? DisplayBackgroundShape { get; set; }
  
  /// <summary>
  /// Specifies the number of horizontal grid units allowed between visible horizontal drawing grid lines.
  /// </summary>
  [Category("Document grid")]
  public int? DisplayHorizontalDrawingGrid { get; set; }
  
  /// <summary>
  /// Specifies the number of vertical grid units allowed between visible vertical drawing grid lines.
  /// </summary>
  [Category("Document grid")]
  public int? DisplayVerticalDrawingGrid { get; set; }
  
  /// <summary>
  /// Specifies an arbitrary identifier for the context of paragraph identifiers in the document.
  /// </summary>
  [Category("Identification")]
  public HexInt? DocumentId { get; set; }
  
  /// <summary>
  /// Specifies the set of document protection restrictions applied to the document.
  /// </summary>
  [Category("Protection")]
  public DocumentProtection? DocumentProtection { get; set; }
  
  /// <summary>
  /// Specifies the classification of the document for customized UI and formatting behaviors.
  /// </summary>
  public DocumentKind? DocumentType { get; set; }
  
  /// <summary>
  /// Specifies the presence of document variables in the document.
  /// </summary>
  public Variables? DocumentVariables { get; set; }
  
  /// <summary>
  /// Specifies that pictures shall not automatically be compressed when saving the document.
  /// </summary>
  [Category("Images")]
  public bool? DoNotAutoCompressPictures { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around invalid custom XML markup.
  /// </summary>
  [Category("CustomXml")]
  public bool? DoNotDemarcateInvalidXml { get; set; }
  
  /// <summary>
  /// Specifies whether header and footer contents are displayed in print layout view.
  /// </summary>
  [Category("View")]
  public bool? DoNotDisplayPageBoundaries { get; set; }
  
  /// <summary>
  /// Specifies whether words in all capital letters shall be hyphenated.
  /// </summary>
  [Category("Hyphenation")]
  public bool? DoNotHyphenateCaps { get; set; }
  
  /// <summary>
  /// Specifies if content in text boxes, footnotes, and endnotes is excluded from document statistics.
  /// </summary>
  public bool? DoNotIncludeSubdocsInStats { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around form fields.
  /// </summary>
  public bool? DoNotShadeFormData { get; set; }
  
  /// <summary>
  /// Specifies that formatting revisions are not tracked when trackRevisions is turned on.
  /// </summary>
  [Category("Tracking")]
  public bool? DoNotTrackFormatting { get; set; }
  
  /// <summary>
  /// Specifies that moves are not tracked as revisions when trackRevisions is turned on.
  /// </summary>
  [Category("Tracking")]
  public bool? DoNotTrackMoves { get; set; }
  
  /// <summary>
  /// Specifies that the top-left corner of the page is not used as the origin for the drawing grid.
  /// </summary>
  [Category("Document grid")]
  public bool? DoNotUseMarginsForDrawingGridOrigin { get; set; }
  
  /// <summary>
  /// Specifies that custom XML markup is not validated against schemas.
  /// </summary>
  [Category("CustomXml")]
  public bool? DoNotValidateAgainstSchema { get; set; }
  
  /// <summary>
  /// Specifies the origin for horizontal gridlines used by the drawing grid.
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridHorizontalOrigin { get; set; }
  
  /// <summary>
  /// Specifies the width of horizontal grid units in the document.
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridHorizontalSpacing { get; set; }
  
  /// <summary>
  /// Specifies the origin for vertical gridlines used by the drawing grid.
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridVerticalOrigin { get; set; }
  
  /// <summary>
  /// Specifies the width of vertical grid units in the document.
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridVerticalSpacing { get; set; }
  
  /// <summary>
  /// Specifies that system fonts are embedded when font embedding is enabled.
  /// </summary>
  [Category("Fonts")]
  public bool? EmbedSystemFonts { get; set; }
  
  /// <summary>
  /// Specifies that fonts in use are embedded when the document is saved.
  /// </summary>
  [Category("Fonts")]
  public bool? EmbedTrueTypeFonts { get; set; }
  
  /// <summary>
  /// Specifies the endnote properties for the document.
  /// </summary>
  [Category("Footnotes and endnotes")]
  public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }
  
  /// <summary>
  /// Specifies whether sections have different headers and footers for even and odd pages.
  /// </summary>
  public bool? EvenAndOddHeaders { get; set; }
  
  /// <summary>
  /// Specifies the footnote properties for the document.
  /// </summary>
  [Category("Footnotes and endnotes")]
  public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }
  
  /// <summary>
  /// Specifies that the document can be upgraded and is not limited to earlier word processing formats.
  /// </summary>
  public bool? ForceUpgrade { get; set; }
  
  /// <summary>
  /// Specifies that the document was last saved while placeholder text of all structured document tags was being edited.
  /// </summary>
  [Category("Forms")]
  public bool? FormsDesign { get; set; }
  
  /// <summary>
  /// Specifies that the gutter is positioned at the top of the document's pages.
  /// </summary>
  [Category("Printing")]
  public bool? GutterAtTop { get; set; }
  
  /// <summary>
  /// Specifies the default parameters for VML objects inserted in the header and footer.
  /// </summary>
  [Category("VML")]
  [Obsolete]
  public IHeaderShapeDefaults? HeaderShapeDefaults { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around grammatical errors.
  /// </summary>
  [Category("Proofing")]
  public bool? HideGrammaticalErrors { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around spelling errors.
  /// </summary>
  [Category("Proofing")]
  public bool? HideSpellingErrors { get; set; }
  
  /// <summary>
  /// Specifies the hyphenation zone used for automatic or manual hyphenation.
  /// </summary>
  [Category("Hyphenation")]
  public Twips? HyphenationZone { get; set; }
  
  /// <summary>
  /// Specifies that only leaf custom XML elements are validated against schemas.
  /// </summary>
  [Category("CustomXml")]
  public bool? IgnoreMixedContent { get; set; }
  
  /// <summary>
  /// Specifies that styles are updated to match the attached template when the document is opened.
  /// </summary>
  [Category("Styling")]
  public bool? LinkStyles { get; set; }
  
  /// <summary>
  /// Specifies the character used as a list item separator in fields.
  /// </summary>
  public string? ListSeparator { get; set; }
  
  /// <summary>
  /// Specifies all mail merge information for the document.
  /// </summary>
  [Category("Mailing")]
  public MailMerge? MailMerge { get; set; }
  
  /// <summary>
  /// Specifies the document-level properties for all math in the document.
  /// </summary>
  public MathProperties? MathProperties { get; set; }
  
  /// <summary>
  /// Specifies that left and right margins are swapped on every second page.
  /// </summary>
  public bool? MirrorMargins { get; set; }
  
  /// <summary>
  /// Specifies the set of characters restricted from ending a line for custom line breaking logic.
  /// </summary>
  [Category("Kinsoku")]
  public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }
  
  /// <summary>
  /// Specifies the set of characters restricted from beginning a new line for custom line breaking logic.
  /// </summary>
  [Category("Kinsoku")]
  public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }
  
  /// <summary>
  /// Specifies that punctuation characters are not kerned when kerning is enabled.
  /// </summary>
  public bool? NoPunctuationKerning { get; set; }
  
  /// <summary>
  /// Specifies a unique identifier for a set of documents derived from a common source.
  /// </summary>
  [Category("Identification")]
  public Guid? PersistentDocumentId { get; set; }
  
  /// <summary>
  /// Specifies that only WordprocessingML form fields are printed, suppressing all other content.
  /// </summary>
  [Category("Printing")]
  public bool? PrintFormsData { get; set; }
  
  /// <summary>
  /// Specifies that fractional character widths are used when printing the document.
  /// </summary>
  [Category("Printing")]
  public bool? PrintFractionalCharacterWidth { get; set; }
  
  /// <summary>
  /// Specifies that PostScript codes are included in foreground with printed data.
  /// </summary>
  [Category("Printing")]
  public bool? PrintPostScriptOverText { get; set; }
  
  /// <summary>
  /// Specifies whether two pages are printed on one sheet of paper.
  /// </summary>
  [Category("Printing")]
  public bool? PrintTwoOnOne { get; set; }
  
  /// <summary>
  /// Specifies if grammar and spell-checking engines completed checking before the document was last saved.
  /// </summary>
  [Category("Proofing")]
  public ProofState? ProofState { get; set; }
  
  /// <summary>
  /// Specifies the exact set of page and text sizing parameters for displaying the document, used for ink annotations.
  /// </summary>
  public DMWD.ReadModeInkLockDown? ReadModeInkLockDown { get; set; }
  
  /// <summary>
  /// Specifies that date and time information is removed from all annotations when the document is saved.
  /// </summary>
  [Category("Protection")]
  public bool? RemoveDateAndTime { get; set; }
  
  /// <summary>
  /// Specifies that all personal information of document authors is removed upon saving.
  /// </summary>
  [Category("Protection")]
  public bool? RemovePersonalInformation { get; set; }
  
  /// <summary>
  /// Specifies which forms of annotations are visible when the document is displayed.
  /// </summary>
  [Category("View")]
  public RevisionView? RevisionView { get; set; }
  
  /// <summary>
  /// Specifies the set of revision save ID values for the current document.
  /// </summary>
  [Category("Tracking")]
  public Rsids? Rsids { get; set; }
  
  /// <summary>
  /// Specifies that only WordprocessingML form fields are saved in a comma-delimited text format.
  /// </summary>
  [Category("Forms")]
  public bool? SaveFormsData { get; set; }
  
  /// <summary>
  /// Specifies that the document can be saved as a single XML file even when its contents are invalid based on XML schema validation.
  /// </summary>
  [Category("CustomXml")]
  public bool? SaveInvalidXml { get; set; }
  
  /// <summary>
  /// Specifies if a document's thumbnail part should be generated for the first page when saved.
  /// </summary>
  public bool? SavePreviewPicture { get; set; }
  
  /// <summary>
  /// Specifies that fonts are subsetted when font embedding is enabled.
  /// </summary>
  [Category("Fonts")]
  public bool? SaveSubsetFonts { get; set; }
  
  /// <summary>
  /// Specifies the location of a custom XSL transform to be used when saving as a single XML file.
  /// </summary>
  [Category("Xslt")]
  public SaveThroughXslt? SaveThroughXslt { get; set; }
  
  /// <summary>
  /// Specifies that only custom XML markup is saved as an XML file.
  /// </summary>
  [Category("CustomXml")]
  public bool? SaveXmlDataOnly { get; set; }
  
  /// <summary>
  /// Specifies the set of XML namespaces associated with custom XML markup in the document.
  /// </summary>
  [Category("CustomXml")]
  public SchemaLibrary? SchemaLibrary { get; set; }
  
  /// <summary>
  /// Specifies the defaults used when creating new shapes, stored once per document.
  /// </summary>
  [Category("VML")]
  [Obsolete]
  public DMWD.ShapeDefaults? ShapeDefaults { get; set; }
  
  /// <summary>
  /// Specifies that an e-mail message header is displayed when the document is opened.
  /// </summary>
  [Category("Mailing")]
  public bool? ShowEnvelope { get; set; }
  
  /// <summary>
  /// Specifies that a visual indicator is provided for the start and end locations of custom XML markup.
  /// </summary>
  [Category("CustomXml")]
  public bool? ShowXmlTags { get; set; }
  
  /// <summary>
  /// Specifies that the strict set of Kinsoku rules is applied to Japanese text in the document.
  /// </summary>
  [Category("Kinsoku")]
  public bool? StrictFirstAndLastChars { get; set; }
  
  /// <summary>
  /// Specifies suggested filters to be applied to the list of document styles in the application UI.
  /// </summary>
  [Category("Styling")]
  public StylePaneFormatFilter? StylePaneFormatFilter { get; set; }
  
  /// <summary>
  /// Specifies a sorting to be applied to the list of styles in the document UI.
  /// </summary>
  [Category("Styling")]
  public string? StylePaneSortMethods { get; set; }
  
  /// <summary>
  /// Specifies the size for automatic document summaries performed on the content of the document.
  /// </summary>
  public Percent? SummaryLength { get; set; }
  
  /// <summary>
  /// Specifies the language used to determine theme fonts in the document's Theme part.
  /// </summary>
  [Category("Fonts")]
  public Languages? ThemeFontLanguages { get; set; }
  
  /// <summary>
  /// Specifies that revisions are tracked in the document.
  /// </summary>
  [Category("Tracking")]
  public bool? TrackRevisions { get; set; }
  
  /// <summary>
  /// Disables features incompatible with earlier word processing formats.
  /// </summary>
  public bool? UICompatibleWith97To2003 { get; set; }
  
  /// <summary>
  /// Specifies whether fields should automatically have their result recalculated when the document is opened.
  /// </summary>
  [Category("Protection")]
  public bool? UpdateFieldsOnOpen { get; set; }
  
  /// <summary>
  /// Specifies that the document should be saved through the custom XSLT transform when saved as a single XML file.
  /// </summary>
  [Category("Xslt")]
  public bool? UseXsltWhenSaving { get; set; }
  
  /// <summary>
  /// Specifies the manner in which the document should be displayed when opened by an application.
  /// </summary>
  [Category("View")]
  public ViewKind? View { get; set; }
  
  /// <summary>
  /// Specifies the write protection settings applied to the document.
  /// </summary>
  [Category("Protection")]
  public WriteProtection? WriteProtection { get; set; }
  
  /// <summary>
  /// Specifies the magnification level to be applied when the document is displayed.
  /// </summary>
  [Category("View")]
  public Zoom? Zoom { get; set; }
}