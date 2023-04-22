namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Magnification Setting.
/// </summary>
public static class ZoomConverter
{
  /// <summary>
  /// Zoom Type
  /// </summary>
  private static DMW.PresetZoomKind? GetVal(DXW.Zoom openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.PresetZoomValues, DMW.PresetZoomKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.Zoom openXmlElement, DMW.PresetZoomKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.PresetZoomValues, DMW.PresetZoomKind>(openXmlElement?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVal(DXW.Zoom openXmlElement, DMW.PresetZoomKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.PresetZoomValues, DMW.PresetZoomKind>(value);
  }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  private static int? GetPercent(DXW.Zoom openXmlElement)
  {
    var valStr = openXmlElement?.Percent?.Value;
    if (valStr != null)
    {
      if (valStr.EndsWith('%'))
        valStr = valStr.Substring(0, valStr.Length - 1);
      return Convert.ToInt32(valStr);
    }
    return null;
  }
  
  private static bool CmpPercent(DXW.Zoom openXmlElement, int? value, DiffList? diffs, string? objName)
  {
    var valStr = (value != null) ? (value.ToString() + "%") : null;
    if (openXmlElement?.Percent?.Value == valStr) return true;
    diffs?.Add(objName, "Pct", openXmlElement?.Percent?.Value, valStr);
    return false;
  }
  
  private static void SetPercent(DXW.Zoom openXmlElement, int? value)
  {
    if (value != null)
      openXmlElement.Percent = new StringValue { Value = (value != null) ? (value.ToString() + "%") : null };
    else
      openXmlElement.Percent = null;
  }
  
  public static DMW.Zoom? CreateModelElement(DXW.Zoom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Zoom();
      value.Kind = GetVal(openXmlElement);
      value.Percent = GetPercent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Zoom? openXmlElement, DMW.Zoom? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Kind, diffs, objName))
        ok = false;
      if (!CmpPercent(openXmlElement, value.Percent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Zoom? value)
    where OpenXmlElementType: DXW.Zoom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Kind);
      SetPercent(openXmlElement, value?.Percent);
      return openXmlElement;
    }
    return default;
  }
}
