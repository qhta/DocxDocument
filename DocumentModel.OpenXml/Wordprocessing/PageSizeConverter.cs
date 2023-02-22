namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public static class PageSizeConverter
{
  /// <summary>
  /// Page Width
  /// </summary>
  private static UInt32? GetWidth(DXW.PageSize openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.PageSize openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXW.PageSize openXmlElement, UInt32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Page Height
  /// </summary>
  private static UInt32? GetHeight(DXW.PageSize openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXW.PageSize openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXW.PageSize openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  private static DMW.PageOrientationKind? GetOrient(DXW.PageSize openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DMW.PageOrientationKind>(openXmlElement?.Orient?.Value);
  }
  
  private static bool CmpOrient(DXW.PageSize openXmlElement, DMW.PageOrientationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DMW.PageOrientationKind>(openXmlElement?.Orient?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOrient(DXW.PageSize openXmlElement, DMW.PageOrientationKind? value)
  {
    openXmlElement.Orient = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.PageOrientationValues, DMW.PageOrientationKind>(value);
  }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  private static UInt16? GetCode(DXW.PageSize openXmlElement)
  {
    return openXmlElement?.Code?.Value;
  }
  
  private static bool CmpCode(DXW.PageSize openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Code?.Value == value) return true;
    diffs?.Add(objName, "Code", openXmlElement?.Code?.Value, value);
    return false;
  }
  
  private static void SetCode(DXW.PageSize openXmlElement, UInt16? value)
  {
    openXmlElement.Code = value;
  }
  
  public static DocumentModel.Wordprocessing.PageSize? CreateModelElement(DXW.PageSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PageSize();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Orient = GetOrient(openXmlElement);
      value.Code = GetCode(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PageSize? openXmlElement, DMW.PageSize? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpOrient(openXmlElement, value.Orient, diffs, objName))
        ok = false;
      if (!CmpCode(openXmlElement, value.Code, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PageSize value)
    where OpenXmlElementType: DXW.PageSize, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PageSize openXmlElement, DMW.PageSize value)
  {
    SetWidth(openXmlElement, value?.Width);
    SetHeight(openXmlElement, value?.Height);
    SetOrient(openXmlElement, value?.Orient);
    SetCode(openXmlElement, value?.Code);
  }
}
