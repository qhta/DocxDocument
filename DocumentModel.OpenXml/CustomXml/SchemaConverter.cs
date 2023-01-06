namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public static class SchemaConverter
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Uri = value;
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  public static String? GetManifestLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement)
  {
    return openXmlElement?.ManifestLocation?.Value;
  }
  
  public static void SetManifestLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.ManifestLocation = value;
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  public static String? GetSchemaLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement)
  {
    return openXmlElement?.SchemaLocation?.Value;
  }
  
  public static void SetSchemaLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.SchemaLocation = value;
  }
  
  public static DocumentModel.CustomXml.Schema? GetValue(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.Schema();
      value.Uri = GetUri(openXmlElement);
      value.ManifestLocation = GetManifestLocation(openXmlElement);
      value.SchemaLocation = GetSchemaLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement, DocumentModel.CustomXml.Schema? value)
  {
    if (openXmlElement != null)
    {
      SetUri(openXmlElement, value?.Uri);
      SetManifestLocation(openXmlElement, value?.ManifestLocation);
      SetSchemaLocation(openXmlElement, value?.SchemaLocation);
    }
  }
  
  public static DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? CreateOpenXmlElement(DocumentModel.CustomXml.Schema? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
