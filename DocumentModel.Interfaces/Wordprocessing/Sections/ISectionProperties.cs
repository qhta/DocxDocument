namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the section properties for a section of the document.
///   If it occurs as the last body element, then it specifies the properties of the last section of the document.
///   For any other section the properties are stored as a child element of the paragraph element 
///   corresponding to the last paragraph in the given section.
/// </summary>
public interface ISectionProperties : IModelElement, IStoryContent
{
  /// <summary>
  ///   Physical ISection Mark Character Revision ID
  /// </summary>
  public IHexInt? RsidRPr { get; set; }
  /// <summary>
  ///   ISection Deletion Revision ID
  /// </summary>
  public IHexInt? RsidDel { get; set; }
  /// <summary>
  ///   ISection Addition Revision ID
  /// </summary>
  public IHexInt? RsidR { get; set; }
  /// <summary>
  ///   ISection Properties Revision ID
  /// </summary>
  public IHexInt? RsidSect { get; set; }

  /// <summary>
  /// Type of the section mark.
  /// </summary>
  public SectionMarkKind? SectionType { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether form protection is enabled.
  /// </summary>
  public bool? FormProtection { get; set; }

  /// <summary>
  /// Gets or sets the vertical alignment of text on the page.
  /// </summary>
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether endnotes are omitted from the document output.
  /// </summary>
  public bool? NoEndnote { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the section occurs on a title page.
  /// </summary>
  public bool? TitlePage { get; set; }

  /// <summary>
  /// Gets or sets the text direction for the section.
  /// </summary>
  public TextDirectionKind? TextDirection { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether bidirectional (BiDi) text support is enabled. 
  /// </summary>
  public bool? BiDi { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the gutter is displayed on the right side.
  /// </summary>
  public bool? GutterOnRight { get; set; }

  /// <summary>
  /// Gets or sets the number of columns to use when displaying footnotes.
  /// </summary>
  public Int32? FootnoteColumns { get; set; }

  /// <summary>
  /// Gets or sets the collection of header references associated with the current instance.
  /// </summary>
  public HeaderReferences? HeaderReferences { get; set; }

  /// <summary>
  /// Gets or sets the collection of references to be included in the document footer.
  /// </summary>
  public FooterReferences? FooterReferences { get; set; }

  /// <summary>
  /// Gets or sets the collection of properties that define the formatting and behavior of footnotes.
  /// </summary>
  public FootnoteProperties? FootnoteProperties { get; set; }

  /// <summary>
  /// Gets or sets the endnote properties for the document element.
  /// </summary>
  public EndnoteProperties? EndnoteProperties { get; set; }

  /// <summary>
  /// Gets or sets the page size to use when retrieving paged results.
  /// </summary>
  /// <remarks>If not set, a default page size may be applied by the underlying service or data provider. The
  /// value determines the maximum number of items returned in a single page of results.</remarks>
  public PageSize? PageSize { get; set; }

  /// <summary>
  /// Gets or sets the page margin settings for the document section.
  /// </summary>
  public PageMargin? PageMargin { get; set; }

  /// <summary>
  /// Gets or sets the paper source to use for printing.
  /// </summary>
  public PaperSource? PaperSource { get; set; }

  /// <summary>
  /// Gets or sets the borders applied to the page.
  /// </summary>
  public PageBorders? PageBorders { get; set; }

  /// <summary>
  /// Gets or sets the type of line number associated with the phone number, such as mobile, landline, or VoIP.
  /// </summary>
  public LineNumberType? LineNumberType { get; set; }

  /// <summary>
  /// Gets or sets the type of page numbering to use.
  /// </summary>
  public PageNumberType? PageNumberType { get; set; }

  /// <summary>
  /// Gets or sets the columns in this section.
  /// </summary>
  public IColumns? Columns { get; set; }

  /// <summary>
  /// Gets or sets the document grid settings for the current document.
  /// </summary>
  public DocGrid? DocGrid { get; set; }

  /// <summary>
  /// Gets or sets a reference to the printer settings associated with this object.
  /// </summary>
  public PrinterSettingsReference? PrinterSettingsReference { get; set; }

  /// <summary>
  /// Gets or sets the change information for the section properties.
  /// </summary>
  public SectionPropertiesChange? SectionPropertiesChange { get; set; }
}