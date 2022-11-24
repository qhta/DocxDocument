namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RelationshipType Class.
/// </summary>
public interface IRelationshipType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id { get ; set; }
  
}
