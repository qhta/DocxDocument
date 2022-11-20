namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behavior.
/// </summary>
public class Behavior: IBehavior
{
  /// <summary>
  /// Insertion Behavior Value
  /// </summary>
  public DocPartBehaviorValues? Val
  {
    get;
    set;
  }
  
}
