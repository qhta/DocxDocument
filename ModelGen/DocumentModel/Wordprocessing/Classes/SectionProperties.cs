namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element defines the section properties for the section of the document.
/// </summary>
public partial class SectionProperties
{
  
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  public HexBinary? RsidRPr { get; set; }
  
  
  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  public HexBinary? RsidDel { get; set; }
  
  
  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  public HexBinary? RsidR { get; set; }
  
  
  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  public HexBinary? RsidSect { get; set; }
  
  public FootnoteProperties? FootnoteProperties { get; set; }
  
  public EndnoteProperties? EndnoteProperties { get; set; }
  
  public SectionMarkKind? SectionType { get; set; }
  
  public PageSize? PageSize { get; set; }
  
  public PageMargin? PageMargin { get; set; }
  
  public PaperSource? PaperSource { get; set; }
  
  public PageBorders? PageBorders { get; set; }
  
  public LineNumberType? LineNumberType { get; set; }
  
  public PageNumberType? PageNumberType { get; set; }
  
  public Columns? Columns { get; set; }
  
  public Boolean? FormProtection { get; set; }
  
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  
  public Boolean? NoEndnote { get; set; }
  
  public Boolean? TitlePage { get; set; }
  
  public TextDirectionKind? TextDirection { get; set; }
  
  public Boolean? BiDi { get; set; }
  
  public Boolean? GutterOnRight { get; set; }
  
  public HexInt? DocGrid { get; set; }
  
  public RelationshipType? PrinterSettingsReference { get; set; }
  
  public Int32? FootnoteColumns { get; set; }
  
  public SectionPropertiesChange? SectionPropertiesChange { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
