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
    return StringValueConverter.GetValue(openXmlElement?.EmbeddedHtml);
  }
  
  private static bool CmpEmbeddedHtml(DXO2013WDraw.WebVideoProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EmbeddedHtml, value, diffs, objName, "EmbeddedHtml");
  }
  
  private static void SetEmbeddedHtml(DXO2013WDraw.WebVideoProperty openXmlElement, String? value)
  {
    openXmlElement.EmbeddedHtml = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetHeight(DXO2013WDraw.WebVideoProperty openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXO2013WDraw.WebVideoProperty openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
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
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXO2013WDraw.WebVideoProperty openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXO2013WDraw.WebVideoProperty openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WebVideoProperty? CreateModelElement(DXO2013WDraw.WebVideoProperty? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013WDraw.WebVideoProperty? openXmlElement, DMDrawsW.WebVideoProperty? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbeddedHtml(openXmlElement, value.EmbeddedHtml, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WebVideoProperty value)
    where OpenXmlElementType: DXO2013WDraw.WebVideoProperty, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013WDraw.WebVideoProperty openXmlElement, DMDrawsW.WebVideoProperty value)
  {
    SetEmbeddedHtml(openXmlElement, value?.EmbeddedHtml);
    SetHeight(openXmlElement, value?.Height);
    SetWidth(openXmlElement, value?.Width);
  }
}
