namespace DocumentModel.Wordprocessing;


/// <summary>
///   When specified as a child element of sectPrChange, the sectPr element specifies a set of section properties that were modified when the document was set to track all revisions.
/// </summary>
public partial class PreviousSectionProperties
{
  
  /// <summary>
  ///   Physical Section Mark Character Revision ID
  /// </summary>
  public DM.HexBinary? RsidRPr { get; set; }
  
  
  /// <summary>
  ///   Section Deletion Revision ID
  /// </summary>
  public DM.HexBinary? RsidDel { get; set; }
  
  
  /// <summary>
  ///   Section Addition Revision ID
  /// </summary>
  public DM.HexBinary? RsidR { get; set; }
  
  
  /// <summary>
  ///   Section Properties Revision ID
  /// </summary>
  public DM.HexBinary? RsidSect { get; set; }
  
  
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
  public DocumentModel.Wordprocessing.SectionMarkKind? SectionType { get; set; }
  
  
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
  public DocumentModel.Wordprocessing.FormProtection? FormProtection { get; set; }
  
  
  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  
  
  /// <summary>
  ///   NoEndnote.
  /// </summary>
  public DocumentModel.Wordprocessing.NoEndnote? NoEndnote { get; set; }
  
  
  /// <summary>
  ///   TitlePage.
  /// </summary>
  public DocumentModel.Wordprocessing.TitlePage? TitlePage { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  
  /// <summary>
  ///   BiDi.
  /// </summary>
  public DocumentModel.Wordprocessing.BiDi? BiDi { get; set; }
  
  
  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  public DocumentModel.Wordprocessing.GutterOnRight? GutterOnRight { get; set; }
  
  
  /// <summary>
  ///   DocGrid.
  /// </summary>
  public DocumentModel.Wordprocessing.DocGrid? DocGrid { get; set; }
  
  
  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  public DocumentModel.Wordprocessing.PrinterSettingsReference? PrinterSettingsReference { get; set; }
  
  
  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get; set; }
  
}
