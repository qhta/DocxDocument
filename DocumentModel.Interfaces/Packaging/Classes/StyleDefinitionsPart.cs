namespace DocumentModel.Packaging;

/// <summary>
///   Defines the StyleDefinitionsPart
/// </summary>
public interface StyleDefinitionsPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}