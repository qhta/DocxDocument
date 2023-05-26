namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Font.
/// </summary>
public static class SupplementalFontConverter
{
  /// <summary>
  /// Script
  /// </summary>
  private static String? GetScript(DXD.SupplementalFont openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Script);
  }
  
  private static bool CmpScript(DXD.SupplementalFont openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Script, value, diffs, objName, "Script");
  }
  
  private static void SetScript(DXD.SupplementalFont openXmlElement, String? value)
  {
    openXmlElement.Script = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  private static String? GetTypeface(DXD.SupplementalFont openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Typeface);
  }
  
  private static bool CmpTypeface(DXD.SupplementalFont openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Typeface, value, diffs, objName, "Typeface");
  }
  
  private static void SetTypeface(DXD.SupplementalFont openXmlElement, String? value)
  {
    openXmlElement.Typeface = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.SupplementalFont? CreateModelElement(DXD.SupplementalFont? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.SupplementalFont? openXmlElement, DMD.SupplementalFont? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScript(openXmlElement, value.Script, diffs, objName, propName))
        ok = false;
      if (!CmpTypeface(openXmlElement, value.Typeface, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.SupplementalFont value)
    where OpenXmlElementType: DXD.SupplementalFont, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.SupplementalFont openXmlElement, DMD.SupplementalFont value)
  {
    SetScript(openXmlElement, value?.Script);
    SetTypeface(openXmlElement, value?.Typeface);
  }
}
