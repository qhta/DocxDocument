namespace DocumentModel.Packaging;

/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public record XmlSignaturePart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}