using DocumentModel.CustomXml;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies all document-level properties which affect the handling of the current document.
/// This class provides access to settings for proofing, borders, custom XML,
/// templates, protection, printing, captions, compatibility, styles, and more,
/// enabling advanced configuration and management of Wordprocessing document behavior and appearance.
/// </summary>
[OpenXmlType(typeof(DXW.Settings))]
public sealed partial class DocumentSettings : ModelElement<DXW.Settings>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public DocumentSettings()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "document">Wordprocessing document model</param>
 public DocumentSettings(Wordprocessing.Document document)
 {
  if (document.WordprocessingDocument != null)
   AttachAndLoad(document.WordprocessingDocument);
 }

 //public override void LoadData(object openXmlElement)
 //{
 //    base.LoadData(openXmlElement);
 //}
 //public override void UpdateData(object openXmlElement)
 //{
 //    base.UpdateData(openXmlElement);
 //}
 /// <summary>
 /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's PackageProperties.
 /// </summary>
 /// <param name = "wordprocessingDocument">Document to attach to.</param>
 public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
 {
  base.AttachAndLoad(wordprocessingDocument);
  var documentSettings = wordprocessingDocument.GetDocumentSettings();
  SetOpenXmlElement(documentSettings);
  LoadData(documentSettings);
 }

 /// <summary>
 /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
 /// </summary>
 /// <param name = "wordprocessingDocument">Document to attach to.</param>
 public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
 {
  base.AttachAndUpdate(wordprocessingDocument);
  var documentSettings = wordprocessingDocument.GetDocumentSettings();
  SetOpenXmlElement(documentSettings);
  UpdateData(documentSettings);
 }

 /// <summary>
 /// Information about the parameters of the grammar checking performed on the contents of the current document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:activeWritingStyle
 /// </remarks>
 [Category("Proofing")]
 [OpenXmlElementCollection(typeof(DXW.ActiveWritingStyle))]
 public ActiveWritingStyles? ActiveWritingStyles { get => _ActiveWritingStyles; set => UpdateField(ref _ActiveWritingStyles, value, nameof(ActiveWritingStyle)); }

 private ActiveWritingStyles? _ActiveWritingStyles;
 /// <summary>
 /// Specifies that paragraph and table borders shall be adjusted to align with page borders if spacing is less than or equal to 10.5 points.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:alignBordersAndEdges
 /// </remarks>
 [Category("Page layout")]
 [OpenXmlProperty(nameof(DXW.Settings.AlignBorderAndEdges))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? AlignBorderAndEdges { get => _AlignBorderAndEdges; set => UpdateField(ref _AlignBorderAndEdges, value, nameof(AlignBorderAndEdges)); }

 private bool? _AlignBorderAndEdges;
 /// <summary>
 /// Specifies whether custom XML markup with no associated namespace is treated as an error and moved into a special error namespace.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:alwaysMergeEmptyNamespace
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.AlwaysMergeEmptyNamespace))]
 public bool? AlwaysMergeEmptyNamespace { get => _AlwaysMergeEmptyNamespace; set => UpdateField(ref _AlwaysMergeEmptyNamespace, value, nameof(AlwaysMergeEmptyNamespace)); }

 private bool? _AlwaysMergeEmptyNamespace;
 /// <summary>
 /// Specifies that custom XML elements always show placeholder text when they contain no run content.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:alwaysShowPlaceholderText
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.AlwaysShowPlaceholderText))]
 public bool? AlwaysShowPlaceholderText { get => _AlwaysShowPlaceholderText; set => UpdateField(ref _AlwaysShowPlaceholderText, value, nameof(AlwaysShowPlaceholderText)); }

 private bool? _AlwaysShowPlaceholderText;
 /// <summary>
 /// Specifies the custom XML schemas to be associated with this document when loaded.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:attachedSchema
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElementCollection(typeof(AttachedSchema))]
 public AttachedSchemas? AttachedSchemas { get => _AttachedSchemas; set => UpdateField(ref _AttachedSchemas, value, nameof(AttachedSchemas)); }

 private AttachedSchemas? _AttachedSchemas;
 /// <summary>
 /// Specifies the location of a document template to be attached to the current document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:attachedTemplate
 /// </remarks>
 [Category("Template")]
 [OpenXmlElement]
 public AttachedTemplate? AttachedTemplate { get => _AttachedTemplate; set => UpdateField(ref _AttachedTemplate, value, nameof(AttachedTemplate)); }

 private AttachedTemplate? _AttachedTemplate;
 /// <summary>
 /// Specifies whether automatically applied formatting can override formatting protection.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:autoFormatOverride
 /// </remarks>
 [Category("Protection")]
 [OpenXmlElement(typeof(DXW.AutoFormatOverride))]
 public bool? AutoFormatOverride { get => _AutoFormatOverride; set => UpdateField(ref _AutoFormatOverride, value, nameof(AutoFormatOverride)); }

 private bool? _AutoFormatOverride;
 /// <summary>
 /// Specifies whether the document should automatically be hyphenated by the hosting application.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:autoHyphenation
 /// </remarks>
 [Category("Hyphenation")]
 [OpenXmlElement(typeof(DXW.AutoHyphenation))]
 public bool? AutoHyphenation { get => _AutoHyphenation; set => UpdateField(ref _AutoHyphenation, value, nameof(AutoHyphenation)); }

 private bool? _AutoHyphenation;
 /// <summary>
 /// Specifies if the document should be printed as signatures for booklet binding.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:bookFoldPrinting
 /// </remarks>
 [Category("Printing")]
 [OpenXmlElement(typeof(DXW.BookFoldPrinting))]
 public bool? BookFoldPrinting { get => _BookFoldPrinting; set => UpdateField(ref _BookFoldPrinting, value, nameof(BookFoldPrinting)); }

 private bool? _BookFoldPrinting;
 /// <summary>
 /// Specifies the number of pages to be included in each booklet when printing signatures.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:bookFoldPrintingSheets
 /// </remarks>
 [Category("Printing")]
 [OpenXmlElement(typeof(DXW.BookFoldPrintingSheets))]
 public short? BookFoldPrintingSheets { get => _BookFoldPrintingSheets; set => UpdateField(ref _BookFoldPrintingSheets, value, nameof(BookFoldPrintingSheets)); }

 private short? _BookFoldPrintingSheets;
 /// <summary>
 /// Specifies if pages are to be printed as signatures in reverse order.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:bookFoldRevPrinting
 /// </remarks>
 [Category("Printing")]
 [OpenXmlElement(typeof(DXW.BookFoldReversePrinting))]
 public bool? BookFoldReversePrinting { get => _BookFoldReversePrinting; set => UpdateField(ref _BookFoldReversePrinting, value, nameof(BookFoldReversePrinting)); }

 private bool? _BookFoldReversePrinting;
 /// <summary>
 /// Specifies that the page border should not surround contents of the footer.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:bordersDoNotSurroundFooter
 /// </remarks>
 [Category("Page layout")]
 [OpenXmlProperty(nameof(DXW.Settings.BordersDoNotSurroundFooter))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? BordersDoNotSurroundFooter { get => _BordersDoNotSurroundFooter; set => UpdateField(ref _BordersDoNotSurroundFooter, value, nameof(BordersDoNotSurroundFooter)); }

 private bool? _BordersDoNotSurroundFooter;
 /// <summary>
 /// Specifies that the page border should not surround contents of the header.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:bordersDoNotSurroundHeader
 /// </remarks>
 [Category("Page layout")]
 [OpenXmlProperty(nameof(DXW.Settings.BordersDoNotSurroundHeader))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? BordersDoNotSurroundHeader { get => _BordersDoNotSurroundHeader; set => UpdateField(ref _BordersDoNotSurroundHeader, value, nameof(BordersDoNotSurroundHeader)); }

 private bool? _BordersDoNotSurroundHeader;
 /// <summary>
 /// Information about captions in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:captions
 /// </remarks>
 [Category("Captions")]
 [OpenXmlElement(typeof(DXW.Captions))]
 public Captions? Captions { get => _Captions; set => UpdateField(ref _Captions, value, nameof(Captions)); }

 private Captions? _Captions;
 /// <summary>
 /// Specifies how full-width characters should be compressed to remove additional whitespace.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:characterSpacingControl
 /// </remarks>
 [Category("Wordprocessing")]
 [OpenXmlElement(typeof(DXW.CharacterSpacingControl))]
 public CharacterSpacingKind? CharacterSpacingControl { get => _CharacterSpacingControl; set => UpdateField(ref _CharacterSpacingControl, value, nameof(CharacterSpacingControl)); }

 private CharacterSpacingKind? _CharacterSpacingControl;
 /// <summary>
 /// Specifies how chart datapoint properties and data labels behave in all charts in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w15:chartTrackingRefBased
 /// </remarks>
 [Category("Tracking")]
 [OpenXmlElement(typeof(DXO13W.ChartTrackingRefBased))]
 public bool? ChartTrackingRefBased { get => _ChartTrackingRefBased; set => UpdateField(ref _ChartTrackingRefBased, value, nameof(ChartTrackingRefBased)); }

 private bool? _ChartTrackingRefBased;
 /// <summary>
 /// Specifies the paragraph style to be applied to automatically created paragraphs with no other style.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:clickAndTypeStyle
 /// </remarks>
 [Category("Styling")]
 [OpenXmlElement(typeof(DXW.ClickAndTypeStyle))]
 public string? ClickAndTypeStyle { get => _ClickAndTypeStyle; set => UpdateField(ref _ClickAndTypeStyle, value, nameof(ClickAndTypeStyle)); }

 private string? _ClickAndTypeStyle;
 /// <summary>
 /// Specifies the theme color mapping for the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:clrSchemeMapping
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DMWD.ColorSchemeMapping))]
 public DMWD.ColorSchemeMapping? ColorSchemeMapping { get => _ColorSchemeMapping; set => UpdateField(ref _ColorSchemeMapping, value, nameof(ColorSchemeMapping)); }

 private DMWD.ColorSchemeMapping? _ColorSchemeMapping;
 /// <summary>
 /// Specifies a set of optional compatibility options for the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:compat
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.Compatibility))]
 public Compatibility? Compatibility { get => _Compatibility; set => UpdateField(ref _Compatibility, value, nameof(Compatibility)); }

 private Compatibility? _Compatibility;
 /// <summary>
 /// Specifies that the user was resolving conflicting edits when the document was saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w14:conflictMode
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXO10W.ConflictMode))]
 public bool? ConflictMode { get => _ConflictMode; set => UpdateField(ref _ConflictMode, value, nameof(ConflictMode)); }

 private bool? _ConflictMode;
 /// <summary>
 /// Specifies the maximum number of consecutive lines ending with a hyphen.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:consecutiveHyphenLimit
 /// </remarks>
 [Category("Hyphenation")]
 [OpenXmlElement(typeof(DXW.ConsecutiveHyphenLimit))]
 public ushort? ConsecutiveHyphenLimit { get => _ConsecutiveHyphenLimit; set => UpdateField(ref _ConsecutiveHyphenLimit, value, nameof(ConsecutiveHyphenLimit)); }

 private ushort? _ConsecutiveHyphenLimit;
 /// <summary>
 /// Specifies the character to be interpreted as the radix point in fields.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:decimalSymbol
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.DecimalSymbol))]
 public string? DecimalSymbol { get => _DecimalSymbol; set => UpdateField(ref _DecimalSymbol, value, nameof(DecimalSymbol)); }

 private string? _DecimalSymbol;
 /// <summary>
 /// Specifies the resolution in DPI at which images will be saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w14:defaultImageDpi
 /// </remarks>
 [Category("Images")]
 [OpenXmlElement(typeof(DXO10W.DefaultImageDpi))]
 public int? DefaultImageDpi { get => _DefaultImageDpi; set => UpdateField(ref _DefaultImageDpi, value, nameof(DefaultImageDpi)); }

 private int? _DefaultImageDpi;
 /// <summary>
 /// Specifies the table style to be automatically applied to newly inserted tables.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:defaultTableStyle
 /// </remarks>
 [Category("Styling")]
 [OpenXmlElement(typeof(DXW.DefaultTableStyle))]
 public string? DefaultTableStyle { get => _DefaultTableStyle; set => UpdateField(ref _DefaultTableStyle, value, nameof(DefaultTableStyle)); }

 private string? _DefaultTableStyle;
 /// <summary>
 /// Specifies the multiplier for automatic tab stops in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:defaultTabStop
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.DefaultTabStop))]
 public short? DefaultTabStop { get => _DefaultTabStop; set => UpdateField(ref _DefaultTabStop, value, nameof(DefaultTabStop)); }

 private short? _DefaultTabStop;
 /// <summary>
 /// Specifies that cropped-out areas of images are not to be saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w14:discardImageEditingData
 /// </remarks>
 [Category("Images")]
 [OpenXmlElement(typeof(DXO10W.DiscardImageEditingData))]
 public bool? DiscardImageEditingData { get => _DiscardImageEditingData; set => UpdateField(ref _DiscardImageEditingData, value, nameof(DiscardImageEditingData)); }

 private bool? _DiscardImageEditingData;
 /// <summary>
 /// Specifies whether background images and colors are displayed in print layout view.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:displayBackgroundShape
 /// </remarks>
 [Category("View")]
 [OpenXmlProperty(nameof(DXW.Settings.DisplayBackgroundShape))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? DisplayBackgroundShape { get => _DisplayBackgroundShape; set => UpdateField(ref _DisplayBackgroundShape, value, nameof(DisplayBackgroundShape)); }

 private bool? _DisplayBackgroundShape;
 /// <summary>
 /// Specifies the number of horizontal grid units allowed between visible horizontal drawing grid lines.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:displayHorizontalDrawingGridEvery
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DisplayHorizontalDrawingGrid))]
 public int? DisplayHorizontalDrawingGrid { get => _DisplayHorizontalDrawingGrid; set => UpdateField(ref _DisplayHorizontalDrawingGrid, value, nameof(DisplayHorizontalDrawingGrid)); }

 private int? _DisplayHorizontalDrawingGrid;
 /// <summary>
 /// Specifies the number of vertical grid units allowed between visible vertical drawing grid lines.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:displayVerticalDrawingGridEvery
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DisplayVerticalDrawingGrid))]
 public int? DisplayVerticalDrawingGrid { get => _DisplayVerticalDrawingGrid; set => UpdateField(ref _DisplayVerticalDrawingGrid, value, nameof(DisplayVerticalDrawingGrid)); }

 private int? _DisplayVerticalDrawingGrid;
 /// <summary>
 /// Specifies an arbitrary identifier for the context of paragraph identifiers in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w14:docId or w15:docId
 /// </remarks>
 [Category("Identification")]
 [OpenXmlElement(typeof(DXO10W.DocumentId))]
 public HexInt? DocumentId { get => _DocumentId; set => UpdateField(ref _DocumentId, value, nameof(DocumentId)); }

 private HexInt? _DocumentId;
 /// <summary>
 /// Specifies the set of document protection restrictions applied to the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:documentProtection
 /// </remarks>
 [Category("Protection")]
 [OpenXmlElement(typeof(DXW.DocumentProtection))]
 public DocumentProtection? DocumentProtection { get => _DocumentProtection; set => UpdateField(ref _DocumentProtection, value, nameof(DocumentProtection)); }

 private DocumentProtection? _DocumentProtection;
 /// <summary>
 /// Specifies the classification of the document for customized UI and formatting behaviors.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:documentType
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.DocumentType))]
 public DocumentKind? DocumentType { get => _DocumentType; set => UpdateField(ref _DocumentType, value, nameof(DocumentType)); }

 private DocumentKind? _DocumentType;
 /// <summary>
 /// Specifies that pictures shall not automatically be compressed when saving the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotAutoCompressPictures
 /// </remarks>
 [Category("Images")]
 [OpenXmlElement(typeof(DXW.DoNotAutoCompressPictures))]
 public bool? DoNotAutoCompressPictures { get => _DoNotAutoCompressPictures; set => UpdateField(ref _DoNotAutoCompressPictures, value, nameof(DoNotAutoCompressPictures)); }

 private bool? _DoNotAutoCompressPictures;
 /// <summary>
 /// Specifies whether a visual cue should be displayed around invalid custom XML markup.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotDemarcateInvalidXml
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.DoNotDemarcateInvalidXml))]
 public bool? DoNotDemarcateInvalidXml { get => _DoNotDemarcateInvalidXml; set => UpdateField(ref _DoNotDemarcateInvalidXml, value, nameof(DoNotDemarcateInvalidXml)); }

 private bool? _DoNotDemarcateInvalidXml;
 /// <summary>
 /// Specifies whether header and footer contents are displayed in print layout view.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotDisplayPageBoundaries
 /// </remarks>
 [Category("View")]
 [OpenXmlProperty(nameof(DXW.Settings.DoNotDisplayPageBoundaries))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? DoNotDisplayPageBoundaries { get => _DoNotDisplayPageBoundaries; set => UpdateField(ref _DoNotDisplayPageBoundaries, value, nameof(DoNotDisplayPageBoundaries)); }

 private bool? _DoNotDisplayPageBoundaries;
 /// <summary>
 /// Specifies whether words in all capital letters shall be hyphenated.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotHyphenateCaps
 /// </remarks>
 [Category("Hyphenation")]
 [OpenXmlElement(typeof(DXW.DoNotHyphenateCaps))]
 public bool? DoNotHyphenateCaps { get => _DoNotHyphenateCaps; set => UpdateField(ref _DoNotHyphenateCaps, value, nameof(DoNotHyphenateCaps)); }

 private bool? _DoNotHyphenateCaps;
 /// <summary>
 /// Specifies if content in text boxes, footnotes, and endnotes is excluded from document statistics.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotIncludeSubdocsInStats
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.DoNotIncludeSubdocsInStats))]
 public bool? DoNotIncludeSubdocsInStats { get => _DoNotIncludeSubdocsInStats; set => UpdateField(ref _DoNotIncludeSubdocsInStats, value, nameof(DoNotIncludeSubdocsInStats)); }

 private bool? _DoNotIncludeSubdocsInStats;
 /// <summary>
 /// Specifies whether a visual cue should be displayed around form fields.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotShadeFormData
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.DoNotShadeFormData))]
 public bool? DoNotShadeFormData { get => _DoNotShadeFormData; set => UpdateField(ref _DoNotShadeFormData, value, nameof(DoNotShadeFormData)); }

 private bool? _DoNotShadeFormData;
 /// <summary>
 /// Specifies that formatting revisions are not tracked when trackRevisions is turned on.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotTrackFormatting
 /// </remarks>
 [Category("Tracking")]
 [OpenXmlElement(typeof(DXW.DoNotTrackFormatting))]
 public bool? DoNotTrackFormatting { get => _DoNotTrackFormatting; set => UpdateField(ref _DoNotTrackFormatting, value, nameof(DoNotTrackFormatting)); }

 private bool? _DoNotTrackFormatting;
 /// <summary>
 /// Specifies that moves are not tracked as revisions when trackRevisions is turned on.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotTrackMoves
 /// </remarks>
 [Category("Tracking")]
 [OpenXmlElement(typeof(DXW.DoNotTrackMoves))]
 public bool? DoNotTrackMoves { get => _DoNotTrackMoves; set => UpdateField(ref _DoNotTrackMoves, value, nameof(DoNotTrackMoves)); }

 private bool? _DoNotTrackMoves;
 /// <summary>
 /// Specifies that the top-left corner of the page is not used as the origin for the drawing grid.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotUseMarginsForDrawingGridOrigin
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DoNotUseMarginsForDrawingGridOrigin))]
 public bool? DoNotUseMarginsForDrawingGridOrigin { get => _DoNotUseMarginsForDrawingGridOrigin; set => UpdateField(ref _DoNotUseMarginsForDrawingGridOrigin, value, nameof(DoNotUseMarginsForDrawingGridOrigin)); }

 private bool? _DoNotUseMarginsForDrawingGridOrigin;
 /// <summary>
 /// Specifies that custom XML markup is not validated against schemas.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:doNotValidateAgainstSchema
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.DoNotValidateAgainstSchema))]
 public bool? DoNotValidateAgainstSchema { get => _DoNotValidateAgainstSchema; set => UpdateField(ref _DoNotValidateAgainstSchema, value, nameof(DoNotValidateAgainstSchema)); }

 private bool? _DoNotValidateAgainstSchema;
 /// <summary>
 /// Specifies the origin for horizontal gridlines used by the drawing grid.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:drawingGridHorizontalOrigin
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DrawingGridHorizontalOrigin))]
 public Twips? DrawingGridHorizontalOrigin { get => _DrawingGridHorizontalOrigin; set => UpdateField(ref _DrawingGridHorizontalOrigin, value, nameof(DrawingGridHorizontalOrigin)); }

 private Twips? _DrawingGridHorizontalOrigin;
 /// <summary>
 /// Specifies the width of horizontal grid units in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:drawingGridHorizontalSpacing
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DrawingGridHorizontalSpacing))]
 public Twips? DrawingGridHorizontalSpacing { get => _DrawingGridHorizontalSpacing; set => UpdateField(ref _DrawingGridHorizontalSpacing, value, nameof(DrawingGridHorizontalSpacing)); }

 private Twips? _DrawingGridHorizontalSpacing;
 /// <summary>
 /// Specifies the origin for vertical gridlines used by the drawing grid.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:drawingGridVerticalOrigin
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DrawingGridVerticalOrigin))]
 public Twips? DrawingGridVerticalOrigin { get => _DrawingGridVerticalOrigin; set => UpdateField(ref _DrawingGridVerticalOrigin, value, nameof(DrawingGridVerticalOrigin)); }

 private Twips? _DrawingGridVerticalOrigin;
 /// <summary>
 /// Specifies the width of vertical grid units in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:drawingGridVerticalSpacing
 /// </remarks>
 [Category("Document grid")]
 [OpenXmlElement(typeof(DXW.DrawingGridVerticalSpacing))]
 public Twips? DrawingGridVerticalSpacing { get => _DrawingGridVerticalSpacing; set => UpdateField(ref _DrawingGridVerticalSpacing, value, nameof(DrawingGridVerticalSpacing)); }

 private Twips? _DrawingGridVerticalSpacing;
 /// <summary>
 /// Specifies that system fonts are embedded when font embedding is enabled.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:embedSystemFonts
 /// </remarks>
 [Category("Fonts")]
 [OpenXmlProperty(nameof(DXW.Settings.EmbedSystemFonts))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? EmbedSystemFonts { get => _EmbedSystemFonts; set => UpdateField(ref _EmbedSystemFonts, value, nameof(EmbedSystemFonts)); }

 private bool? _EmbedSystemFonts;
 /// <summary>
 /// Specifies that fonts in use are embedded when the document is saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:embedTrueTypeFonts
 /// </remarks>
 [Category("Fonts")]
 [OpenXmlProperty(nameof(DXW.Settings.EmbedTrueTypeFonts))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? EmbedTrueTypeFonts { get => _EmbedTrueTypeFonts; set => UpdateField(ref _EmbedTrueTypeFonts, value, nameof(EmbedTrueTypeFonts)); }

 private bool? _EmbedTrueTypeFonts;
 /// <summary>
 /// Specifies the endnote properties for the document.
 /// </summary>
 [Category("Footnotes and endnotes")]
 [OpenXmlElement(typeof(DXW.EndnoteDocumentWideProperties))]
 public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get => _EndnoteDocumentWideProperties; set => UpdateField(ref _EndnoteDocumentWideProperties, value, nameof(EndnoteDocumentWideProperties)); }

 private EndnoteDocumentWideProperties? _EndnoteDocumentWideProperties;
 /// <summary>
 /// Specifies whether sections have different headers and footers for even and odd pages.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:evenAndOddHeaders
 /// </remarks>
 [Category("Pagination")]
 [OpenXmlElement(typeof(DXW.EvenAndOddHeaders))]
 public bool? EvenAndOddHeaders { get => _EvenAndOddHeaders; set => UpdateField(ref _EvenAndOddHeaders, value, nameof(EvenAndOddHeaders)); }

 private bool? _EvenAndOddHeaders;
 /// <summary>
 /// Specifies the footnote properties for the document.
 /// </summary>
 [Category("Footnotes and endnotes")]
 [OpenXmlElement(typeof(DXW.FootnoteDocumentWideProperties))]
 public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get => _FootnoteDocumentWideProperties; set => UpdateField(ref _FootnoteDocumentWideProperties, value, nameof(FootnoteDocumentWideProperties)); }

 private FootnoteDocumentWideProperties? _FootnoteDocumentWideProperties;
 /// <summary>
 /// Specifies that the document can be upgraded and is not limited to earlier word processing formats.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:forceUpgrade
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.ForceUpgrade))]
 public bool? ForceUpgrade { get => _ForceUpgrade; set => UpdateField(ref _ForceUpgrade, value, nameof(ForceUpgrade)); }

 private bool? _ForceUpgrade;
 /// <summary>
 /// Specifies that the document was last saved while placeholder text of all structured document tags was being edited.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:formsDesign
 /// </remarks>
 [Category("Forms")]
 [OpenXmlElement(typeof(DXW.FormsDesign))]
 public bool? FormsDesign { get => _FormsDesign; set => UpdateField(ref _FormsDesign, value, nameof(FormsDesign)); }

 private bool? _FormsDesign;
 /// <summary>
 /// Specifies that the gutter is positioned at the top of the document's pages.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:gutterAtTop
 /// </remarks>
 [Category("Printing")]
 [OpenXmlProperty(nameof(DXW.Settings.GutterAtTop))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? GutterAtTop { get => _GutterAtTop; set => UpdateField(ref _GutterAtTop, value, nameof(GutterAtTop)); }

 private bool? _GutterAtTop;
 /// <summary>
 /// Specifies the default parameters for VML objects inserted in the header and footer.
 /// </summary>
 [Category("VML")]
 [OpenXmlElement(typeof(DMWV.HeaderShapeDefaults))]
 public DMWV.HeaderShapeDefaults? HeaderShapeDefaults { get => _HeaderShapeDefaults; set => UpdateField(ref _HeaderShapeDefaults, value, nameof(HeaderShapeDefaults)); }

 private DMWV.HeaderShapeDefaults? _HeaderShapeDefaults;
 /// <summary>
 /// Specifies whether a visual cue should be displayed around grammatical errors.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:hideGrammaticalErrors
 /// </remarks>
 [Category("Proofing")]
 [OpenXmlProperty(nameof(DXW.Settings.HideGrammaticalErrors))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? HideGrammaticalErrors { get => _HideGrammaticalErrors; set => UpdateField(ref _HideGrammaticalErrors, value, nameof(HideGrammaticalErrors)); }

 private bool? _HideGrammaticalErrors;
 /// <summary>
 /// Specifies whether a visual cue should be displayed around spelling errors.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:hideSpellingErrors
 /// </remarks>
 [Category("Proofing")]
 [OpenXmlProperty(nameof(DXW.Settings.HideSpellingErrors))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? HideSpellingErrors { get => _HideSpellingErrors; set => UpdateField(ref _HideSpellingErrors, value, nameof(HideSpellingErrors)); }

 private bool? _HideSpellingErrors;
 /// <summary>
 /// Specifies the hyphenation zone used for automatic or manual hyphenation.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:hyphenationZone
 /// </remarks>
 [Category("Hyphenation")]
 [OpenXmlElement(typeof(DXW.HyphenationZone))]
 public Twips? HyphenationZone { get => _HyphenationZone; set => UpdateField(ref _HyphenationZone, value, nameof(HyphenationZone)); }

 private Twips? _HyphenationZone;
 /// <summary>
 /// Specifies that only leaf custom XML elements are validated against schemas.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:ignoreMixedContent
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.IgnoreMixedContent))]
 public bool? IgnoreMixedContent { get => _IgnoreMixedContent; set => UpdateField(ref _IgnoreMixedContent, value, nameof(IgnoreMixedContent)); }

 private bool? _IgnoreMixedContent;
 /// <summary>
 /// Specifies that styles are updated to match the attached template when the document is opened.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:linkStyles
 /// </remarks>
 [Category("Styling")]
 [OpenXmlElement(typeof(DXW.LinkStyles))]
 public bool? LinkStyles { get => _LinkStyles; set => UpdateField(ref _LinkStyles, value, nameof(LinkStyles)); }

 private bool? _LinkStyles;
 /// <summary>
 /// Specifies the character used as a list item separator in fields.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:listSeparator
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.ListSeparator))]
 public string? ListSeparator { get => _ListSeparator; set => UpdateField(ref _ListSeparator, value, nameof(ListSeparator)); }

 private string? _ListSeparator;
 /// <summary>
 /// Specifies that left and right margins are swapped on every second page.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:mirrorMargins
 /// </remarks>
 [Category("Pagination")]
 [OpenXmlElement(typeof(DXW.MirrorMargins))]
 /// <summary>
 /// Specifies that left and right margins are swapped on every second page.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:mirrorMargins
 /// </remarks>
 [OpenXmlProperty(nameof(DXW.Settings.MirrorMargins))]
 public bool? MirrorMargins { get => _MirrorMargins; set => UpdateField(ref _MirrorMargins, value, nameof(MirrorMargins)); }

 private bool? _MirrorMargins;
 /// <summary>
 /// Specifies the set of characters restricted from ending a line for custom line breaking logic.
 /// </summary>
 [Category("Kinsoku")]
 [OpenXmlElement(typeof(DXW.NoLineBreaksAfterKinsoku))]
 public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get => _NoLineBreaksAfterKinsoku; set => UpdateField(ref _NoLineBreaksAfterKinsoku, value, nameof(NoLineBreaksAfterKinsoku)); }

 private NoLineBreaksAfterKinsoku? _NoLineBreaksAfterKinsoku;
 /// <summary>
 /// Specifies the set of characters restricted from beginning a new line for custom line breaking logic.
 /// </summary>
 [Category("Kinsoku")]
 [OpenXmlElement(typeof(DXW.NoLineBreaksBeforeKinsoku))]
 public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get => _NoLineBreaksBeforeKinsoku; set => UpdateField(ref _NoLineBreaksBeforeKinsoku, value, nameof(NoLineBreaksBeforeKinsoku)); }

 private NoLineBreaksBeforeKinsoku? _NoLineBreaksBeforeKinsoku;
 /// <summary>
 /// Specifies that punctuation characters are not kerned when kerning is enabled.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:noPunctuationKerning
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.NoPunctuationKerning))]
 public bool? NoPunctuationKerning { get => _NoPunctuationKerning; set => UpdateField(ref _NoPunctuationKerning, value, nameof(NoPunctuationKerning)); }

 private bool? _NoPunctuationKerning;
 /// <summary>
 /// Specifies a unique identifier for a set of documents derived from a common source.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w15:persistentDocumentId
 /// </remarks>
 [Category("Identification")]
 [OpenXmlElement(typeof(DXO13W.PersistentDocumentId))]
 public Guid? PersistentDocumentId { get => _PersistentDocumentId; set => UpdateField(ref _PersistentDocumentId, value, nameof(PersistentDocumentId)); }

 private Guid? _PersistentDocumentId;
 /// <summary>
 /// Specifies that only WordprocessingML form fields are printed, suppressing all other content.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:printFormsData
 /// </remarks>
 [Category("Printing")]
 [OpenXmlProperty(nameof(DXW.Settings.PrintFormsData))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? PrintFormsData { get => _PrintFormsData; set => UpdateField(ref _PrintFormsData, value, nameof(PrintFormsData)); }

 private bool? _PrintFormsData;
 /// <summary>
 /// Specifies that fractional character widths are used when printing the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:printFractionalCharacterWidth
 /// </remarks>
 [Category("Printing")]
 [OpenXmlProperty(nameof(DXW.Settings.PrintFractionalCharacterWidth))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? PrintFractionalCharacterWidth { get => _PrintFractionalCharacterWidth; set => UpdateField(ref _PrintFractionalCharacterWidth, value, nameof(PrintFractionalCharacterWidth)); }

 private bool? _PrintFractionalCharacterWidth;
 /// <summary>
 /// Specifies that PostScript codes are included in foreground with printed data.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:printPostScriptOverText
 /// </remarks>
 [Category("Printing")]
 [OpenXmlProperty(nameof(DXW.Settings.PrintPostScriptOverText))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? PrintPostScriptOverText { get => _PrintPostScriptOverText; set => UpdateField(ref _PrintPostScriptOverText, value, nameof(PrintPostScriptOverText)); }

 private bool? _PrintPostScriptOverText;
 /// <summary>
 /// Specifies whether two pages are printed on one sheet of paper.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:printTwoOnOne
 /// </remarks>
 [Category("Printing")]
 [OpenXmlElement(typeof(DXW.PrintTwoOnOne))]
 public bool? PrintTwoOnOne { get => _PrintTwoOnOne; set => UpdateField(ref _PrintTwoOnOne, value, nameof(PrintTwoOnOne)); }

 private bool? _PrintTwoOnOne;
 /// <summary>
 /// Specifies if grammar and spell-checking engines completed checking before the document was last saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:proofState
 /// </remarks>
 [Category("Proofing")]
 [OpenXmlElement(typeof(DXW.ProofState))]
 public ProofState? ProofState { get => _ProofState; set => UpdateField(ref _ProofState, value, nameof(ProofState)); }

 private ProofState? _ProofState;
 /// <summary>
 /// Specifies the exact set of page and text sizing parameters for displaying the document, used for ink annotations.
 /// </summary>
 [Category("Protection")]
 [OpenXmlElement(typeof(DMWD.ReadModeInkLockDown))]
 public DMWD.ReadModeInkLockDown? ReadModeInkLockDown { get => _ReadModeInkLockDown; set => UpdateField(ref _ReadModeInkLockDown, value, nameof(ReadModeInkLockDown)); }

 private DMWD.ReadModeInkLockDown? _ReadModeInkLockDown;
 /// <summary>
 /// Specifies that date and time information is removed from all annotations when the document is saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:removeDateAndTime
 /// </remarks>
 [Category("Protection")]
 [OpenXmlProperty(nameof(DXW.Settings.RemoveDateAndTime))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? RemoveDateAndTime { get => _RemoveDateAndTime; set => UpdateField(ref _RemoveDateAndTime, value, nameof(RemoveDateAndTime)); }

 private bool? _RemoveDateAndTime;
 /// <summary>
 /// Specifies that all personal information of document authors is removed upon saving.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:removePersonalInformation
 /// </remarks>
 [Category("Protection")]
 [OpenXmlProperty(nameof(DXW.Settings.RemovePersonalInformation))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? RemovePersonalInformation { get => _RemovePersonalInformation; set => UpdateField(ref _RemovePersonalInformation, value, nameof(RemovePersonalInformation)); }

 private bool? _RemovePersonalInformation;
 /// <summary>
 /// Specifies which forms of annotations are visible when the document is displayed.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:revisionView
 /// </remarks>
 [Category("View")]
 [OpenXmlElement(typeof(DXW.RevisionView))]
 public RevisionView? RevisionView { get => _RevisionView; set => UpdateField(ref _RevisionView, value, nameof(RevisionView)); }

 private RevisionView? _RevisionView;
 /// <summary>
 /// Specifies that only WordprocessingML form fields are saved in a comma-delimited text format.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:saveFormsData
 /// </remarks>
 [Category("Forms")]
 [OpenXmlProperty(nameof(DXW.Settings.SaveFormsData))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public bool? SaveFormsData { get => _SaveFormsData; set => UpdateField(ref _SaveFormsData, value, nameof(SaveFormsData)); }

 private bool? _SaveFormsData;
 /// <summary>
 /// Specifies that the document can be saved as a single XML file even when its contents are invalid based on XML schema validation.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:saveInvalidXml
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.SaveInvalidXml))]
 public bool? SaveInvalidXml { get => _SaveInvalidXml; set => UpdateField(ref _SaveInvalidXml, value, nameof(SaveInvalidXml)); }

 private bool? _SaveInvalidXml;
 /// <summary>
 /// Specifies if a document's thumbnail part should be generated for the first page when saved.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:savePreviewPicture
 /// </remarks>
 [Category("Save")]
 [OpenXmlElement(typeof(DXW.SavePreviewPicture))]
 public bool? SavePreviewPicture { get => _SavePreviewPicture; set => UpdateField(ref _SavePreviewPicture, value, nameof(SavePreviewPicture)); }

 private bool? _SavePreviewPicture;
 /// <summary>
 /// Specifies that fonts are subsetted when font embedding is enabled.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:saveSubsetFonts
 /// </remarks>
 [Category("Save")]
 [OpenXmlElement(typeof(DXW.SaveSubsetFonts))]
 /// <summary>
 /// Specifies that fonts are subsetted when font embedding is enabled.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:saveSubsetFonts
 /// </remarks>
 [OpenXmlProperty(nameof(DXW.Settings.SaveSubsetFonts))]
 public bool? SaveSubsetFonts { get => _SaveSubsetFonts; set => UpdateField(ref _SaveSubsetFonts, value, nameof(SaveSubsetFonts)); }

 private bool? _SaveSubsetFonts;
 /// <summary>
 /// Specifies the location of a custom XSL transform to be used when saving as a single XML file.
 /// </summary>
 [Category("Save")]
 [OpenXmlElement(typeof(DXW.SaveThroughXslt))]
 public SaveThroughXslt? SaveThroughXslt { get => _SaveThroughXslt; set => UpdateField(ref _SaveThroughXslt, value, nameof(SaveThroughXslt)); }

 private SaveThroughXslt? _SaveThroughXslt;
 /// <summary>
 /// Specifies that only custom XML markup is saved as an XML file.
 /// </summary>
 [Category("Save")]
 [OpenXmlElement(typeof(DXW.SaveXmlDataOnly))]
 public bool? SaveXmlDataOnly { get => _SaveXmlDataOnly; set => UpdateField(ref _SaveXmlDataOnly, value, nameof(SaveXmlDataOnly)); }

 private bool? _SaveXmlDataOnly;
 /// <summary>
 /// Specifies the set of XML namespaces associated with custom XML markup in the document.
 /// </summary>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXCXSR.SchemaLibrary))]
 public SchemaLibrary? SchemaLibrary { get => _SchemaLibrary; set => UpdateField(ref _SchemaLibrary, (value != null && value.Count > 0) ? value : null, nameof(SchemaLibrary)); }

 private SchemaLibrary? _SchemaLibrary;
 /// <summary>
 /// Specifies the defaults used when creating new shapes, stored once per document.
 /// </summary>
 [Category("Drawings")]
 [Obsolete]
 [OpenXmlElement(typeof(DMWD.ShapeDefaults))]
 public DMWD.ShapeDefaults? ShapeDefaults { get => _ShapeDefaults; set => UpdateField(ref _ShapeDefaults, value, nameof(ShapeDefaults)); }

 private DMWD.ShapeDefaults? _ShapeDefaults;
 /// <summary>
 /// Specifies that an e-mail message header is displayed when the document is opened.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:showEnvelope
 /// </remarks>
 [Category("Mailing")]
 [OpenXmlElement(typeof(DXW.ShowEnvelope))]
 public bool? ShowEnvelope { get => _ShowEnvelope; set => UpdateField(ref _ShowEnvelope, value, nameof(ShowEnvelope)); }

 private bool? _ShowEnvelope;
 /// <summary>
 /// Specifies that a visual indicator is provided for the start and end locations of custom XML markup.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:showXMLTags
 /// </remarks>
 [Category("CustomXml")]
 [OpenXmlElement(typeof(DXW.ShowXmlTags))]
 public bool? ShowXmlTags { get => _ShowXmlTags; set => UpdateField(ref _ShowXmlTags, value, nameof(ShowXmlTags)); }

 private bool? _ShowXmlTags;
 /// <summary>
 /// Specifies that the strict set of Kinsoku rules is applied to Japanese text in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:strictFirstAndLastChars
 /// </remarks>
 [Category("Kinsoku")]
 [OpenXmlElement(typeof(DXW.StrictFirstAndLastChars))]
 public bool? StrictFirstAndLastChars { get => _StrictFirstAndLastChars; set => UpdateField(ref _StrictFirstAndLastChars, value, nameof(StrictFirstAndLastChars)); }

 private bool? _StrictFirstAndLastChars;
 /// <summary>
 /// Specifies suggested filters to be applied to the list of document styles in the application UI.
 /// </summary>
 [Category("Styling")]
 [OpenXmlElement(typeof(DXW.StylePaneFormatFilter))]
 public StylePaneFormatFilter? StylePaneFormatFilter { get => _StylePaneFormatFilter; set => UpdateField(ref _StylePaneFormatFilter, value, nameof(StylePaneFormatFilter)); }

 private StylePaneFormatFilter? _StylePaneFormatFilter;
 /// <summary>
 /// Specifies a sorting to be applied to the list of styles in the document UI.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:stylePaneSortMethod
 /// </remarks>
 [Category("Styling")]
 [OpenXmlElement(typeof(DXW.StylePaneSortMethods))]
 public string? StylePaneSortMethods { get => _StylePaneSortMethods; set => UpdateField(ref _StylePaneSortMethods, value, nameof(StylePaneSortMethods)); }

 private string? _StylePaneSortMethods;
 /// <summary>
 /// Specifies the size for automatic document summaries performed on the content of the document.
 /// </summary>
 /// <remarks>
 /// This element specifies the size for automatic document summaries performed on the content of a WordprocessingML document.
 /// An automatic document summary is a subset of text contained in a document deemed by the hosting application
 /// to summarize the content of the WordprocessingML document.
 /// This element specifies the size of an automatic document summary to be performed on a given WordprocessingML document
 /// as a percentage of the total size of the given WordprocessingML document.
 /// Performing an automatic document summary is a runtime operation outside the scope of /IEC 29500.
 /// </remarks>
 [Category("Automation")]
 [OpenXmlElement(typeof(DXW.SummaryLength))]
 public Percent? SummaryLength { get => _SummaryLength; set => UpdateField(ref _SummaryLength, value, nameof(SummaryLength)); }

 private Percent? _SummaryLength;
 /// <summary>
 /// Specifies the language used to determine theme fonts in the document's Theme part.
 /// </summary>
 [Category("Theme")]
 [OpenXmlElement(typeof(DXW.ThemeFontLanguages))]
 public Languages? ThemeFontLanguages { get => _ThemeFontLanguages; set => UpdateField(ref _ThemeFontLanguages, value, nameof(ThemeFontLanguages)); }

 private Languages? _ThemeFontLanguages;
 /// <summary>
 /// Specifies that revisions are tracked in the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:trackRevisions
 /// </remarks>
 [Category("Tracking")]
 [OpenXmlElement(typeof(DXW.TrackRevisions))]
 public bool? TrackRevisions { get => _TrackRevisions; set => UpdateField(ref _TrackRevisions, value, nameof(TrackRevisions)); }

 private bool? _TrackRevisions;
 /// <summary>
 /// Disables features incompatible with earlier word processing formats.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:uiCompat97To2003
 /// </remarks>
 [Category("Conformance")]
 [OpenXmlElement(typeof(DXW.UICompatibleWith97To2003))]
 public bool? UICompatibleWith97To2003 { get => _UICompatibleWith97To2003; set => UpdateField(ref _UICompatibleWith97To2003, value, nameof(UICompatibleWith97To2003)); }

 private bool? _UICompatibleWith97To2003;
 /// <summary>
 /// Specifies whether fields should automatically have their result recalculated when the document is opened.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:updateFields
 /// </remarks>
 [Category("Protection")]
 [OpenXmlElement(typeof(DXW.UpdateFieldsOnOpen))]
 public bool? UpdateFieldsOnOpen { get => _UpdateFieldsOnOpen; set => UpdateField(ref _UpdateFieldsOnOpen, value, nameof(UpdateFieldsOnOpen)); }

 private bool? _UpdateFieldsOnOpen;
 /// <summary>
 /// Specifies that the document should be saved through the custom XSLT transform when saved as a single XML file.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:useXSLTWhenSaving
 /// </remarks>
 [Category("Save")]
 [OpenXmlElement(typeof(DXW.UseXsltWhenSaving))]
 public bool? UseXsltWhenSaving { get => _UseXsltWhenSaving; set => UpdateField(ref _UseXsltWhenSaving, value, nameof(UseXsltWhenSaving)); }

 private bool? _UseXsltWhenSaving;
 /// <summary>
 /// Specifies the manner in which the document should be displayed when opened by an application.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:view
 /// </remarks>
 [Category("View")]
 [OpenXmlProperty(nameof(DXW.Settings.View))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public ViewKind? View { get => _View; set => UpdateField(ref _View, value, nameof(View)); }

 private ViewKind? _View;
 /// <summary>
 /// Specifies the write protection settings applied to the document.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:writeProtection
 /// </remarks>
 [Category("Protection")]
 [OpenXmlProperty(nameof(DXW.Settings.WriteProtection))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public WriteProtection? WriteProtection { get => _WriteProtection; set => UpdateField(ref _WriteProtection, value, nameof(WriteProtection)); }

 private WriteProtection? _WriteProtection;
 /// <summary>
 /// Specifies the magnification level to be applied when the document is displayed.
 /// </summary>
 /// <remarks>
 /// Represents the following element tag in the schema: w:zoom
 /// </remarks>
 [Category("View")]
 [OpenXmlProperty(nameof(DXW.Settings.Zoom))]
 [OpenXmlElement(typeof(DXW.Settings))]
 public Zoom? Zoom { get => _Zoom; set => UpdateField(ref _Zoom, value, nameof(Zoom)); }

 private Zoom? _Zoom;
 /// <summary>
 /// Specifies the presence of document variables in the document.
 /// </summary>
 [Category("Variables")]
 [OpenXmlElement(typeof(DXW.DocumentVariables))]
 public Variables? DocumentVariables { get => _DocumentVariables; set => UpdateField(ref _DocumentVariables, (value != null && value.Count > 0) ? value : null, nameof(DocumentVariables)); }

 private Variables? _DocumentVariables;
 /// <summary>
 /// Specifies all mail merge information for the document.
 /// </summary>
 [Category("Mailing")]
 [OpenXmlElement(typeof(DXW.MailMerge))]
 public MailMerge? MailMerge { get => _MailMerge; set => UpdateField(ref _MailMerge, value, nameof(MailMerge)); }

 private MailMerge? _MailMerge;
 /// <summary>
 /// Specifies the document-level properties for all math in the document.
 /// </summary>
 [Category("Math")]
 [OpenXmlElement(typeof(DMM.MathProperties))]
 public DMM.MathProperties? MathProperties { get => _MathProperties; set => UpdateField(ref _MathProperties, value, nameof(MathProperties)); }

 private DMM.MathProperties? _MathProperties;
 [XmlIgnore]
 [JsonIgnore]
 [NotMapped]
 public static KnownProperties KnownProperties { get; } = new KnownProperties(typeof(DocumentSettings));
}