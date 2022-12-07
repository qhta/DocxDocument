namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
public interface PreviousSectionProperties
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public String? RsidRPr { get ; set; }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public String? RsidDel { get ; set; }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public String? RsidR { get ; set; }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public String? RsidSect { get ; set; }
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  public FootnoteProperties? FootnoteProperties { get ; set; }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public EndnoteProperties? EndnoteProperties { get ; set; }
  
  /// <summary>
  /// SectionType.
  /// </summary>
  public SectionMarkKind? SectionType { get ; set; }
  
  /// <summary>
  /// PageSize.
  /// </summary>
  public PageSize? PageSize { get ; set; }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public PageMargin? PageMargin { get ; set; }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public PaperSource? PaperSource { get ; set; }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public PageBorders? PageBorders { get ; set; }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public LineNumberType? LineNumberType { get ; set; }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public PageNumberType? PageNumberType { get ; set; }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public Columns? Columns { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
  public VerticalJustificationKind? VerticalTextAlignmentOnPage { get ; set; }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public TextDirectionKind? TextDirection { get ; set; }
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  public DocGrid? DocGrid { get ; set; }
  
}
