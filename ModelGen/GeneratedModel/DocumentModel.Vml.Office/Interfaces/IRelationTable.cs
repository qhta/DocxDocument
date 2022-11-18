namespace DocumentModel.Vml.Office;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IRelation))]
public interface IRelationTable // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
}
