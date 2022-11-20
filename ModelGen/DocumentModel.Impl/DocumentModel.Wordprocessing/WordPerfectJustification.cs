namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate WordPerfect 6.x Paragraph Justification.
/// </summary>
public class WordPerfectJustification: IWordPerfectJustification
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
