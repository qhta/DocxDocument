namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public class CustomXmlPropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomXmlPropertiesPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
