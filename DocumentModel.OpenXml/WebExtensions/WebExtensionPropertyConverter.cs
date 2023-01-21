namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public static class WebExtensionPropertyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetName(DXO2013WebExt.WebExtensionProperty openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXO2013WebExt.WebExtensionProperty openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetValue(DXO2013WebExt.WebExtensionProperty openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static void SetValue(DXO2013WebExt.WebExtensionProperty openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Value = new StringValue { Value = value };
    else
      openXmlElement.Value = null;
  }
  
  public static DMWebExt.WebExtensionProperty? CreateModelElement(DXO2013WebExt.WebExtensionProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWebExt.WebExtensionProperty();
      value.Name = GetName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWebExt.WebExtensionProperty? value)
    where OpenXmlElementType: DXO2013WebExt.WebExtensionProperty, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
