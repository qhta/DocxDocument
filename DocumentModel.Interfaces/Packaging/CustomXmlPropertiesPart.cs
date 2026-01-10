using DocumentModel.CustomXml;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the CustomXmlPropertiesPart
/// </summary>
public interface CustomXmlPropertiesPart: OpenXmlPart
{

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DataStoreItem? DataStoreItem { get; set; }

}