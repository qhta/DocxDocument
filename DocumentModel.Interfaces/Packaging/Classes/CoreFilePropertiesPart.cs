namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CoreFilePropertiesPart
/// </summary>
public class CoreFilePropertiesPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}