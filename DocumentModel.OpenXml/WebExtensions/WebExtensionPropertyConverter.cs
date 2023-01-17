namespace DocumentModel.OpenXml.WebExtensions;

/// <summary>
/// Defines the WebExtensionProperty Class.
/// </summary>
public static class WebExtensionPropertyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetValue(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static void SetValue(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Value = new StringValue { Value = value };
    else
      openXmlElement.Value = null;
  }
  
  public static DocumentModel.WebExtensions.WebExtensionProperty? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.WebExtensionProperty();
      value.Name = GetName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.WebExtensionProperty? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty, new()
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
