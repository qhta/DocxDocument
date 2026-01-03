namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VbaProjectPart
/// </summary>
public interface VbaProjectPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}