namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public interface ICaption // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public CaptionPosition? Position { get ; set; }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  public bool? ChapterNumber { get ; set; }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public int? Heading { get ; set; }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public bool? NoLabel { get ; set; }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public NumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public ChapterSeparator? Separator { get ; set; }
  
}
