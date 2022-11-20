namespace DocumentModel.Presentation;

/// <summary>
/// Animate Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IProgress))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
public interface IAnimateEffect // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Transition
  /// </summary>
  public AnimateEffectTransitionValues? Transition { get ; set; }
  
  /// <summary>
  /// Filter
  /// </summary>
  public string? Filter { get ; set; }
  
  /// <summary>
  /// Property List
  /// </summary>
  public string? PropertyList { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
  /// <summary>
  /// Progress.
  /// </summary>
  public IProgress? Progress { get ; set; }
  
}
