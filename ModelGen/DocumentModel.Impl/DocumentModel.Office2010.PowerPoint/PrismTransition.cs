namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the PrismTransition Class.
/// </summary>
public class PrismTransition: IPrismTransition
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionSlideDirectionValues? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// isContent, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? IsContent
  {
    get;
    set;
  }
  
  /// <summary>
  /// isInverted, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? IsInverted
  {
    get;
    set;
  }
  
}
