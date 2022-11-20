namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the FlipTransition Class.
/// </summary>
public class FlipTransition: IFlipTransition
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionTypeValues? Direction
  {
    get;
    set;
  }
  
}
