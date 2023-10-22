namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element defines the section properties for the section of the document.
/// </summary>
public partial class SectionProperties
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
  
  public DocumentModel.Wordprocessing.FormProtection? FormProtection { get; set; }
  
  public DocumentModel.Wordprocessing.VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  
  public DocumentModel.Wordprocessing.NoEndnote? NoEndnote { get; set; }
  
  public DocumentModel.Wordprocessing.TitlePage? TitlePage { get; set; }
  
  public DocumentModel.Wordprocessing.TextDirectionKind? TextDirection { get; set; }
  
  public DocumentModel.Wordprocessing.BiDi? BiDi { get; set; }
  
  public DocumentModel.Wordprocessing.GutterOnRight? GutterOnRight { get; set; }
  
  public DocumentModel.Wordprocessing.DocGrid? DocGrid { get; set; }
  
  public DocumentModel.Wordprocessing.PrinterSettingsReference? PrinterSettingsReference { get; set; }
  
  public Int32? FootnoteColumns { get; set; }
  
  public DocumentModel.Wordprocessing.SectionPropertiesChange? SectionPropertiesChange { get; set; }
  
}
