namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public interface ICaption // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public DocumentModel.Wordprocessing.CaptionPositionKind? Position { get ; set; }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  public System.Boolean? ChapterNumber { get ; set; }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public System.Int32? Heading { get ; set; }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public System.Boolean? NoLabel { get ; set; }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? NumberFormat { get ; set; }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public DocumentModel.Wordprocessing.ChapterSeparatorKind? Separator { get ; set; }
  
}
