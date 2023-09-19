namespace DocumentModel.Wordprocessing;


/// <summary>
///   When specified as a child element of sectPrChange, the sectPr element specifies a set of section properties that were modified when the document was set to track all revisions.
/// </summary>
public partial class PreviousSectionProperties
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
  
  
  /// <summary>
  ///   FootnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnoteProperties? FootnoteProperties { get; set; }
  
  
  /// <summary>
  ///   EndnoteProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.EndnoteProperties? EndnoteProperties { get; set; }
  
  
  /// <summary>
  ///   SectionType.
  /// </summary>
  public DocumentModel.Wordprocessing.SectionMarkValues? SectionType { get; set; }
  
  
  /// <summary>
  ///   PageSize.
  /// </summary>
  public DocumentModel.Wordprocessing.PageSize? PageSize { get; set; }
  
  
  /// <summary>
  ///   PageMargin.
  /// </summary>
  public DocumentModel.Wordprocessing.PageMargin? PageMargin { get; set; }
  
  
  /// <summary>
  ///   PaperSource.
  /// </summary>
  public DocumentModel.Wordprocessing.PaperSource? PaperSource { get; set; }
  
  
  /// <summary>
  ///   PageBorders.
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorders? PageBorders { get; set; }
  
  
  /// <summary>
  ///   LineNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.LineNumberType? LineNumberType { get; set; }
  
  
  /// <summary>
  ///   PageNumberType.
  /// </summary>
  public DocumentModel.Wordprocessing.PageNumberType? PageNumberType { get; set; }
  
  
  /// <summary>
  ///   Columns.
  /// </summary>
  public DocumentModel.Wordprocessing.Columns? Columns { get; set; }
  
  
  /// <summary>
  ///   FormProtection.
  /// </summary>
  public Boolean? FormProtection { get; set; }
  
  
  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalJustificationValues? VerticalTextAlignmentOnPage { get; set; }
  
  
  /// <summary>
  ///   NoEndnote.
  /// </summary>
  public Boolean? NoEndnote { get; set; }
  
  
  /// <summary>
  ///   TitlePage.
  /// </summary>
  public Boolean? TitlePage { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionValues? TextDirection { get; set; }
  
  
  /// <summary>
  ///   BiDi.
  /// </summary>
  public Boolean? BiDi { get; set; }
  
  
  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  public Boolean? GutterOnRight { get; set; }
  
  
  /// <summary>
  ///   DocGrid.
  /// </summary>
  public DocumentModel.Wordprocessing.DocGrid? DocGrid { get; set; }
  
  
  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? PrinterSettingsReference { get; set; }
  
  
  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get; set; }
  
}
