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
    return openXmlElement?.UseActualPages?.Value;
  }
  
  private static bool CmpUseActualPages(DXW.ReadModeInkLockDown openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UseActualPages?.Value == value;
  }
  
  private static void SetUseActualPages(DXW.ReadModeInkLockDown openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UseActualPages = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.UseActualPages = null;
  }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  private static UInt32? GetWidth(DXW.ReadModeInkLockDown openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static bool CmpWidth(DXW.ReadModeInkLockDown openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Width?.Value == value;
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
    return openXmlElement.Height?.Value;
  }
  
  private static bool CmpHeight(DXW.ReadModeInkLockDown openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Height?.Value == value;
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
    return openXmlElement?.FontSize?.Value;
  }
  
  private static bool CmpFontSize(DXW.ReadModeInkLockDown openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FontSize?.Value == value;
  }
  
  private static void SetFontSize(DXW.ReadModeInkLockDown openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FontSize = new StringValue { Value = value };
    else
      openXmlElement.FontSize = null;
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ReadModeInkLockDown? value)
    where OpenXmlElementType: DXW.ReadModeInkLockDown, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUseActualPages(openXmlElement, value?.UseActualPages);
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetFontSize(openXmlElement, value?.FontSize);
      return openXmlElement;
    }
    return default;
  }
}
