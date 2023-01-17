namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Custom XML Schema Reference.
/// </summary>
public static class SchemaConverter
{
  /// <summary>
  /// Custom XML Schema Namespace
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// Resource File Location
  /// </summary>
  private static String? GetManifestLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement)
  {
    return openXmlElement?.ManifestLocation?.Value;
  }
  
  private static void SetManifestLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ManifestLocation = new StringValue { Value = value };
    else
      openXmlElement.ManifestLocation = null;
  }
  
  /// <summary>
  /// Custom XML Schema Location
  /// </summary>
  private static String? GetSchemaLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement)
  {
    return openXmlElement?.SchemaLocation?.Value;
  }
  
  private static void SetSchemaLocation(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SchemaLocation = new StringValue { Value = value };
    else
      openXmlElement.SchemaLocation = null;
  }
  
  public static DocumentModel.CustomXml.Schema? CreateModelElement(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomXml.Schema? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetManifestLocation(openXmlElement, value?.ManifestLocation);
      SetSchemaLocation(openXmlElement, value?.SchemaLocation);
      return openXmlElement;
    }
    return default;
  }
}
