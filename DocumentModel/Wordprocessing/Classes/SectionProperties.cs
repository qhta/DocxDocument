namespace DocumentModel.Wordprocessing;

/// <summary>
///   Section Properties.
/// </summary>
public partial class SectionProperties : IBodyElement
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

  [XmlAnyElement]
  public HeaderReferences? HeaderReferences { get; set; }

  [XmlAnyElement]
  public FooterReferences? FooterReferences { get; set; }

  [XmlAnyElement]
  public FootnoteProperties? FootnoteProperties { get; set; }

  [XmlAnyElement]
  public EndnoteProperties? EndnoteProperties { get; set; }

  [XmlAnyElement]
  public PageSize? PageSize { get; set; }

  [XmlAnyElement]
  public PageMargin? PageMargin { get; set; }

  [XmlAnyElement]
  public PaperSource? PaperSource { get; set; }

  [XmlAnyElement]
  public PageBorders? PageBorders { get; set; }

  [XmlAnyElement]
  public LineNumberType? LineNumberType { get; set; }

  [XmlAnyElement]
  public PageNumberType? PageNumberType { get; set; }

  [XmlAnyElement]
  public Columns? Columns { get; set; }

  public Boolean? FormProtection { get; set; }

  [XmlAnyElement]
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }

  public Boolean? NoEndnote { get; set; }

  public Boolean? TitlePage { get; set; }

  public TextDirectionKind? TextDirection { get; set; }

  public Boolean? BiDi { get; set; }

  public Boolean? GutterOnRight { get; set; }

  [XmlAnyElement]
  public DocGrid? DocGrid { get; set; }

  [XmlAnyElement]
  public RelationshipType? PrinterSettingsReference { get; set; }

  public Int32? FootnoteColumns { get; set; }

  [XmlAnyElement]
  public SectionPropertiesChange? SectionPropertiesChange { get; set; }

}