namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUri(DXO2021OExtLst.Extension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXO2021OExtLst.Extension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DM.Extension? CreateModelElement(DXO2021OExtLst.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Extension? value)
    where OpenXmlElementType: DXO2021OExtLst.Extension, new()
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
