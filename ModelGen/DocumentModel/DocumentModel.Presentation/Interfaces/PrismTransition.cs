namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PrismTransition Class.
/// </summary>
public interface PrismTransition // : System.Boolean
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionSlideDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// isContent, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsContent { get ; set; }
  
  /// <summary>
  /// isInverted, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsInverted { get ; set; }
  
}
