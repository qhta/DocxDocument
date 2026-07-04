namespace DocumentModel.Wordprocessing;

/// <summary>
/// Interface for defining a strongly-typed relationship element within a document model.
/// </summary>
public interface IRelationshipType
{
  /// <summary>
  /// Identifier of the relationship, corresponding to the 'r:id' attribute in the Open XML schema.
  /// This property is used to link the relationship to a specific part or resource within the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RelationshipType.Id))]
  public string? Id { get; set; }
}
