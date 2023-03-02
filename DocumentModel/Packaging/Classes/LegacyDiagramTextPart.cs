namespace DocumentModel.Packaging;

/// <summary>
///   Defines the LegacyDiagramTextPart
/// </summary>
public record LegacyDiagramTextPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}