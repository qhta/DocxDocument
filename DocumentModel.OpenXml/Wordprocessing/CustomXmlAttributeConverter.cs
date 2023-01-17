namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom XML Attribute.
/// </summary>
public static class CustomXmlAttributeConverter
{
  /// <summary>
  /// uri
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DocumentModel.Wordprocessing.CustomXmlAttribute? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CustomXmlAttribute();
      value.Uri = GetUri(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CustomXmlAttribute? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.CustomXmlAttribute, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetName(openXmlElement, value?.Name);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
