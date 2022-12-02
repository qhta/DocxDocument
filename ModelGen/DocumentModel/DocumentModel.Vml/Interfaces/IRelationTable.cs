namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public interface IRelationTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public Collection<IRelation>? Relations { get ; set; }
  
}
