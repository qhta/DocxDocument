namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Extension? CreateModelElement(DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Extension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension, new()
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
