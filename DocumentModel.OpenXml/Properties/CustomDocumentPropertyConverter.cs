namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public static class CustomDocumentPropertyConverter
{
  /// <summary>
  /// Format ID
  /// </summary>
  public static String? GetFormatId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.FormatId;
  }
  
  public static void SetFormatId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.FormatId = value;
  }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public static Int32? GetPropertyId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.PropertyId?.Value;
  }
  
  public static void SetPropertyId(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PropertyId = value;
  }
  
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.Name;
  }
  
  public static void SetName(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.Name = value;
  }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  public static String? GetLinkTarget(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.LinkTarget;
  }
  
  public static void SetLinkTarget(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty openXmlElement, String? value)
  {
    if (openXmlElement != null)
      openXmlElement.LinkTarget = value;
  }
  
  public static DocumentModel.Properties.CustomDocumentProperty? GetValue(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? openXmlElement)
  {
    var value = new DocumentModel.Properties.CustomDocumentProperty();
    if (openXmlElement != null)
    {
      value.FormatId = GetFormatId(openXmlElement);
      value.PropertyId = GetPropertyId(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.LinkTarget = GetLinkTarget(openXmlElement);
    }
    return value;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? openXmlElement, DocumentModel.Properties.CustomDocumentProperty? value)
  {
    if (openXmlElement != null)
    {
      SetFormatId(openXmlElement, value?.FormatId);
      SetPropertyId(openXmlElement, value?.PropertyId);
      SetName(openXmlElement, value?.Name);
      SetLinkTarget(openXmlElement, value?.LinkTarget);
    }
  }
  
  public static DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty? CreateOpenXmlElement(DocumentModel.Properties.CustomDocumentProperty? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
