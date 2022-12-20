namespace DocumentModel.Packaging;

/// <summary>
/// Defines the XmlSignaturePart
/// </summary>
public partial interface XmlSignaturePart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
