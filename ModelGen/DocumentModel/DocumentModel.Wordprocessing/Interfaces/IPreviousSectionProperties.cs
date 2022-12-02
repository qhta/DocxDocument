namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
public interface IPreviousSectionProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  public IFootnoteProperties? FootnoteProperties { get ; set; }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public IEndnoteProperties? EndnoteProperties { get ; set; }
  
  /// <summary>
  /// SectionType.
  /// </summary>
  public SectionMarkKind? SectionType { get ; set; }
  
  /// <summary>
  /// PageSize.
  /// </summary>
  public IPageSize? PageSize { get ; set; }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public IPageMargin? PageMargin { get ; set; }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public IPaperSource? PaperSource { get ; set; }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public IPageBorders? PageBorders { get ; set; }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public ILineNumberType? LineNumberType { get ; set; }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public IPageNumberType? PageNumberType { get ; set; }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public IColumns? Columns { get ; set; }
  
  /// <summary>
  /// FormProtection.
  /// </summary>
  public Boolean? FormProtection { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get ; set; }
  
  /// <summary>
  /// NoEndnote.
  /// </summary>
  public Boolean? NoEndnote { get ; set; }
  
  /// <summary>
  /// TitlePage.
  /// </summary>
  public Boolean? TitlePage { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get ; set; }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public Boolean? BiDi { get ; set; }
  
  /// <summary>
  /// GutterOnRight.
  /// </summary>
  public Boolean? GutterOnRight { get ; set; }
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  public IDocGrid? DocGrid { get ; set; }
  
  /// <summary>
  /// PrinterSettingsReference.
  /// </summary>
  public IRelationshipType? PrinterSettingsReference { get ; set; }
  
  /// <summary>
  /// FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get ; set; }
  
}
