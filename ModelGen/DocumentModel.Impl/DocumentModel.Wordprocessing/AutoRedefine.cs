namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatically Merge User Formatting Into Style Definition.
/// </summary>
public class AutoRedefine: IAutoRedefine
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
