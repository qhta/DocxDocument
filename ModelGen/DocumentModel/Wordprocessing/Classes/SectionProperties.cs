namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element defines the section properties for the section of the document.
/// </summary>
public partial class SectionProperties
{
  
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  [SchemaAttr("w:rsidRPr")]
  public DocumentModel.HexBinaryValue? RsidRPr { get; set; }
  
  
  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  [SchemaAttr("w:rsidDel")]
  public DocumentModel.HexBinaryValue? RsidDel { get; set; }
  
  
  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  [SchemaAttr("w:rsidR")]
  public DocumentModel.HexBinaryValue? RsidR { get; set; }
  
  
  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  [SchemaAttr("w:rsidSect")]
  public DocumentModel.HexBinaryValue? RsidSect { get; set; }
  
  public DocumentModel.Wordprocessing.FootnoteProperties? FootnoteProperties { get; set; }
  
  public DocumentModel.Wordprocessing.EndnoteProperties? EndnoteProperties { get; set; }
  
  public DocumentModel.Wordprocessing.SectionMarkValues? SectionType { get; set; }
  
  public DocumentModel.Wordprocessing.PageSize? PageSize { get; set; }
  
  public DocumentModel.Wordprocessing.PageMargin? PageMargin { get; set; }
  
  public DocumentModel.Wordprocessing.PaperSource? PaperSource { get; set; }
  
  public DocumentModel.Wordprocessing.PageBorders? PageBorders { get; set; }
  
  public DocumentModel.Wordprocessing.LineNumberType? LineNumberType { get; set; }
  
  public DocumentModel.Wordprocessing.PageNumberType? PageNumberType { get; set; }
  
  public DocumentModel.Wordprocessing.Columns? Columns { get; set; }
  
  public Boolean? FormProtection { get; set; }
  
  public DocumentModel.Wordprocessing.VerticalJustificationValues? VerticalTextAlignmentOnPage { get; set; }
  
  public Boolean? NoEndnote { get; set; }
  
  public Boolean? TitlePage { get; set; }
  
  public DocumentModel.Wordprocessing.TextDirectionValues? TextDirection { get; set; }
  
  public Boolean? BiDi { get; set; }
  
  public Boolean? GutterOnRight { get; set; }
  
  public DocumentModel.Wordprocessing.DocGrid? DocGrid { get; set; }
  
  public DocumentModel.Wordprocessing.RelationshipType? PrinterSettingsReference { get; set; }
  
  public Int32? FootnoteColumns { get; set; }
  
  public DocumentModel.Wordprocessing.SectionPropertiesChange? SectionPropertiesChange { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
