using DocumentFormat.OpenXml.Office2013.WebExtentionPane;

namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionPartReference Class.
/// </summary>
public static class WebExtensionPartReferenceConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetId(WebExtensionPartReference? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(WebExtensionPartReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  public static DocumentModel.WebExtensions.UI.WebExtensionPartReference? CreateModelElement(WebExtensionPartReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.WebExtensionPartReference();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.UI.WebExtensionPartReference? value)
    where OpenXmlElementType : WebExtensionPartReference, new()
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