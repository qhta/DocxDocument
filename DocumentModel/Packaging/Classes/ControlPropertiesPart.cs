namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ControlPropertiesPart
/// </summary>
public record ControlPropertiesPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}