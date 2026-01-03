namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ThumbnailPart
/// </summary>
public interface ThumbnailPart: IModelElement
{
  public string? RelationshipType { get; set; }
}