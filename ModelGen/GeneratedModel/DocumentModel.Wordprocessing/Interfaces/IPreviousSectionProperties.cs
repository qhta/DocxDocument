namespace DocumentModel.Wordprocessing;

public interface IPreviousSectionProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IHexBinaryValue? RsidRPr { get ; set; }
  
  public IHexBinaryValue? RsidDel { get ; set; }
  
  public IHexBinaryValue? RsidR { get ; set; }
  
  public IHexBinaryValue? RsidSect { get ; set; }
  
  public IFootnoteProperties? FootnoteProperties { get ; set; }
  
  public IEndnoteProperties? EndnoteProperties { get ; set; }
  
  public ISectionType? SectionType { get ; set; }
  
  public IPageSize? PageSize { get ; set; }
  
  public IPageMargin? PageMargin { get ; set; }
  
  public IPaperSource? PaperSource { get ; set; }
  
  public IPageBorders? PageBorders { get ; set; }
  
  public ILineNumberType? LineNumberType { get ; set; }
  
  public IPageNumberType? PageNumberType { get ; set; }
  
  public DocumentModel.Wordprocessing.IColumns? Columns { get ; set; }
  
  public IFormProtection? FormProtection { get ; set; }
  
  public IVerticalTextAlignmentOnPage? VerticalTextAlignmentOnPage { get ; set; }
  
  public INoEndnote? NoEndnote { get ; set; }
  
  public ITitlePage? TitlePage { get ; set; }
  
  public ITextDirection? TextDirection { get ; set; }
  
  public IBiDi? BiDi { get ; set; }
  
  public IGutterOnRight? GutterOnRight { get ; set; }
  
  public IDocGrid? DocGrid { get ; set; }
  
  public IPrinterSettingsReference? PrinterSettingsReference { get ; set; }
  
  public IFootnoteColumns? FootnoteColumns { get ; set; }
  
}
