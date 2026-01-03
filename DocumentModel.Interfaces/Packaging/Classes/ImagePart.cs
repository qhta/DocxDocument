namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ImagePart
/// </summary>
public interface ImagePart: IModelElement
{
  public string? RelationshipType { get; set; }
}