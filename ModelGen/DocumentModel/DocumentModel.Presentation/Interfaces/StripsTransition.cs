namespace DocumentModel.Presentation;

/// <summary>
/// Defines the StripsTransition Class.
/// </summary>
public interface StripsTransition // : System.Boolean
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionCornerDirectionKind? Direction { get ; set; }
  
}
