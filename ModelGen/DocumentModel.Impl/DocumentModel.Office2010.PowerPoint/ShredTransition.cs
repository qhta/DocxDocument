namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ShredTransition Class.
/// </summary>
public class ShredTransition: IShredTransition
{
  /// <summary>
  /// pattern, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionShredPatternValues? Pattern
  {
    get;
    set;
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionInOutDirectionValues? Direction
  {
    get;
    set;
  }
  
}
