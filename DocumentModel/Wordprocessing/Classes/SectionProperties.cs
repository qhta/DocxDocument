namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the section properties for a section of the document.
///   If it occurs as the last body element, then it specifies the properties of the last section of the document.
///   For any other section the properties are stored as a child element of the paragraph element 
///   corresponding to the last paragraph in the given section.
/// </summary>
public partial class SectionProperties : ModelElement, IBodyElement
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

  public Boolean? FormProtection { get; set; }

  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }

  public Boolean? NoEndnote { get; set; }

  public Boolean? TitlePage { get; set; }

  public TextDirectionKind? TextDirection { get; set; }

  public Boolean? BiDi { get; set; }

  public Boolean? GutterOnRight { get; set; }

  public Int32? FootnoteColumns { get; set; }

  public HeaderReferences? HeaderReferences { get; set; }

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

  [XmlContentElement]
  public DocGrid? DocGrid { get; set; }

  [XmlContentElement]
  public PrinterSettingsReference? PrinterSettingsReference { get; set; }

  [XmlContentElement]
  public SectionPropertiesChange? SectionPropertiesChange { get; set; }

}