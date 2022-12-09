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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
