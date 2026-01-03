namespace DocumentModel.Packaging;

/// <summary>
///   Defines the Model3DReferenceRelationshipPart
/// </summary>
public interface Model3DReferenceRelationshipPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}