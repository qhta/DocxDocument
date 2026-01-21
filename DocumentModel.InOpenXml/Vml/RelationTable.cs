namespace DocumentModel.Vml;
/// <summary>
///   Diagram Relationship Table.
/// </summary>
public partial class RelationTable : ModelElement<DXVO.RelationTable>
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