namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the section properties for a section of the document.
/// If it occurs as the last body element, then it specifies the properties of the last section of the document.
/// For any other section the properties are stored as a child element of the paragraph element corresponding to the last paragraph in the given section.
/// </summary>
[XmlRoot("BaseSectionProperties", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class BaseSectionProperties<T> : ModelElement<T> where T : DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  protected BaseSectionProperties() : base() { }

  /// <summary>
  /// Constructor that initializes the element within an owner collection.
  /// </summary>
  /// <param name="collection">The collection to which this element belongs.</param>
  protected BaseSectionProperties(object collection) : base(collection) { }


  /// <summary>
  /// Physical section mark character revision ID.
  /// </summary>
  public HexInt? RsidRPr { get => _RsidRPr; set => UpdateField(ref _RsidRPr, value, nameof(RsidRPr)); }

  private HexInt? _RsidRPr;
  /// <summary>
  /// Section deletion revision ID.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SectionProperties.RsidDel))]
  public HexInt? RsidDel { get => _RsidDel; set => UpdateField(ref _RsidDel, value, nameof(RsidDel)); }

  private HexInt? _RsidDel;
  /// <summary>
  /// Section addition revision ID.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SectionProperties.RsidR))]
  public HexInt? RsidR { get => _RsidR; set => UpdateField(ref _RsidR, value, nameof(RsidR)); }

  private HexInt? _RsidR;
  /// <summary>
  /// Section properties revision ID.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SectionProperties.RsidSect))]
  public HexInt? RsidSect { get => _RsidSect; set => UpdateField(ref _RsidSect, value, nameof(RsidSect)); }

  private HexInt? _RsidSect;
  /// <summary>
  /// Type of the section mark.
  /// </summary>
  [OpenXmlElement(typeof(DXW.SectionMarkValues))]
  public SectionStart? SectionType { get => _SectionType; set => UpdateField(ref _SectionType, value, nameof(SectionType)); }

  private SectionStart? _SectionType;
  /// <summary>
  /// Indicates whether form protection is enabled.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FormProtection))]
  public bool? FormProtection { get => _FormProtection; set => UpdateField(ref _FormProtection, value, nameof(FormProtection)); }

  private bool? _FormProtection;
  /// <summary>
  /// Vertical alignment of text on the page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.VerticalTextAlignment))]
  public VerticalJustification? VerticalTextAlignmentOnPage { get => _VerticalTextAlignmentOnPage; set => UpdateField(ref _VerticalTextAlignmentOnPage, value, nameof(VerticalTextAlignmentOnPage)); }

  private VerticalJustification? _VerticalTextAlignmentOnPage;
  /// <summary>
  /// Indicates whether endnotes are omitted from the document output.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NoEndnote))]
  public bool? NoEndnote { get => _NoEndnote; set => UpdateField(ref _NoEndnote, value, nameof(NoEndnote)); }

  private bool? _NoEndnote;
  /// <summary>
  /// Indicates whether the section occurs on a title page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TitlePage))]
  public bool? TitlePage { get => _TitlePage; set => UpdateField(ref _TitlePage, value, nameof(TitlePage)); }

  private bool? _TitlePage;
  /// <summary>
  /// Text direction for the section.
  /// </summary>
  [OpenXmlElement(typeof(DXW.TextDirection))]
  public TextDirection? TextDirection { get => _TextDirection; set => UpdateField(ref _TextDirection, value, nameof(TextDirection)); }

  private TextDirection? _TextDirection;
  /// <summary>
  /// Indicates whether bidirectional (BiDi) text support is enabled.
  /// </summary>
  [OpenXmlElement(typeof(DXW.BiDi))]
  public bool? BiDi { get => _BiDi; set => UpdateField(ref _BiDi, value, nameof(BiDi)); }

  private bool? _BiDi;
  /// <summary>
  /// Indicates whether the gutter is displayed on the right side.
  /// </summary>
  [OpenXmlElement(typeof(DXW.GutterOnRight))]
  public bool? GutterOnRight { get => _GutterOnRight; set => UpdateField(ref _GutterOnRight, value, nameof(GutterOnRight)); }

  private bool? _GutterOnRight;
  /// <summary>
  /// Number of columns to use when displaying footnotes.
  /// </summary>
  [OpenXmlElement(typeof(DXO13W.FootnoteColumns))]
  public Int32? FootnoteColumns { get => _FootnoteColumns; set => UpdateField(ref _FootnoteColumns, value, nameof(FootnoteColumns)); }

  private Int32? _FootnoteColumns;
  /// <summary>
  /// Collection of properties that define the formatting and behavior of footnotes.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FootnoteProperties))]
  public FootnoteProperties? FootnoteProperties { get => _FootnoteProperties; set => UpdateField(ref _FootnoteProperties, value, nameof(FootnoteProperties)); }

  private FootnoteProperties? _FootnoteProperties;
  /// <summary>
  /// Endnote properties for the document element.
  /// </summary>
  [OpenXmlElement(typeof(DXW.EndnoteProperties))]
  public EndnoteProperties? EndnoteProperties { get => _EndnoteProperties; set => UpdateField(ref _EndnoteProperties, value, nameof(EndnoteProperties)); }

  private EndnoteProperties? _EndnoteProperties;
  /// <summary>
  /// Page size to use when retrieving paged results.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PageSize))]
  public PageSize? PageSize { get => _PageSize; set => UpdateField(ref _PageSize, value, nameof(PageSize)); }

  private PageSize? _PageSize;
  /// <summary>
  /// Page margin settings for the document section.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PageMargin))]
  public PageMargin? PageMargin { get => _PageMargin; set => UpdateField(ref _PageMargin, value, nameof(PageMargin)); }

  private PageMargin? _PageMargin;
  /// <summary>
  /// Paper source to use for printing.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PaperSource))]
  public PaperSource? PaperSource { get => _PaperSource; set => UpdateField(ref _PaperSource, value, nameof(PaperSource)); }

  private PaperSource? _PaperSource;
  /// <summary>
  /// Borders applied to the page.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PageBorders))]
  public PageBorders? PageBorders { get => _PageBorders; set => UpdateField(ref _PageBorders, value, nameof(PageBorders)); }

  private PageBorders? _PageBorders;
  /// <summary>
  /// Type of line number.
  /// </summary>
  [OpenXmlElement(typeof(DXW.LineNumberType))]
  public LineNumberType? LineNumberType { get => _LineNumberType; set => UpdateField(ref _LineNumberType, value, nameof(LineNumberType)); }

  private LineNumberType? _LineNumberType;
  /// <summary>
  /// Type of page numbering to use.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PageNumberType))]
  public PageNumberType? PageNumberType { get => _PageNumberType; set => UpdateField(ref _PageNumberType, value, nameof(PageNumberType)); }

  private PageNumberType? _PageNumberType;
  /// <summary>
  /// Columns in this section.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Columns))]
  public TextColumns? Columns { get => _Columns; set => UpdateField(ref _Columns, value, nameof(Columns)); }

  private TextColumns? _Columns;
  /// <summary>
  /// Document grid settings for the current document.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DocGrid))]
  public DocGrid? DocGrid { get => _DocGrid; set => UpdateField(ref _DocGrid, value, nameof(DocGrid)); }

  private DocGrid? _DocGrid;
  /// <summary>
  /// Reference to the printer settings associated with this object.
  /// </summary>
  [OpenXmlElement(typeof(DXW.PrinterSettingsReference))]
  public PrinterSettingsReference? PrinterSettingsReference { get => _PrinterSettingsReference; set => UpdateField(ref _PrinterSettingsReference, value, nameof(PrinterSettingsReference)); }

  private PrinterSettingsReference? _PrinterSettingsReference;
}

/// <summary>
/// Concrete class of <see cref = "BaseSectionProperties{T}"/> representing the section properties for a section in a Wordprocessing document.
/// </summary>
[XmlRoot("BaseSectionProperties", Namespace = "DocumentModel.Wordprocessing")]
public class BaseSectionProperties : BaseSectionProperties<DXW.SectionProperties>
{
}