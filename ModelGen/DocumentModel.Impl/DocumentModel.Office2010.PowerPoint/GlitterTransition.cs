namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the GlitterTransition Class.
/// </summary>
public class GlitterTransition: IGlitterTransition
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
  /// pattern, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionPatternValues? Pattern
  {
    get;
    set;
  }
  
}
