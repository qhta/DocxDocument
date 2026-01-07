namespace DocumentModel.Packaging;

/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public interface XmlSignaturePart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}