namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Freeze Document Layout.
/// </summary>
public static class ReadModeInkLockDownConverter
{
  /// <summary>
  /// Use Actual Pages, Not Virtual Pages
  /// </summary>
  private static Boolean? GetUseActualPages(DXW.ReadModeInkLockDown openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.UseActualPages);
  }
  
  private static bool CmpUseActualPages(DXW.ReadModeInkLockDown openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.UseActualPages, value, diffs, objName, "UseActualPages");
  }
  
  private static void SetUseActualPages(DXW.ReadModeInkLockDown openXmlElement, Boolean? value)
  {
    openXmlElement.UseActualPages = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  private static UInt32? GetWidth(DXW.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.ReadModeInkLockDown openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXW.ReadModeInkLockDown openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Virtual Page Height
  /// </summary>
  private static UInt32? GetHeight(DXW.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXW.ReadModeInkLockDown openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXW.ReadModeInkLockDown openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Font Size Scaling
  /// </summary>
  private static String? GetFontSize(DXW.ReadModeInkLockDown openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FontSize);
  }
  
  private static bool CmpFontSize(DXW.ReadModeInkLockDown openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FontSize, value, diffs, objName, "FontSize");
  }
  
  private static void SetFontSize(DXW.ReadModeInkLockDown openXmlElement, String? value)
  {
    openXmlElement.FontSize = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.ReadModeInkLockDown? CreateModelElement(DXW.ReadModeInkLockDown? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ReadModeInkLockDown();
      value.UseActualPages = GetUseActualPages(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.FontSize = GetFontSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ReadModeInkLockDown? openXmlElement, DMW.ReadModeInkLockDown? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUseActualPages(openXmlElement, value.UseActualPages, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpFontSize(openXmlElement, value.FontSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ReadModeInkLockDown value)
    where OpenXmlElementType: DXW.ReadModeInkLockDown, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ReadModeInkLockDown openXmlElement, DMW.ReadModeInkLockDown value)
  {
    SetUseActualPages(openXmlElement, value?.UseActualPages);
    SetWidth(openXmlElement, value?.Width);
    SetHeight(openXmlElement, value?.Height);
    SetFontSize(openXmlElement, value?.FontSize);
  }
}
