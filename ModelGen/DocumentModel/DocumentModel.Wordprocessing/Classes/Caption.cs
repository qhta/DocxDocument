namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public class Caption
{
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public CaptionPositionKind? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public NumberFormatKind? NumberFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public ChapterSeparatorKind? Separator
  {
    get;
    set;
  }
  
}
