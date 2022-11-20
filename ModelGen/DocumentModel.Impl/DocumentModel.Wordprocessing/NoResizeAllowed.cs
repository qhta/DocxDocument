namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frame Cannot Be Resized.
/// </summary>
public class NoResizeAllowed: INoResizeAllowed
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
