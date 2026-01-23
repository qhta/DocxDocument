namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Defines the section properties for a section of the document.
  /// If it occurs as the last body element, then it specifies the properties of the last section of the document.
  /// For any other section the properties are stored as a child element of the paragraph element corresponding to the last paragraph in the given section.
  /// </summary>
  public abstract class BaseSectionProperties<T>: ElementCollection<ISectionPropertiesContent> where T: DX.OpenXmlElement
  {
    
    /// <summary>
    /// Physical section mark character revision ID.
    /// </summary>
    public HexInt? RsidRPr { get; set; }
    
    /// <summary>
    /// Section deletion revision ID.
    /// </summary>
    public HexInt? RsidDel { get; set; }
    
    /// <summary>
    /// Section addition revision ID.
    /// </summary>
    public HexInt? RsidR { get; set; }
    
    /// <summary>
    /// Section properties revision ID.
    /// </summary>
    public HexInt? RsidSect { get; set; }
    
    /// <summary>
    /// Type of the section mark.
    /// </summary>
    public SectionMarkKind? SectionType { get; set; }
    
    /// <summary>
    /// Indicates whether form protection is enabled.
    /// </summary>
    public bool? FormProtection { get; set; }
    
    /// <summary>
    /// Vertical alignment of text on the page.
    /// </summary>
    public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
    
    /// <summary>
    /// Indicates whether endnotes are omitted from the document output.
    /// </summary>
    public bool? NoEndnote { get; set; }
    
    /// <summary>
    /// Indicates whether the section occurs on a title page.
    /// </summary>
    public bool? TitlePage { get; set; }
    
    /// <summary>
    /// Text direction for the section.
    /// </summary>
    public TextDirectionKind? TextDirection { get; set; }
    
    /// <summary>
    /// Indicates whether bidirectional (BiDi) text support is enabled.
    /// </summary>
    public bool? BiDi { get; set; }
    
    /// <summary>
    /// Indicates whether the gutter is displayed on the right side.
    /// </summary>
    public bool? GutterOnRight { get; set; }
    
    /// <summary>
    /// Number of columns to use when displaying footnotes.
    /// </summary>
    public Int32? FootnoteColumns { get; set; }
    
    /// <summary>
    /// Collection of properties that define the formatting and behavior of footnotes.
    /// </summary>
    public FootnoteProperties? FootnoteProperties { get; set; }
    
    /// <summary>
    /// Endnote properties for the document element.
    /// </summary>
    public EndnoteProperties? EndnoteProperties { get; set; }
    
    /// <summary>
    /// Page size to use when retrieving paged results.
    /// </summary>
    public PageSize? PageSize { get; set; }
    
    /// <summary>
    /// Page margin settings for the document section.
    /// </summary>
    public PageMargin? PageMargin { get; set; }
    
    /// <summary>
    /// Paper source to use for printing.
    /// </summary>
    public PaperSource? PaperSource { get; set; }
    
    /// <summary>
    /// Borders applied to the page.
    /// </summary>
    public PageBorders? PageBorders { get; set; }
    
    /// <summary>
    /// Type of line number associated with the phone number, such as mobile, landline, or VoIP.
    /// </summary>
    public LineNumberType? LineNumberType { get; set; }
    
    /// <summary>
    /// Type of page numbering to use.
    /// </summary>
    public PageNumberType? PageNumberType { get; set; }
    
    /// <summary>
    /// Columns in this section.
    /// </summary>
    public TextColumns? Columns { get; set; }
    
    /// <summary>
    /// Document grid settings for the current document.
    /// </summary>
    public DocGrid? DocGrid { get; set; }
    
    /// <summary>
    /// Reference to the printer settings associated with this object.
    /// </summary>
    public PrinterSettingsReference? PrinterSettingsReference { get; set; }
    
  }