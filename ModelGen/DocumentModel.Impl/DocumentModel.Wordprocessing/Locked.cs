namespace DocumentModel.Wordprocessing;

/// <summary>
/// Style Cannot Be Applied.
/// </summary>
public class Locked: ILocked
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
