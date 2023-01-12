namespace DocumentModel.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public partial class SectionProperties
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public Byte[]? RsidRPr { get; set; }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public Byte[]? RsidDel { get; set; }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public Byte[]? RsidR { get; set; }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public Byte[]? RsidSect { get; set; }
  
  public DocumentModel.Wordprocessing.HeaderFooterReferenceType? HeaderReference { get; set; }
  
  public DocumentModel.Wordprocessing.HeaderFooterReferenceType? FooterReference { get; set; }
  
  public DocumentModel.Wordprocessing.FootnoteProperties? FootnoteProperties { get; set; }
  
  public DocumentModel.Wordprocessing.EndnoteProperties? EndnoteProperties { get; set; }
  
  public DocumentModel.Wordprocessing.SectionMarkKind? SectionType { get; set; }
  
  public DocumentModel.Wordprocessing.PageSize? PageSize { get; set; }
  
  public DocumentModel.Wordprocessing.PageMargin? PageMargin { get; set; }
  
  public DocumentModel.Wordprocessing.PaperSource? PaperSource { get; set; }
  
  public DocumentModel.Wordprocessing.PageBorders? PageBorders { get; set; }
  
  public DocumentModel.Wordprocessing.LineNumberType? LineNumberType { get; set; }
  
  public DocumentModel.Wordprocessing.PageNumberType? PageNumberType { get; set; }
  
  public DocumentModel.Wordprocessing.Columns? Columns { get; set; }
  
  public Boolean? FormProtection { get; set; }
  
  public DocumentModel.Wordprocessing.VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  
  public Boolean? NoEndnote { get; set; }
  
  public Boolean? TitlePage { get; set; }
  
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  public Boolean? BiDi { get; set; }
  
  public Boolean? GutterOnRight { get; set; }
  
  public DocumentModel.Wordprocessing.DocGrid? DocGrid { get; set; }
  
  public DocumentModel.Wordprocessing.RelationshipType? PrinterSettingsReference { get; set; }
  
  public Int32? FootnoteColumns { get; set; }
  
  public DocumentModel.Wordprocessing.SectionPropertiesChange? SectionPropertiesChange { get; set; }
  
}
