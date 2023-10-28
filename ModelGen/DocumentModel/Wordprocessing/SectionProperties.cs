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
  
  public DMW.FootnoteProperties? FootnoteProperties { get; set; }
  
  public DMW.EndnoteProperties? EndnoteProperties { get; set; }
  
  public DMW.SectionMarkKind? SectionType { get; set; }
  
  public DMW.PageSize? PageSize { get; set; }
  
  public DMW.PageMargin? PageMargin { get; set; }
  
  public DMW.PaperSource? PaperSource { get; set; }
  
  public DMW.PageBorders? PageBorders { get; set; }
  
  public DMW.LineNumberType? LineNumberType { get; set; }
  
  public DMW.PageNumberType? PageNumberType { get; set; }
  
  public DMW.Columns? Columns { get; set; }
  
  public DMW.FormProtection? FormProtection { get; set; }
  
  public DMW.VerticalJustificationKind? VerticalTextAlignmentOnPage { get; set; }
  
  public DMW.NoEndnote? NoEndnote { get; set; }
  
  public DMW.TitlePage? TitlePage { get; set; }
  
  public DMW.TextDirectionKind? TextDirection { get; set; }
  
  public DMW.BiDi? BiDi { get; set; }
  
  public DMW.GutterOnRight? GutterOnRight { get; set; }
  
  public DMW.DocGrid? DocGrid { get; set; }
  
  public DMW.PrinterSettingsReference? PrinterSettingsReference { get; set; }
  
  public Int32? FootnoteColumns { get; set; }
  
  public DMW.SectionPropertiesChange? SectionPropertiesChange { get; set; }
  
}
