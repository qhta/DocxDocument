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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues, DMW.PresetZoomKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.Zoom openXmlElement, DMW.PresetZoomKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues, DMW.PresetZoomKind>(openXmlElement?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVal(DXW.Zoom openXmlElement, DMW.PresetZoomKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PresetZoomValues, DMW.PresetZoomKind>(value);
  }
  
  /// <summary>
  /// Zoom Percentage
  /// </summary>
  private static String? GetPercent(DXW.Zoom openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Percent);
  }
  
  private static bool CmpPercent(DXW.Zoom openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Percent, value, diffs, objName, "Percent");
  }
  
  private static void SetPercent(DXW.Zoom openXmlElement, String? value)
  {
    openXmlElement.Percent = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.Zoom? CreateModelElement(DXW.Zoom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Zoom();
      value.Val = GetVal(openXmlElement);
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
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpPercent(openXmlElement, value.Percent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Zoom value)
    where OpenXmlElementType: DXW.Zoom, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Zoom openXmlElement, DMW.Zoom value)
  {
    SetVal(openXmlElement, value?.Val);
    SetPercent(openXmlElement, value?.Percent);
  }
}
