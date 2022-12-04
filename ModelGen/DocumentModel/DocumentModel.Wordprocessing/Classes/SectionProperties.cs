namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public class SectionProperties
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public String? RsidRPr
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public String? RsidDel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public String? RsidR
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public String? RsidSect
  {
    get;
    set;
  }
  
  public FootnoteProperties? FootnoteProperties
  {
    get;
    set;
  }
  
  public EndnoteProperties? EndnoteProperties
  {
    get;
    set;
  }
  
  public SectionMarkKind? SectionType
  {
    get;
    set;
  }
  
  public PageSize? PageSize
  {
    get;
    set;
  }
  
  public PageMargin? PageMargin
  {
    get;
    set;
  }
  
  public PaperSource? PaperSource
  {
    get;
    set;
  }
  
  public PageBorders? PageBorders
  {
    get;
    set;
  }
  
  public LineNumberType? LineNumberType
  {
    get;
    set;
  }
  
  public PageNumberType? PageNumberType
  {
    get;
    set;
  }
  
  public Columns? Columns
  {
    get;
    set;
  }
  
  public VerticalJustificationKind? VerticalTextAlignmentOnPage
  {
    get;
    set;
  }
  
  public TextDirectionKind? TextDirection
  {
    get;
    set;
  }
  
  public DocGrid? DocGrid
  {
    get;
    set;
  }
  
  public Boolean? PrinterSettingsReference
  {
    get;
    set;
  }
  
  public SectionPropertiesChange? SectionPropertiesChange
  {
    get;
    set;
  }
  
}
