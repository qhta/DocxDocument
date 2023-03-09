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

  [XmlContentElement]
  public HeaderReferences? HeaderReferences { get; set; }

  [XmlContentElement]
  public FooterReferences? FooterReferences { get; set; }

  [XmlContentElement]
  public FootnoteProperties? FootnoteProperties { get; set; }

  [XmlContentElement]
  public EndnoteProperties? EndnoteProperties { get; set; }

  [XmlContentElement]
  public PageSize? PageSize { get; set; }

  [XmlContentElement]
  public PageMargin? PageMargin { get; set; }

  [XmlContentElement]
  public PaperSource? PaperSource { get; set; }

  [XmlContentElement]
  public PageBorders? PageBorders { get; set; }

  [XmlContentElement]
  public LineNumberType? LineNumberType { get; set; }

  [XmlContentElement]
  public PageNumberType? PageNumberType { get; set; }

  [XmlContentElement]
  public Columns? Columns { get; set; }

  public Boolean? FormProtection { get; set; }

  [XmlContentElement]
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }

  public Boolean? NoEndnote { get; set; }

  public Boolean? TitlePage { get; set; }

  public TextDirectionKind? TextDirection { get; set; }

  public Boolean? BiDi { get; set; }

  public Boolean? GutterOnRight { get; set; }

  [XmlContentElement]
  public DocGrid? DocGrid { get; set; }

  [XmlContentElement]
  public RelationshipType? PrinterSettingsReference { get; set; }

  public Int32? FootnoteColumns { get; set; }

  [XmlContentElement]
  public SectionPropertiesChange? SectionPropertiesChange { get; set; }

}