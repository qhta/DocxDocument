using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the WebSettingsPart
/// </summary>
public static class WebSettingsPartConverter
{
  public static String? GetContentType(WebSettingsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(WebSettingsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static WebSettings? GetWebSettings(WebSettingsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.WebSettings rootElement)
      return WebSettingsConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetWebSettings(WebSettingsPart? openXmlElement, WebSettings? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = WebSettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.WebSettings>(value);
        if (rootElement != null)
          openXmlElement.WebSettings = rootElement;
      }
  }

  public static DocumentModel.Packaging.WebSettingsPart? CreateModelElement(WebSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WebSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebSettings = GetWebSettings(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WebSettingsPart? value)
    where OpenXmlElementType : WebSettingsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetWebSettings(openXmlElement, value?.WebSettings);
      return openXmlElement;
    }
    return default;
  }
}