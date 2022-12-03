namespace DocumentModel.Presentation;

/// <summary>
/// Defines the FlythroughTransition Class.
/// </summary>
public interface FlythroughTransition // : System.Boolean
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// hasBounce, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? HasBounce { get ; set; }
  
}
