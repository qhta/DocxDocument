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
  
  public DocumentModel.Wordprocessing.IHeaderFooterReferenceType? HeaderReference { get ; set; }
  
  public DocumentModel.Wordprocessing.IHeaderFooterReferenceType? FooterReference { get ; set; }
  
  public DocumentModel.Wordprocessing.IFootnoteProperties? FootnoteProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IEndnoteProperties? EndnoteProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.SectionMarkKind? SectionType { get ; set; }
  
  public DocumentModel.Wordprocessing.IPageSize? PageSize { get ; set; }
  
  public DocumentModel.Wordprocessing.IPageMargin? PageMargin { get ; set; }
  
  public DocumentModel.Wordprocessing.IPaperSource? PaperSource { get ; set; }
  
  public DocumentModel.Wordprocessing.IPageBorders? PageBorders { get ; set; }
  
  public DocumentModel.Wordprocessing.ILineNumberType? LineNumberType { get ; set; }
  
  public DocumentModel.Wordprocessing.IPageNumberType? PageNumberType { get ; set; }
  
  public DocumentModel.Wordprocessing.IColumns? Columns { get ; set; }
  
  public System.Boolean? FormProtection { get ; set; }
  
  public DocumentModel.Wordprocessing.VerticalJustificationKind? VerticalTextAlignmentOnPage { get ; set; }
  
  public System.Boolean? NoEndnote { get ; set; }
  
  public System.Boolean? TitlePage { get ; set; }
  
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get ; set; }
  
  public System.Boolean? BiDi { get ; set; }
  
  public System.Boolean? GutterOnRight { get ; set; }
  
  public DocumentModel.Wordprocessing.IDocGrid? DocGrid { get ; set; }
  
  public DocumentModel.Wordprocessing.IRelationshipType? PrinterSettingsReference { get ; set; }
  
  public System.Int32? FootnoteColumns { get ; set; }
  
  public DocumentModel.Wordprocessing.ISectionPropertiesChange? SectionPropertiesChange { get ; set; }
  
}
