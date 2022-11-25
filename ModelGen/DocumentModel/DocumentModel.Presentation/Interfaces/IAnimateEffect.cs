namespace DocumentModel.Presentation;

/// <summary>
/// Animate Effect.
/// </summary>
public interface IAnimateEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Transition
  /// </summary>
  public DocumentModel.Presentation.AnimateEffectTransitionKind? Transition { get ; set; }
  
  /// <summary>
  /// Filter
  /// </summary>
  public System.String? Filter { get ; set; }
  
  /// <summary>
  /// Property List
  /// </summary>
  public System.String? PropertyList { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// Progress.
  /// </summary>
  public DocumentModel.Presentation.IProgress? Progress { get ; set; }
  
}
