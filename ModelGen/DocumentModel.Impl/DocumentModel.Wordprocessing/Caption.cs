namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public class Caption: ICaption
{
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public CaptionPositionValues? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  public bool? ChapterNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public int? Heading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public bool? NoLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public NumberFormatValues? NumberFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public ChapterSeparatorValues? Separator
  {
    get;
    set;
  }
  
}
