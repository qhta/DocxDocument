namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionPartReference Class.
/// </summary>
public static class WebExtensionPartReferenceConverter
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013WebExtPane.WebExtensionPartReference openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2013WebExtPane.WebExtensionPartReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMWebExtUI.WebExtensionPartReference? CreateModelElement(DXO2013WebExtPane.WebExtensionPartReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExtUI.WebExtensionPartReference();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExtUI.WebExtensionPartReference? value)
    where OpenXmlElementType: DXO2013WebExtPane.WebExtensionPartReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
