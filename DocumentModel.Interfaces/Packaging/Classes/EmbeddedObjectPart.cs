namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedObjectPart
/// </summary>
public interface EmbeddedObjectPart: OpenXmlPart
{
  public string? RelationshipType { get; set; }
}