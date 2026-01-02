namespace DocumentModel.Packaging;

/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public class XmlSignaturePart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}