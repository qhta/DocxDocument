namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Section Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColumns))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Word.IFootnoteColumns))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocGrid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndnoteProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFootnoteProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILineNumberType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFormProtection))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoEndnote))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITitlePage))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBiDi))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGutterOnRight))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageBorders))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageMargin))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageNumberType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPaperSource))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPrinterSettingsReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISectionType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextDirection))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVerticalTextAlignmentOnPage))]
public class PreviousSectionProperties: IPreviousSectionProperties
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public IHexBinaryValue? RsidRPr
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public IHexBinaryValue? RsidDel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public IHexBinaryValue? RsidR
  {
    get;
    set;
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public IHexBinaryValue? RsidSect
  {
    get;
    set;
  }
  
  /// <summary>
  /// FootnoteProperties.
  /// </summary>
  public IFootnoteProperties? FootnoteProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndnoteProperties.
  /// </summary>
  public IEndnoteProperties? EndnoteProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// SectionType.
  /// </summary>
  public ISectionType? SectionType
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageSize.
  /// </summary>
  public IPageSize? PageSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageMargin.
  /// </summary>
  public IPageMargin? PageMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// PaperSource.
  /// </summary>
  public IPaperSource? PaperSource
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageBorders.
  /// </summary>
  public IPageBorders? PageBorders
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineNumberType.
  /// </summary>
  public ILineNumberType? LineNumberType
  {
    get;
    set;
  }
  
  /// <summary>
  /// PageNumberType.
  /// </summary>
  public IPageNumberType? PageNumberType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Columns.
  /// </summary>
  public DocumentModel.Wordprocessing.IColumns? Columns
  {
    get;
    set;
  }
  
  /// <summary>
  /// FormProtection.
  /// </summary>
  public IFormProtection? FormProtection
  {
    get;
    set;
  }
  
  /// <summary>
  /// VerticalTextAlignmentOnPage.
  /// </summary>
  public IVerticalTextAlignmentOnPage? VerticalTextAlignmentOnPage
  {
    get;
    set;
  }
  
  /// <summary>
  /// NoEndnote.
  /// </summary>
  public INoEndnote? NoEndnote
  {
    get;
    set;
  }
  
  /// <summary>
  /// TitlePage.
  /// </summary>
  public ITitlePage? TitlePage
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  public ITextDirection? TextDirection
  {
    get;
    set;
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  public IBiDi? BiDi
  {
    get;
    set;
  }
  
  /// <summary>
  /// GutterOnRight.
  /// </summary>
  public IGutterOnRight? GutterOnRight
  {
    get;
    set;
  }
  
  /// <summary>
  /// DocGrid.
  /// </summary>
  public IDocGrid? DocGrid
  {
    get;
    set;
  }
  
  /// <summary>
  /// PrinterSettingsReference.
  /// </summary>
  public IPrinterSettingsReference? PrinterSettingsReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public IFootnoteColumns? FootnoteColumns
  {
    get;
    set;
  }
  
}
