namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PaperSource Class.
/// </summary>
public static class PaperSourceConverter
{
  /// <summary>
  /// First Page Printer Tray Code
  /// </summary>
  private static UInt16? GetFirst(DXW.PaperSource openXmlElement)
  {
    return openXmlElement?.First?.Value;
  }
  
  private static bool CmpFirst(DXW.PaperSource openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.First?.Value == value) return true;
    diffs?.Add(objName, "First", openXmlElement?.First?.Value, value);
    return false;
  }
  
  private static void SetFirst(DXW.PaperSource openXmlElement, UInt16? value)
  {
    openXmlElement.First = value;
  }
  
  /// <summary>
  /// Non-First Page Printer Tray Code
  /// </summary>
  private static UInt16? GetOther(DXW.PaperSource openXmlElement)
  {
    return openXmlElement?.Other?.Value;
  }
  
  private static bool CmpOther(DXW.PaperSource openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Other?.Value == value) return true;
    diffs?.Add(objName, "Other", openXmlElement?.Other?.Value, value);
    return false;
  }
  
  private static void SetOther(DXW.PaperSource openXmlElement, UInt16? value)
  {
    openXmlElement.Other = value;
  }
  
  public static DocumentModel.Wordprocessing.PaperSource? CreateModelElement(DXW.PaperSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PaperSource();
      value.First = GetFirst(openXmlElement);
      value.Other = GetOther(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PaperSource? openXmlElement, DMW.PaperSource? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFirst(openXmlElement, value.First, diffs, objName))
        ok = false;
      if (!CmpOther(openXmlElement, value.Other, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PaperSource? value)
    where OpenXmlElementType: DXW.PaperSource, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFirst(openXmlElement, value?.First);
      SetOther(openXmlElement, value?.Other);
      return openXmlElement;
    }
    return default;
  }
}
