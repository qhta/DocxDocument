namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Strict Kinsoku Rules for Japanese Text.
/// </summary>
public class StrictFirstAndLastChars: IStrictFirstAndLastChars
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
