namespace DocumentModel.Vml.Office;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public interface IRelationTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Vml.Office.IRelation>? Relations { get ; set; }
  
}
