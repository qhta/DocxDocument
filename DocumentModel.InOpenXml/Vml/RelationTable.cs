namespace DocumentModel.Vml;

/// <summary>
///   Diagram Relationship Table.
/// </summary>
public class RelationTable: ModelElement
{
  /// <summary>
  ///   Collection of diagram relationships.
  /// </summary>
  public Relations? Relations { get; set; }

  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

}