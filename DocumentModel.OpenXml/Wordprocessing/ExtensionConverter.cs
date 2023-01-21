namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetUri(DXO2021WExtList.Extension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXO2021WExtList.Extension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DMW.Extension? CreateModelElement(DXO2021WExtList.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Extension? value)
    where OpenXmlElementType: DXO2021WExtList.Extension, new()
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
