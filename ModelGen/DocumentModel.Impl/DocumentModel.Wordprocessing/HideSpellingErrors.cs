namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Display Visual Indication of Spelling Errors.
/// </summary>
public class HideSpellingErrors: IHideSpellingErrors
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
