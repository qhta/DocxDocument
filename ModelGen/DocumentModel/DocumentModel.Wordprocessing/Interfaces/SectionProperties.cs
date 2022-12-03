namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public interface SectionProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRPr { get ; set; }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidDel { get ; set; }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidR { get ; set; }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidSect { get ; set; }
  
  public Collection<HeaderFooterReferenceType>? HeaderReferences { get ; set; }
  
  public Collection<HeaderFooterReferenceType>? FooterReferences { get ; set; }
  
  public FootnoteProperties? FootnoteProperties { get ; set; }
  
  public EndnoteProperties? EndnoteProperties { get ; set; }
  
  public SectionMarkKind? SectionType { get ; set; }
  
  public PageSize? PageSize { get ; set; }
  
  public PageMargin? PageMargin { get ; set; }
  
  public PaperSource? PaperSource { get ; set; }
  
  public PageBorders? PageBorders { get ; set; }
  
  public LineNumberType? LineNumberType { get ; set; }
  
  public PageNumberType? PageNumberType { get ; set; }
  
  public Columns? Columns { get ; set; }
  
  public Boolean? FormProtection { get ; set; }
  
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get ; set; }
  
  public Boolean? NoEndnote { get ; set; }
  
  public Boolean? TitlePage { get ; set; }
  
  public TextDirectionKind? TextDirection { get ; set; }
  
  public Boolean? BiDi { get ; set; }
  
  public Boolean? GutterOnRight { get ; set; }
  
  public DocGrid? DocGrid { get ; set; }
  
  public RelationshipType? PrinterSettingsReference { get ; set; }
  
  public Int32? FootnoteColumns { get ; set; }
  
  public SectionPropertiesChange? SectionPropertiesChange { get ; set; }
  
}
