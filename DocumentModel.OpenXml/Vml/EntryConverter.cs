namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Regroup Entry.
/// </summary>
public static class EntryConverter
{
  /// <summary>
  /// New Group ID
  /// </summary>
  private static Int32? GetNew(DXVmlO.Entry openXmlElement)
  {
    return openXmlElement?.New?.Value;
  }
  
  private static bool CmpNew(DXVmlO.Entry openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.New?.Value == value) return true;
    diffs?.Add(objName, "New", openXmlElement?.New?.Value, value);
    return false;
  }
  
  private static void SetNew(DXVmlO.Entry openXmlElement, Int32? value)
  {
    openXmlElement.New = value;
  }
  
  /// <summary>
  /// Old Group ID
  /// </summary>
  private static Int32? GetOld(DXVmlO.Entry openXmlElement)
  {
    return openXmlElement?.Old?.Value;
  }
  
  private static bool CmpOld(DXVmlO.Entry openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Old?.Value == value) return true;
    diffs?.Add(objName, "Old", openXmlElement?.Old?.Value, value);
    return false;
  }
  
  private static void SetOld(DXVmlO.Entry openXmlElement, Int32? value)
  {
    openXmlElement.Old = value;
  }
  
  public static DocumentModel.Vml.Entry? CreateModelElement(DXVmlO.Entry? openXmlElement)
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
  
  public static bool CompareModelElement(DXVmlO.Entry? openXmlElement, DMVml.Entry? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Entry value)
    where OpenXmlElementType: DXVmlO.Entry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVmlO.Entry openXmlElement, DMVml.Entry value)
  {
    SetNew(openXmlElement, value?.New);
    SetOld(openXmlElement, value?.Old);
    }
  }
