namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the WebVideoProperty Class.
/// </summary>
public static class WebVideoPropertyConverter
{
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetEmbeddedHtml(DXO2013WDraw.WebVideoProperty openXmlElement)
  {
    return openXmlElement?.EmbeddedHtml?.Value;
  }
  
  private static void SetEmbeddedHtml(DXO2013WDraw.WebVideoProperty openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EmbeddedHtml = new StringValue { Value = value };
    else
      openXmlElement.EmbeddedHtml = null;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetHeight(DXO2013WDraw.WebVideoProperty openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DXO2013WDraw.WebVideoProperty openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetWidth(DXO2013WDraw.WebVideoProperty openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXO2013WDraw.WebVideoProperty openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  public static DMDrawsW.WebVideoProperty? CreateModelElement(DXO2013WDraw.WebVideoProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.WebVideoProperty();
      value.EmbeddedHtml = GetEmbeddedHtml(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WebVideoProperty? value)
    where OpenXmlElementType: DXO2013WDraw.WebVideoProperty, new()
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
