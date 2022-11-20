namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public class LevelText: ILevelText
{
  /// <summary>
  /// Level Text
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public bool? Null
  {
    get;
    set;
  }
  
}
