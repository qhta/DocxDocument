namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Regroup Entry.
/// </summary>
public static class EntryConverter
{
  /// <summary>
  /// New Group ID
  /// </summary>
  private static Int32? GetNew(DXVO.Entry openXmlElement)
  {
    return openXmlElement?.New?.Value;
  }
  
  private static bool CmpNew(DXVO.Entry openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.New?.Value == value) return true;
    diffs?.Add(objName, "New", openXmlElement?.New?.Value, value);
    return false;
  }
  
  private static void SetNew(DXVO.Entry openXmlElement, Int32? value)
  {
    openXmlElement.New = value;
  }
  
  /// <summary>
  /// Old Group ID
  /// </summary>
  private static Int32? GetOld(DXVO.Entry openXmlElement)
  {
    return openXmlElement?.Old?.Value;
  }
  
  private static bool CmpOld(DXVO.Entry openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Old?.Value == value) return true;
    diffs?.Add(objName, "Old", openXmlElement?.Old?.Value, value);
    return false;
  }
  
  private static void SetOld(DXVO.Entry openXmlElement, Int32? value)
  {
    openXmlElement.Old = value;
  }
  
  public static DocumentModel.Vml.Entry? CreateModelElement(DXVO.Entry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Entry();
      value.New = GetNew(openXmlElement);
      value.Old = GetOld(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVO.Entry? openXmlElement, DMV.Entry? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNew(openXmlElement, value.New, diffs, objName))
        ok = false;
      if (!CmpOld(openXmlElement, value.Old, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Entry value)
    where OpenXmlElementType: DXVO.Entry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.Entry openXmlElement, DMV.Entry value)
  {
    SetNew(openXmlElement, value?.New);
    SetOld(openXmlElement, value?.Old);
  }
}
