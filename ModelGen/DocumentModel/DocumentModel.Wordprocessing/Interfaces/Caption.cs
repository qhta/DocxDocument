namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public interface Caption
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public DocumentModel.Wordprocessing.CaptionPositionKind? Position { get ; set; }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  public Boolean? ChapterNumber { get ; set; }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public Int32? Heading { get ; set; }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public Boolean? NoLabel { get ; set; }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? NumberFormat { get ; set; }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public DocumentModel.Wordprocessing.ChapterSeparatorKind? Separator { get ; set; }
  
}
