namespace DocumentModel.Packaging;

/// <summary>
///   Defines the FontPart
/// </summary>
public interface FontPart: OpenXmlPart
{
  public string? RelationshipType { get; set; }
}