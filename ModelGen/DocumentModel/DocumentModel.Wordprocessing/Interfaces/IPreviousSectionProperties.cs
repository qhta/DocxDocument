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
  public DocumentModel.Wordprocessing.IFootnoteProperties? FootnoteProperties { get ; set; }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.IEndnoteProperties? EndnoteProperties { get ; set; }
  
  /// <summary>
  /// SectionType.
  /// </summary>
  public DocumentModel.Wordprocessing.SectionMarkKind? SectionType { get ; set; }
  
  /// <summary>
  /// PageSize.
  /// </summary>
  public DocumentModel.Wordprocessing.IPageSize? PageSize { get ; set; }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.IPageMargin? PageMargin { get ; set; }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public DocumentModel.Wordprocessing.IPaperSource? PaperSource { get ; set; }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.IPageBorders? PageBorders { get ; set; }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.ILineNumberType? LineNumberType { get ; set; }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.IPageNumberType? PageNumberType { get ; set; }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public DocumentModel.Wordprocessing.IColumns? Columns { get ; set; }
  
  /// <summary>
  /// FormProtection.
  /// </summary>
  public System.Boolean? FormProtection { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalJustificationKind? VerticalTextAlignmentOnPage { get ; set; }
  
  /// <summary>
  /// NoEndnote.
  /// </summary>
  public System.Boolean? NoEndnote { get ; set; }
  
  /// <summary>
  /// TitlePage.
  /// </summary>
  public System.Boolean? TitlePage { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get ; set; }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public System.Boolean? BiDi { get ; set; }
  
  /// <summary>
  /// GutterOnRight.
  /// </summary>
  public System.Boolean? GutterOnRight { get ; set; }
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocGrid? DocGrid { get ; set; }
  
  /// <summary>
  /// PrinterSettingsReference.
  /// </summary>
  public DocumentModel.Wordprocessing.IRelationshipType? PrinterSettingsReference { get ; set; }
  
  /// <summary>
  /// FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public System.Int32? FootnoteColumns { get ; set; }
  
}
