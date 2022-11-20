namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the FlythroughTransition Class.
/// </summary>
public class FlythroughTransition: IFlythroughTransition
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionInOutDirectionValues? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// hasBounce, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? HasBounce
  {
    get;
    set;
  }
  
}
