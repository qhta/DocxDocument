namespace DocumentModel.Packaging;

/// <summary>
///   Defines the EmbeddedPackagePart
/// </summary>
public interface EmbeddedPackagePart: OpenXmlPart
{
  public string? RelationshipType { get; set; }
}