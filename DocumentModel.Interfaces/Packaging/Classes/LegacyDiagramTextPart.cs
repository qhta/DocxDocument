namespace DocumentModel.Packaging;

/// <summary>
///   Defines the LegacyDiagramTextPart
/// </summary>
public interface LegacyDiagramTextPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}