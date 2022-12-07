namespace DocumentModel.Vml;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public interface Lock
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
