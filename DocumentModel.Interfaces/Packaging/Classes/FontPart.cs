namespace DocumentModel.Packaging;

/// <summary>
///   Defines the FontPart
/// </summary>
public interface FontPart: IModelElement
{
  public string? RelationshipType { get; set; }
}