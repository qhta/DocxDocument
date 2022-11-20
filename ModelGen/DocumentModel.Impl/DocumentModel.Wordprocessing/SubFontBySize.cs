namespace DocumentModel.Wordprocessing;

/// <summary>
/// Increase Priority Of Font Size During Font Substitution.
/// </summary>
public class SubFontBySize: ISubFontBySize
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
