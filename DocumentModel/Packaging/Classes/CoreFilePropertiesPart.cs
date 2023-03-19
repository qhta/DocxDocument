namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CoreFilePropertiesPart
/// </summary>
public class CoreFilePropertiesPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}