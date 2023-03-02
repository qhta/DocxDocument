namespace DocumentModel.Packaging;

/// <summary>
///   Defines the Model3DReferenceRelationshipPart
/// </summary>
public record Model3DReferenceRelationshipPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}