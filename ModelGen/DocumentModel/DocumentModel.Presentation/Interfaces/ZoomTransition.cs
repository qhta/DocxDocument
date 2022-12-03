namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ZoomTransition Class.
/// </summary>
public interface ZoomTransition // : System.Boolean
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
}
