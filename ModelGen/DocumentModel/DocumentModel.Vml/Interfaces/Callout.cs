namespace DocumentModel.Vml;

/// <summary>
/// Defines the Callout Class.
/// </summary>
public interface Callout
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Callout angle
  /// </summary>
  public AngleKind? Angle { get ; set; }
  
}
