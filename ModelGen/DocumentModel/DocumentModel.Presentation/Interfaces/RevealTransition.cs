namespace DocumentModel.Presentation;

/// <summary>
/// Defines the RevealTransition Class.
/// </summary>
public interface RevealTransition // : System.Boolean
{
  /// <summary>
  /// thruBlk, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ThroughBlack { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionKind? Direction { get ; set; }
  
}
