namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Extension.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.Extension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.Extension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DMDraws.Extension? CreateModelElement(DXDraw.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Extension? value)
    where OpenXmlElementType: DXDraw.Extension, new()
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
