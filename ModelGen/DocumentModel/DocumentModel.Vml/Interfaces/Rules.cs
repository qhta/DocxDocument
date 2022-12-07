namespace DocumentModel.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public interface Rules
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
