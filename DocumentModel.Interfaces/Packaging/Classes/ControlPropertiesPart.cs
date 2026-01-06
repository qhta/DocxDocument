namespace DocumentModel.Packaging;

/// <summary>
///   Defines the ControlPropertiesPart
/// </summary>
public interface ControlPropertiesPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}