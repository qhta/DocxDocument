namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public class PageNumberType
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  public NumberFormatKind? Format
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public ChapterSeparatorKind? ChapterSeparator
  {
    get;
    set;
  }
  
}
