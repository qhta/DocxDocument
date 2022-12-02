namespace DocumentModel.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public interface IRules // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public Collection<IRule>? Rules { get ; set; }
  
}
