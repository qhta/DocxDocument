namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the XmlSignaturePart
/// </summary>
public class XmlSignaturePart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}