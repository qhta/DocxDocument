namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the WebVideoProperty Class.
/// </summary>
public static class WebVideoPropertyConverter
{
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetEmbeddedHtml(DXO13WD.WebVideoProperty openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EmbeddedHtml);
  }
  
  private static bool CmpEmbeddedHtml(DXO13WD.WebVideoProperty openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EmbeddedHtml, value, diffs, objName, "EmbeddedHtml");
  }
  
  private static void SetEmbeddedHtml(DXO13WD.WebVideoProperty openXmlElement, String? value)
  {
    openXmlElement.EmbeddedHtml = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetHeight(DXO13WD.WebVideoProperty openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXO13WD.WebVideoProperty openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXO13WD.WebVideoProperty openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetWidth(DXO13WD.WebVideoProperty openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXO13WD.WebVideoProperty openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXO13WD.WebVideoProperty openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WebVideoProperty? CreateModelElement(DXO13WD.WebVideoProperty? openXmlElement)
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
  
  public static bool CompareModelElement(DXO13WD.WebVideoProperty? openXmlElement, DMDW.WebVideoProperty? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbeddedHtml(openXmlElement, value.EmbeddedHtml, diffs, objName, propName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName, propName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.WebVideoProperty value)
    where OpenXmlElementType: DXO13WD.WebVideoProperty, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13WD.WebVideoProperty openXmlElement, DMDW.WebVideoProperty value)
  {
    SetEmbeddedHtml(openXmlElement, value?.EmbeddedHtml);
    SetHeight(openXmlElement, value?.Height);
    SetWidth(openXmlElement, value?.Width);
  }
}
