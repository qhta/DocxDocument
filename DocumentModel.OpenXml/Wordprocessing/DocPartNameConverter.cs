namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public static class DocPartNameConverter
{
  /// <summary>
  /// Name Value
  /// </summary>
  private static String? GetVal(DXW.DocPartName openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.DocPartName openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXW.DocPartName openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  private static Boolean? GetDecorated(DXW.DocPartName openXmlElement)
  {
    return openXmlElement?.Decorated?.Value;
  }
  
  private static bool CmpDecorated(DXW.DocPartName openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Decorated?.Value == value) return true;
    diffs?.Add(objName, "Decorated", openXmlElement?.Decorated?.Value, value);
    return false;
  }
  
  private static void SetDecorated(DXW.DocPartName openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Decorated = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Decorated = null;
  }
  
  public static DocumentModel.Wordprocessing.DocPartName? CreateModelElement(DXW.DocPartName? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPartName();
      value.Val = GetVal(openXmlElement);
      value.Decorated = GetDecorated(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocPartName? openXmlElement, DMW.DocPartName? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpDecorated(openXmlElement, value.Decorated, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartName? value)
    where OpenXmlElementType: DXW.DocPartName, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetDecorated(openXmlElement, value?.Decorated);
      return openXmlElement;
    }
    return default;
  }
}
