namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public interface ISectionProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRPr { get ; set; }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidDel { get ; set; }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidR { get ; set; }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidSect { get ; set; }
  
  public Collection<IHeaderFooterReferenceType>? HeaderReferences { get ; set; }
  
  public Collection<IHeaderFooterReferenceType>? FooterReferences { get ; set; }
  
  public IFootnoteProperties? FootnoteProperties { get ; set; }
  
  public IEndnoteProperties? EndnoteProperties { get ; set; }
  
  public SectionMarkKind? SectionType { get ; set; }
  
  public IPageSize? PageSize { get ; set; }
  
  public IPageMargin? PageMargin { get ; set; }
  
  public IPaperSource? PaperSource { get ; set; }
  
  public IPageBorders? PageBorders { get ; set; }
  
  public ILineNumberType? LineNumberType { get ; set; }
  
  public IPageNumberType? PageNumberType { get ; set; }
  
  public IColumns? Columns { get ; set; }
  
  public Boolean? FormProtection { get ; set; }
  
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get ; set; }
  
  public Boolean? NoEndnote { get ; set; }
  
  public Boolean? TitlePage { get ; set; }
  
  public TextDirectionKind? TextDirection { get ; set; }
  
  public Boolean? BiDi { get ; set; }
  
  public Boolean? GutterOnRight { get ; set; }
  
  public IDocGrid? DocGrid { get ; set; }
  
  public IRelationshipType? PrinterSettingsReference { get ; set; }
  
  public Int32? FootnoteColumns { get ; set; }
  
  public ISectionPropertiesChange? SectionPropertiesChange { get ; set; }
  
}
