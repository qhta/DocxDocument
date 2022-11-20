namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Allow Hanging Punctuation With Character Grid.
/// </summary>
public class DoNotWrapTextWithPunctuation: IDoNotWrapTextWithPunctuation
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
