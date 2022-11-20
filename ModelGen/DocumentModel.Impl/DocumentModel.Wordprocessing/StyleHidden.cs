namespace DocumentModel.Wordprocessing;

/// <summary>
/// Hide Style From User Interface.
/// </summary>
public class StyleHidden: IStyleHidden
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnlyValues? Val
  {
    get;
    set;
  }
  
}
