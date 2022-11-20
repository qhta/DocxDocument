namespace DocumentModel.Wordprocessing;

/// <summary>
/// Never Kern Punctuation Characters.
/// </summary>
public class NoPunctuationKerning: INoPunctuationKerning
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
