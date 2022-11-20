namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the RevealTransition Class.
/// </summary>
public class RevealTransition: IRevealTransition
{
  /// <summary>
  /// thruBlk, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ThroughBlack
  {
    get;
    set;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionTypeValues? Direction
  {
    get;
    set;
  }
  
}
