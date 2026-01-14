using DocumentModel.Wordprocessing;
//using DocumentModel.Wordprocessing.Settings;
namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies all document-level properties which affect the handling of the current document.
/// This class provides access to settings for proofing, borders, custom XML, templates, protection, printing, captions, compatibility, styles, and more, enabling advanced configuration and management of Wordprocessing document behavior and appearance.
/// </summary>
public partial class DocumentSettings: ModelElement
{
  /// <summary>
  /// Information about the parameters of the grammar checking performed on the contents of the current document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:activeWritingStyle
  /// </remarks>
  [Category("Proofing")]

  public ActiveWritingStyles? ActiveWritingStyles { get; set; }
  /// <summary>
  /// Specifies that paragraph and table borders shall be adjusted to align with page borders if spacing is less than or equal to 10.5 points.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:alignBordersAndEdges
  /// </remarks>
  [Category("Page layout")]
  public bool? AlignBorderAndEdges { get; set; }
  
  /// <summary>
  /// Specifies whether custom XML markup with no associated namespace is treated as an error and moved into a special error namespace.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:alwaysMergeEmptyNamespace
  /// </remarks>
  [Category("CustomXml")]
  public bool? AlwaysMergeEmptyNamespace { get; set; }
  
  /// <summary>
  /// Specifies that custom XML elements always show placeholder text when they contain no run content.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:alwaysShowPlaceholderText
  /// </remarks>
  [Category("CustomXml")]
  public bool? AlwaysShowPlaceholderText { get; set; }
  
  /// <summary>
  /// Specifies the custom XML schemas to be associated with this document when loaded.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:attachedSchema
  /// </remarks>
  [Category("CustomXml")]
  public AttachedSchemas? AttachedSchemas { get; set; }
  
  /// <summary>
  /// Specifies the location of a document template to be attached to the current document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:attachedTemplate
  /// </remarks>
  [Category("Template")]
  public AttachedTemplate? AttachedTemplate { get; set; }
  
  /// <summary>
  /// Specifies whether automatically applied formatting can override formatting protection.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:autoFormatOverride
  /// </remarks>
  [Category("Protection")]
  public bool? AutoFormatOverride { get; set; }
  
  /// <summary>
  /// Specifies whether the document should automatically be hyphenated by the hosting application.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:autoHyphenation
  /// </remarks>
  [Category("Hyphenation")]
  public bool? AutoHyphenation { get; set; }
  
  /// <summary>
  /// Specifies if the document should be printed as signatures for booklet binding.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:bookFoldPrinting
  /// </remarks>
  [Category("Printing")]
  public bool? BookFoldPrinting { get; set; }
  
  /// <summary>
  /// Specifies the number of pages to be included in each booklet when printing signatures.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:bookFoldPrintingSheets
  /// </remarks>
  [Category("Printing")]
  public short? BookFoldPrintingSheets { get; set; }
  
  /// <summary>
  /// Specifies if pages are to be printed as signatures in reverse order.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:bookFoldRevPrinting
  /// </remarks>
  [Category("Printing")]
  public bool? BookFoldReversePrinting { get; set; }
  
  /// <summary>
  /// Specifies that the page border should not surround contents of the footer.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:bordersDoNotSurroundFooter
  /// </remarks>
  [Category("Page layout")]
  public bool? BordersDoNotSurroundFooter { get; set; }
  
  /// <summary>
  /// Specifies that the page border should not surround contents of the header.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:bordersDoNotSurroundHeader
  /// </remarks>
  [Category("Page layout")]
  public bool? BordersDoNotSurroundHeader { get; set; }

  /// <summary>
  /// Information about captions in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:captions
  /// </remarks>
  [Category("Captions")]
  public Captions? Captions { get; set; }
  
  /// <summary>
  /// Specifies how full-width characters should be compressed to remove additional whitespace.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:characterSpacingControl
  /// </remarks>
  public CharacterSpacingKind? CharacterSpacingControl { get; set; }
  
  /// <summary>
  /// Specifies how chart datapoint properties and data labels behave in all charts in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w15:chartTrackingRefBased
  /// </remarks>
  [Category("Tracking")]
  public bool? ChartTrackingRefBased { get; set; }
  
  /// <summary>
  /// Specifies the paragraph style to be applied to automatically created paragraphs with no other style.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:clickAndTypeStyle
  /// </remarks>
  public string? ClickAndTypeStyle { get; set; }

  /// <summary>
  /// Specifies the theme color mapping for the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:clrSchemeMapping
  /// </remarks>
  public DMWD.ColorSchemeMapping? ColorSchemeMapping { get; set; }

  /// <summary>
  /// Specifies a set of optional compatibility options for the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:compat
  /// </remarks>
  public Compatibility? Compatibility { get; set; }
  
  /// <summary>
  /// Specifies that the user was resolving conflicting edits when the document was saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w14:conflictMode
  /// </remarks>
  public bool? ConflictMode { get; set; }
  
  /// <summary>
  /// Specifies the maximum number of consecutive lines ending with a hyphen.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:consecutiveHyphenLimit
  /// </remarks>
  [Category("Hyphenation")]
  public ushort? ConsecutiveHyphenLimit { get; set; }
  
  /// <summary>
  /// Specifies the character to be interpreted as the radix point in fields.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:decimalSymbol
  /// </remarks>
  public string? DecimalSymbol { get; set; }
  
  /// <summary>
  /// Specifies the resolution in DPI at which images will be saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w14:defaultImageDpi
  /// </remarks>
  [Category("Images")]
  public int? DefaultImageDpi { get; set; }
  
  /// <summary>
  /// Specifies the table style to be automatically applied to newly inserted tables.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:defaultTableStyle
  /// </remarks>
  [Category("Styling")]
  public string? DefaultTableStyle { get; set; }
  
  /// <summary>
  /// Specifies the multiplier for automatic tab stops in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:defaultTabStop
  /// </remarks>
  public short? DefaultTabStop { get; set; }
  
  /// <summary>
  /// Specifies that cropped-out areas of images are not to be saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w14:discardImageEditingData
  /// </remarks>
  [Category("Images")]
  public bool? DiscardImageEditingData { get; set; }
  
  /// <summary>
  /// Specifies whether background images and colors are displayed in print layout view.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:displayBackgroundShape
  /// </remarks>
  [Category("View")]
  public bool? DisplayBackgroundShape { get; set; }
  
  /// <summary>
  /// Specifies the number of horizontal grid units allowed between visible horizontal drawing grid lines.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:displayHorizontalDrawingGridEvery
  /// </remarks>
  [Category("Document grid")]
  public int? DisplayHorizontalDrawingGrid { get; set; }
  
  /// <summary>
  /// Specifies the number of vertical grid units allowed between visible vertical drawing grid lines.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:displayVerticalDrawingGridEvery
  /// </remarks>
  [Category("Document grid")]
  public int? DisplayVerticalDrawingGrid { get; set; }
  
  /// <summary>
  /// Specifies an arbitrary identifier for the context of paragraph identifiers in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w14:docId or w15:docId
  /// </remarks>
  [Category("Identification")]
  public HexInt? DocumentId { get; set; }
  
  /// <summary>
  /// Specifies the set of document protection restrictions applied to the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:documentProtection
  /// </remarks>
  [Category("Protection")]
  public DocumentProtection? DocumentProtection { get; set; }
  
  /// <summary>
  /// Specifies the classification of the document for customized UI and formatting behaviors.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:documentType
  /// </remarks>
  public DocumentKind? DocumentType { get; set; }
  
  ///// <summary>
  ///// Specifies the presence of document variables in the document.
  ///// </summary>
  //public Variables? DocumentVariables { get; set; }
  
  /// <summary>
  /// Specifies that pictures shall not automatically be compressed when saving the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotAutoCompressPictures
  /// </remarks>
  [Category("Images")]
  public bool? DoNotAutoCompressPictures { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around invalid custom XML markup.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotDemarcateInvalidXml
  /// </remarks>
  [Category("CustomXml")]
  public bool? DoNotDemarcateInvalidXml { get; set; }
  
  /// <summary>
  /// Specifies whether header and footer contents are displayed in print layout view.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotDisplayPageBoundaries
  /// </remarks>
  [Category("View")]
  public bool? DoNotDisplayPageBoundaries { get; set; }
  
  /// <summary>
  /// Specifies whether words in all capital letters shall be hyphenated.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotHyphenateCaps
  /// </remarks>
  [Category("Hyphenation")]
  public bool? DoNotHyphenateCaps { get; set; }
  
  /// <summary>
  /// Specifies if content in text boxes, footnotes, and endnotes is excluded from document statistics.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotIncludeSubdocsInStats
  /// </remarks>
  public bool? DoNotIncludeSubdocsInStats { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around form fields.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotShadeFormData
  /// </remarks>
  public bool? DoNotShadeFormData { get; set; }
  
  /// <summary>
  /// Specifies that formatting revisions are not tracked when trackRevisions is turned on.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotTrackFormatting
  /// </remarks>
  [Category("Tracking")]
  public bool? DoNotTrackFormatting { get; set; }
  
  /// <summary>
  /// Specifies that moves are not tracked as revisions when trackRevisions is turned on.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotTrackMoves
  /// </remarks>
  [Category("Tracking")]
  public bool? DoNotTrackMoves { get; set; }
  
  /// <summary>
  /// Specifies that the top-left corner of the page is not used as the origin for the drawing grid.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotUseMarginsForDrawingGridOrigin
  /// </remarks>
  [Category("Document grid")]
  public bool? DoNotUseMarginsForDrawingGridOrigin { get; set; }
  
  /// <summary>
  /// Specifies that custom XML markup is not validated against schemas.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:doNotValidateAgainstSchema
  /// </remarks>
  [Category("CustomXml")]
  public bool? DoNotValidateAgainstSchema { get; set; }
  
  /// <summary>
  /// Specifies the origin for horizontal gridlines used by the drawing grid.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:drawingGridHorizontalOrigin
  /// </remarks>
  [Category("Document grid")]
  public Twips? DrawingGridHorizontalOrigin { get; set; }
  
  /// <summary>
  /// Specifies the width of horizontal grid units in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:drawingGridHorizontalSpacing
  /// </remarks>
  [Category("Document grid")]
  public Twips? DrawingGridHorizontalSpacing { get; set; }
  
  /// <summary>
  /// Specifies the origin for vertical gridlines used by the drawing grid.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:drawingGridVerticalOrigin
  /// </remarks>
  [Category("Document grid")]
  public Twips? DrawingGridVerticalOrigin { get; set; }
  
  /// <summary>
  /// Specifies the width of vertical grid units in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:drawingGridVerticalSpacing
  /// </remarks>
  [Category("Document grid")]
  public Twips? DrawingGridVerticalSpacing { get; set; }
  
  /// <summary>
  /// Specifies that system fonts are embedded when font embedding is enabled.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:embedSystemFonts
  /// </remarks>
  [Category("Fonts")]
  public bool? EmbedSystemFonts { get; set; }
  
  /// <summary>
  /// Specifies that fonts in use are embedded when the document is saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:embedTrueTypeFonts
  /// </remarks>
  [Category("Fonts")]
  public bool? EmbedTrueTypeFonts { get; set; }
  
  ///// <summary>
  ///// Specifies the endnote properties for the document.
  ///// </summary>
  //[Category("Footnotes and endnotes")]
  //public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }
  
  /// <summary>
  /// Specifies whether sections have different headers and footers for even and odd pages.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:evenAndOddHeaders
  /// </remarks>
  public bool? EvenAndOddHeaders { get; set; }
  
  ///// <summary>
  ///// Specifies the footnote properties for the document.
  ///// </summary>
  //[Category("Footnotes and endnotes")]
  //public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }
  
  /// <summary>
  /// Specifies that the document can be upgraded and is not limited to earlier word processing formats.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:forceUpgrade
  /// </remarks>
  public bool? ForceUpgrade { get; set; }
  
  /// <summary>
  /// Specifies that the document was last saved while placeholder text of all structured document tags was being edited.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:formsDesign
  /// </remarks>
  [Category("Forms")]
  public bool? FormsDesign { get; set; }
  
  /// <summary>
  /// Specifies that the gutter is positioned at the top of the document's pages.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:gutterAtTop
  /// </remarks>
  [Category("Printing")]
  public bool? GutterAtTop { get; set; }
  
  ///// <summary>
  ///// Specifies the default parameters for VML objects inserted in the header and footer.
  ///// </summary>
  //[Category("VML")]
  //[Obsolete]
  //public DMWV.HeaderShapeDefaults? HeaderShapeDefaults { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around grammatical errors.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:hideGrammaticalErrors
  /// </remarks>
  [Category("Proofing")]
  public bool? HideGrammaticalErrors { get; set; }
  
  /// <summary>
  /// Specifies whether a visual cue should be displayed around spelling errors.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:hideSpellingErrors
  /// </remarks>
  [Category("Proofing")]
  public bool? HideSpellingErrors { get; set; }
  
  /// <summary>
  /// Specifies the hyphenation zone used for automatic or manual hyphenation.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:hyphenationZone
  /// </remarks>
  [Category("Hyphenation")]
  public Twips? HyphenationZone { get; set; }
  
  /// <summary>
  /// Specifies that only leaf custom XML elements are validated against schemas.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:ignoreMixedContent
  /// </remarks>
  [Category("CustomXml")]
  public bool? IgnoreMixedContent { get; set; }
  
  /// <summary>
  /// Specifies that styles are updated to match the attached template when the document is opened.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:linkStyles
  /// </remarks>
  [Category("Styling")]
  public bool? LinkStyles { get; set; }
  
  /// <summary>
  /// Specifies the character used as a list item separator in fields.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:listSeparator
  /// </remarks>
  public string? ListSeparator { get; set; }
  
  ///// <summary>
  ///// Specifies all mail merge information for the document.
  ///// </summary>
  //[Category("Mailing")]
  //public MailMerge? MailMerge { get; set; }
  
  ///// <summary>
  ///// Specifies the document-level properties for all math in the document.
  ///// </summary>
  //public MathProperties? MathProperties { get; set; }
  
  /// <summary>
  /// Specifies that left and right margins are swapped on every second page.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:mirrorMargins
  /// </remarks>
  public bool? MirrorMargins { get; set; }
  
  ///// <summary>
  ///// Specifies the set of characters restricted from ending a line for custom line breaking logic.
  ///// </summary>
  //[Category("Kinsoku")]
  //public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }
  
  ///// <summary>
  ///// Specifies the set of characters restricted from beginning a new line for custom line breaking logic.
  ///// </summary>
  //[Category("Kinsoku")]
  //public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }
  
  /// <summary>
  /// Specifies that punctuation characters are not kerned when kerning is enabled.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:noPunctuationKerning
  /// </remarks>
  public bool? NoPunctuationKerning { get; set; }
  
  /// <summary>
  /// Specifies a unique identifier for a set of documents derived from a common source.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w15:persistentDocumentId
  /// </remarks>
  [Category("Identification")]
  public Guid? PersistentDocumentId { get; set; }
  
  /// <summary>
  /// Specifies that only WordprocessingML form fields are printed, suppressing all other content.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:printFormsData
  /// </remarks>
  [Category("Printing")]
  public bool? PrintFormsData { get; set; }
  
  /// <summary>
  /// Specifies that fractional character widths are used when printing the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:printFractionalCharacterWidth
  /// </remarks>
  [Category("Printing")]
  public bool? PrintFractionalCharacterWidth { get; set; }
  
  /// <summary>
  /// Specifies that PostScript codes are included in foreground with printed data.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:printPostScriptOverText
  /// </remarks>
  [Category("Printing")]
  public bool? PrintPostScriptOverText { get; set; }
  
  /// <summary>
  /// Specifies whether two pages are printed on one sheet of paper.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:printTwoOnOne
  /// </remarks>
  [Category("Printing")]
  public bool? PrintTwoOnOne { get; set; }
  
  /// <summary>
  /// Specifies if grammar and spell-checking engines completed checking before the document was last saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:proofState
  /// </remarks>
  [Category("Proofing")]
  public ProofState? ProofState { get; set; }
  
  ///// <summary>
  ///// Specifies the exact set of page and text sizing parameters for displaying the document, used for ink annotations.
  ///// </summary>
  //public DMWD.ReadModeInkLockDown? ReadModeInkLockDown { get; set; }
  
  /// <summary>
  /// Specifies that date and time information is removed from all annotations when the document is saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:removeDateAndTime
  /// </remarks>
  [Category("Protection")]
  public bool? RemoveDateAndTime { get; set; }
  
  /// <summary>
  /// Specifies that all personal information of document authors is removed upon saving.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:removePersonalInformation
  /// </remarks>
  [Category("Protection")]
  public bool? RemovePersonalInformation { get; set; }
  
  /// <summary>
  /// Specifies which forms of annotations are visible when the document is displayed.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:revisionView
  /// </remarks>
  [Category("View")]
  public RevisionView? RevisionView { get; set; }
  
  ///// <summary>
  ///// Specifies the set of revision save ID values for the current document.
  ///// </summary>
  //[Category("Tracking")]
  //public Rsids? Rsids { get; set; }
  
  /// <summary>
  /// Specifies that only WordprocessingML form fields are saved in a comma-delimited text format.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:saveFormsData
  /// </remarks>
  [Category("Forms")]
  public bool? SaveFormsData { get; set; }
  
  /// <summary>
  /// Specifies that the document can be saved as a single XML file even when its contents are invalid based on XML schema validation.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:saveInvalidXml
  /// </remarks>
  [Category("CustomXml")]
  public bool? SaveInvalidXml { get; set; }
  
  /// <summary>
  /// Specifies if a document's thumbnail part should be generated for the first page when saved.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:savePreviewPicture
  /// </remarks>
  public bool? SavePreviewPicture { get; set; }
  
  /// <summary>
  /// Specifies that fonts are subsetted when font embedding is enabled.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:saveSubsetFonts
  /// </remarks>
  [Category("Fonts")]
  public bool? SaveSubsetFonts { get; set; }
  
  ///// <summary>
  ///// Specifies the location of a custom XSL transform to be used when saving as a single XML file.
  ///// </summary>
  //[Category("Xslt")]
  //public SaveThroughXslt? SaveThroughXslt { get; set; }
  
  ///// <summary>
  ///// Specifies that only custom XML markup is saved as an XML file.
  ///// </summary>
  //[Category("CustomXml")]
  //public bool? SaveXmlDataOnly { get; set; }
  
  ///// <summary>
  ///// Specifies the set of XML namespaces associated with custom XML markup in the document.
  ///// </summary>
  //[Category("CustomXml")]
  //public SchemaLibrary? SchemaLibrary { get; set; }
  
  ///// <summary>
  ///// Specifies the defaults used when creating new shapes, stored once per document.
  ///// </summary>
  //[Category("VML")]
  //[Obsolete]
  //public DMWD.ShapeDefaults? ShapeDefaults { get; set; }
  
  /// <summary>
  /// Specifies that an e-mail message header is displayed when the document is opened.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:showEnvelope
  /// </remarks>
  [Category("Mailing")]
  public bool? ShowEnvelope { get; set; }
  
  /// <summary>
  /// Specifies that a visual indicator is provided for the start and end locations of custom XML markup.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:showXMLTags
  /// </remarks>
  [Category("CustomXml")]
  public bool? ShowXmlTags { get; set; }
  
  /// <summary>
  /// Specifies that the strict set of Kinsoku rules is applied to Japanese text in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:strictFirstAndLastChars
  /// </remarks>
  [Category("Kinsoku")]
  public bool? StrictFirstAndLastChars { get; set; }
  
  ///// <summary>
  ///// Specifies suggested filters to be applied to the list of document styles in the application UI.
  ///// </summary>
  //[Category("Styling")]
  //public StylePaneFormatFilter? StylePaneFormatFilter { get; set; }
  
  /// <summary>
  /// Specifies a sorting to be applied to the list of styles in the document UI.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:stylePaneSortMethod
  /// </remarks>
  [Category("Styling")]
  public string? StylePaneSortMethods { get; set; }
  
  /// <summary>
  /// Specifies the size for automatic document summaries performed on the content of the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:summaryLength
  /// </remarks>
  public Percent? SummaryLength { get; set; }
  
  ///// <summary>
  ///// Specifies the language used to determine theme fonts in the document's Theme part.
  ///// </summary>
  //[Category("Fonts")]
  //public Languages? ThemeFontLanguages { get; set; }
  
  /// <summary>
  /// Specifies that revisions are tracked in the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:trackRevisions
  /// </remarks>
  [Category("Tracking")]
  public bool? TrackRevisions { get; set; }
  
  /// <summary>
  /// Disables features incompatible with earlier word processing formats.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:uiCompat97To2003
  /// </remarks>
  public bool? UICompatibleWith97To2003 { get; set; }
  
  /// <summary>
  /// Specifies whether fields should automatically have their result recalculated when the document is opened.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:updateFields
  /// </remarks>
  [Category("Protection")]
  public bool? UpdateFieldsOnOpen { get; set; }
  
  /// <summary>
  /// Specifies that the document should be saved through the custom XSLT transform when saved as a single XML file.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:useXSLTWhenSaving
  /// </remarks>
  [Category("Xslt")]
  public bool? UseXsltWhenSaving { get; set; }
  
  /// <summary>
  /// Specifies the manner in which the document should be displayed when opened by an application.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:view
  /// </remarks>
  [Category("View")]
  public ViewKind? View { get; set; }
  
  /// <summary>
  /// Specifies the write protection settings applied to the document.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:writeProtection
  /// </remarks>
  [Category("Protection")]
  public WriteProtection? WriteProtection { get; set; }
  
  /// <summary>
  /// Specifies the magnification level to be applied when the document is displayed.
  /// </summary>
  /// <remarks>
  /// Represents the following element tag in the schema: w:zoom
  /// </remarks>
  [Category("View")]
  public Zoom? Zoom { get; set; }
}