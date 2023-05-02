namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the section properties for a section of the document.
///   If it occurs as the last body element, then it specifies the properties of the last section of the document.
///   For any other section the properties are stored as a child element of the paragraph element 
///   corresponding to the last paragraph in the given section.
/// </summary>
public partial class SectionProperties : ModelElement, IStoryContent
{
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  public HexInt? RsidRPr { get; set; }

  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  public HexInt? RsidDel { get; set; }

  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  public HexInt? RsidR { get; set; }

  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  public HexInt? RsidSect { get; set; }

  public SectionMarkKind? SectionType { get; set; }

  public bool? FormProtection { get; set; }

  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }

  public bool? NoEndnote { get; set; }

  public bool? TitlePage { get; set; }

  public TextDirectionKind? TextDirection { get; set; }

  public bool? BiDi { get; set; }

  public bool? GutterOnRight { get; set; }

  public Int32? FootnoteColumns { get; set; }

  public HeaderReferences? HeaderReferences { get; set; }

  public FooterReferences? FooterReferences { get; set; }

   public FootnoteProperties? FootnoteProperties { get; set; }

   public EndnoteProperties? EndnoteProperties { get; set; }

   public PageSize? PageSize { get; set; }

   public PageMargin? PageMargin { get; set; }

   public PaperSource? PaperSource { get; set; }

   public PageBorders? PageBorders { get; set; }

   public LineNumberType? LineNumberType { get; set; }

   public PageNumberType? PageNumberType { get; set; }

   public Columns? Columns { get; set; }

   public DocGrid? DocGrid { get; set; }

   public PrinterSettingsReference? PrinterSettingsReference { get; set; }

   public SectionPropertiesChange? SectionPropertiesChange { get; set; }

}