namespace DocumentModel.Presentation;

/// <summary>
/// Defines the GlitterTransition Class.
/// </summary>
public interface GlitterTransition // : System.Boolean
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionSlideDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// pattern, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionPatternKind? Pattern { get ; set; }
  
}
