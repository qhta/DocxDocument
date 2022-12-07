namespace DocumentModel.Vml;

/// <summary>
/// VML Diagram.
/// </summary>
public interface Diagram
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Diagram Relationship Table.
  /// </summary>
  public RelationTable? RelationTable { get ; set; }
  
}
