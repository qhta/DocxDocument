using DocumentModel.CustomXml;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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