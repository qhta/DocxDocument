namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomXmlPart
/// </summary>
public interface CustomXmlPart: CollectionItem
{
  public string? RelationshipType { get; set; }
}