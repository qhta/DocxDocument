namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ClassificationExtension Class.
/// </summary>
public static class ClassificationExtensionConverter
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUri(DXO2021MipLabelMeta.ClassificationExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXO2021MipLabelMeta.ClassificationExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DM.ClassificationExtension? CreateModelElement(DXO2021MipLabelMeta.ClassificationExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ClassificationExtension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ClassificationExtension? value)
    where OpenXmlElementType: DXO2021MipLabelMeta.ClassificationExtension, new()
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
