namespace DocumentModel.Presentation;

/// <summary>
/// Defines the WarpTransition Class.
/// </summary>
public interface WarpTransition // : System.Boolean
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
}
