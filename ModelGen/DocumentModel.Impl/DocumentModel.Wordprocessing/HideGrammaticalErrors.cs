namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Display Visual Indication of Grammatical Errors.
/// </summary>
public class HideGrammaticalErrors: IHideGrammaticalErrors
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
