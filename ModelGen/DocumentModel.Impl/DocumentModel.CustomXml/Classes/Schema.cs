namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public partial class SchemaImpl: ModelElementImpl, Schema
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SchemaImpl(): base() {}
  
  public SchemaImpl(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  public String? ManifestLocation
  {
    get => (System.String?)OpenXmlElement?.ManifestLocation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ManifestLocation = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  public String? SchemaLocation
  {
    get => (System.String?)OpenXmlElement?.SchemaLocation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SchemaLocation = (System.String?)value;
    }
  }
  
}
