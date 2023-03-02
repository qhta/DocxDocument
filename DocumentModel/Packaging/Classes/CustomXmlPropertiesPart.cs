using DocumentModel.CustomXml;

namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomXmlPropertiesPart
/// </summary>
public record CustomXmlPropertiesPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DataStoreItem? DataStoreItem { get; set; }

  public String? RelationshipType { get; set; }
}