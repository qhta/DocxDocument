namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Document Variable.
/// </summary>
public static class DocumentVariableConverter
{
  /// <summary>
  /// Document Variable Name
  /// </summary>
  private static String? GetName(DXW.DocumentVariable openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.DocumentVariable openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.DocumentVariable openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Document Variable Value
  /// </summary>
  private static String? GetVal(DXW.DocumentVariable openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.DocumentVariable openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.DocumentVariable openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.DocumentVariable? CreateModelElement(DXW.DocumentVariable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocumentVariable();
      value.Name = GetName(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocumentVariable? openXmlElement, DMW.DocumentVariable? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentVariable value)
    where OpenXmlElementType: DXW.DocumentVariable, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocumentVariable openXmlElement, DMW.DocumentVariable value)
  {
    SetName(openXmlElement, value?.Name);
    SetVal(openXmlElement, value?.Val);
  }
}
