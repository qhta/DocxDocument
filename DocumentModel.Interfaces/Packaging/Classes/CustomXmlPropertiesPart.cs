using DocumentModel.CustomXml;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomXmlPropertiesPart
/// </summary>
public class CustomXmlPropertiesPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DataStoreItem? DataStoreItem { get; set; }
  public string? RelationshipType { get; set; }
}