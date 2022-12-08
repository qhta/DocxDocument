namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public class SchemaImpl: ModelElementImpl, Schema
{
  public DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  public String? ManifestLocation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  public String? SchemaLocation
  {
    get;
    set;
  }
  
}
