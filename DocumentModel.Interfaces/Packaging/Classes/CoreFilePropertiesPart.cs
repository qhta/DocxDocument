namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CoreFilePropertiesPart
/// </summary>
public interface CoreFilePropertiesPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}