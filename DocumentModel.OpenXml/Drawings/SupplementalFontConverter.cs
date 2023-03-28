namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font.
/// </summary>
public static class SupplementalFontConverter
{
  /// <summary>
  /// Script
  /// </summary>
  private static String? GetScript(DXDraw.SupplementalFont openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Script);
  }
  
  private static bool CmpScript(DXDraw.SupplementalFont openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Script, value, diffs, objName, "Script");
  }
  
  private static void SetScript(DXDraw.SupplementalFont openXmlElement, String? value)
  {
    openXmlElement.Script = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  private static String? GetTypeface(DXDraw.SupplementalFont openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Typeface);
  }
  
  private static bool CmpTypeface(DXDraw.SupplementalFont openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Typeface, value, diffs, objName, "Typeface");
  }
  
  private static void SetTypeface(DXDraw.SupplementalFont openXmlElement, String? value)
  {
    openXmlElement.Typeface = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.SupplementalFont? CreateModelElement(DXDraw.SupplementalFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SupplementalFont();
      value.Script = GetScript(openXmlElement);
      value.Typeface = GetTypeface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.SupplementalFont? openXmlElement, DMDraws.SupplementalFont? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScript(openXmlElement, value.Script, diffs, objName))
        ok = false;
      if (!CmpTypeface(openXmlElement, value.Typeface, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SupplementalFont value)
    where OpenXmlElementType: DXDraw.SupplementalFont, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.SupplementalFont openXmlElement, DMDraws.SupplementalFont value)
  {
    SetScript(openXmlElement, value?.Script);
    SetTypeface(openXmlElement, value?.Typeface);
  }
}
