namespace DocumentModel.Wordprocessing;

/// <summary>
/// Content Between Numbering Symbol and Paragraph Text.
/// </summary>
public class LevelSuffix: ILevelSuffix
{
  /// <summary>
  /// Character Type Between Numbering and Text
  /// </summary>
  public LevelSuffixValues? Val
  {
    get;
    set;
  }
  
}
