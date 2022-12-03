namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OrientationTransitionType Class.
/// </summary>
public interface OrientationTransitionType // : System.Boolean
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DirectionKind? Direction { get ; set; }
  
}
