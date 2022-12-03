namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SideDirectionTransitionType Class.
/// </summary>
public interface SideDirectionTransitionType // : System.Boolean
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirectionKind? Direction { get ; set; }
  
}
