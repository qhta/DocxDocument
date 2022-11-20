namespace DocumentModel.Vml.Office;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IRelation))]
public class RelationTable: IRelationTable
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension
  {
    get;
    set;
  }
  
}
