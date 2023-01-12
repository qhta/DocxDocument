namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public static class SchemaReferenceConverter
{
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.CustomXml.SchemaReference? CreateModelElement(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomXml.SchemaReference();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomXml.SchemaReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
