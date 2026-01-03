namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedObjectPart
/// </summary>
public interface EmbeddedObjectPart: IModelElement
{
  public string? RelationshipType { get; set; }
}