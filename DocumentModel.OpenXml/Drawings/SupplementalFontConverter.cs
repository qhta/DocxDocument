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
    return openXmlElement?.Script?.Value;
  }
  
  private static bool CmpScript(DXDraw.SupplementalFont openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Script?.Value == value;
  }
  
  private static void SetScript(DXDraw.SupplementalFont openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Script = new StringValue { Value = value };
    else
      openXmlElement.Script = null;
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  private static String? GetTypeface(DXDraw.SupplementalFont openXmlElement)
  {
    return openXmlElement?.Typeface?.Value;
  }
  
  private static bool CmpTypeface(DXDraw.SupplementalFont openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Typeface?.Value == value;
  }
  
  private static void SetTypeface(DXDraw.SupplementalFont openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Typeface = new StringValue { Value = value };
    else
      openXmlElement.Typeface = null;
  }
  
  public static DMDraws.SupplementalFont? CreateModelElement(DXDraw.SupplementalFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.SupplementalFont();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SupplementalFont? value)
    where OpenXmlElementType: DXDraw.SupplementalFont, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScript(openXmlElement, value?.Script);
      SetTypeface(openXmlElement, value?.Typeface);
      return openXmlElement;
    }
    return default;
  }
}
