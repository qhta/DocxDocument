namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationExtension Class.
/// </summary>
public static class ClassificationExtensionConverter
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.ClassificationExtension? CreateModelElement(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ClassificationExtension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.ClassificationExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
