namespace DocumentModel.Presentation;

/// <summary>
/// Animate Effect.
/// </summary>
public interface AnimateEffect // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Transition
  /// </summary>
  public AnimateEffectTransitionKind? Transition { get ; set; }
  
  /// <summary>
  /// Filter
  /// </summary>
  public String? Filter { get ; set; }
  
  /// <summary>
  /// Property List
  /// </summary>
  public String? PropertyList { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public CommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// Progress.
  /// </summary>
  public Progress? Progress { get ; set; }
  
}
