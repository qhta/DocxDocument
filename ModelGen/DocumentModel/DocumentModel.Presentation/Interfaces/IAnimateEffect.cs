namespace DocumentModel.Presentation;

/// <summary>
/// Animate Effect.
/// </summary>
public interface IAnimateEffect // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// Progress.
  /// </summary>
  public IProgress? Progress { get ; set; }
  
}
