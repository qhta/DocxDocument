using DocumentFormat.OpenXml.Office2013.Word.Drawing;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public static class WebVideoPropertyConverter
{
  /// <summary>
  ///   embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetEmbeddedHtml(WebVideoProperty? openXmlElement)
  {
    return openXmlElement?.EmbeddedHtml?.Value;
  }

  public static void SetEmbeddedHtml(WebVideoProperty? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EmbeddedHtml = new StringValue { Value = value };
      else
        openXmlElement.EmbeddedHtml = null;
  }

  /// <summary>
  ///   h, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetHeight(WebVideoProperty? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(WebVideoProperty? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   w, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetWidth(WebVideoProperty? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(WebVideoProperty? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  public static DocumentModel.Drawings.Wordprocessing.WebVideoProperty? CreateModelElement(WebVideoProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WebVideoProperty();
      value.EmbeddedHtml = GetEmbeddedHtml(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WebVideoProperty? value)
    where OpenXmlElementType : WebVideoProperty, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEmbeddedHtml(openXmlElement, value?.EmbeddedHtml);
      SetHeight(openXmlElement, value?.Height);
      SetWidth(openXmlElement, value?.Width);
      return openXmlElement;
    }
    return default;
  }
}