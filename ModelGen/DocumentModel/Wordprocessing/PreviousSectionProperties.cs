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
  public DMW.FootnoteProperties? FootnoteProperties { get; set; }
  
  
  /// <summary>
  ///   EndnoteProperties.
  /// </summary>
  public DMW.EndnoteProperties? EndnoteProperties { get; set; }
  
  
  /// <summary>
  ///   SectionType.
  /// </summary>
  public DMW.SectionMarkKind? SectionType { get; set; }
  
  
  /// <summary>
  ///   PageSize.
  /// </summary>
  public DMW.PageSize? PageSize { get; set; }
  
  
  /// <summary>
  ///   PageMargin.
  /// </summary>
  public DMW.PageMargin? PageMargin { get; set; }
  
  
  /// <summary>
  ///   PaperSource.
  /// </summary>
  public DMW.PaperSource? PaperSource { get; set; }
  
  
  /// <summary>
  ///   PageBorders.
  /// </summary>
  public DMW.PageBorders? PageBorders { get; set; }
  
  
  /// <summary>
  ///   LineNumberType.
  /// </summary>
  public DMW.LineNumberType? LineNumberType { get; set; }
  
  
  /// <summary>
  ///   PageNumberType.
  /// </summary>
  public DMW.PageNumberType? PageNumberType { get; set; }
  
  
  /// <summary>
  ///   Columns.
  /// </summary>
  public DMW.Columns? Columns { get; set; }
  
  
  /// <summary>
  ///   FormProtection.
  /// </summary>
  public DMW.FormProtection? FormProtection { get; set; }
  
  
  /// <summary>
  ///   VerticalTextAlignmentOnPage.
  /// </summary>
  public DMW.VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  
  
  /// <summary>
  ///   NoEndnote.
  /// </summary>
  public DMW.NoEndnote? NoEndnote { get; set; }
  
  
  /// <summary>
  ///   TitlePage.
  /// </summary>
  public DMW.TitlePage? TitlePage { get; set; }
  
  
  /// <summary>
  ///   TextDirection.
  /// </summary>
  public DMW.TextDirectionKind? TextDirection { get; set; }
  
  
  /// <summary>
  ///   BiDi.
  /// </summary>
  public DMW.BiDi? BiDi { get; set; }
  
  
  /// <summary>
  ///   GutterOnRight.
  /// </summary>
  public DMW.GutterOnRight? GutterOnRight { get; set; }
  
  
  /// <summary>
  ///   DocGrid.
  /// </summary>
  public DMW.DocGrid? DocGrid { get; set; }
  
  
  /// <summary>
  ///   PrinterSettingsReference.
  /// </summary>
  public DMW.PrinterSettingsReference? PrinterSettingsReference { get; set; }
  
  
  /// <summary>
  ///   FootnoteColumns, this property is only available in Office 2013 and later..
  /// </summary>
  public Int32? FootnoteColumns { get; set; }
  
}
