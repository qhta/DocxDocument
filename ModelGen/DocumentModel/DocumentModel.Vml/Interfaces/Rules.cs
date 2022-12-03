namespace DocumentModel.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public interface Rules // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public Collection<Rule>? Rules { get ; set; }
  
}
