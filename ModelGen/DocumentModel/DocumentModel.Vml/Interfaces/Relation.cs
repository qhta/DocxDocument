namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship.
/// </summary>
public interface Relation
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
