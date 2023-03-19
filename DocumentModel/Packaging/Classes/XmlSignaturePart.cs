namespace DocumentModel.Packaging;

/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public class XmlSignaturePart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}