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
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.DocPartName openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXW.DocPartName openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  private static Boolean? GetDecorated(DXW.DocPartName openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Decorated);
  }
  
  private static bool CmpDecorated(DXW.DocPartName openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Decorated, value, diffs, objName, "Decorated");
  }
  
  private static void SetDecorated(DXW.DocPartName openXmlElement, Boolean? value)
  {
    openXmlElement.Decorated = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.DocPartName? CreateModelElement(DXW.DocPartName? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocPartName();
      value.Val = GetVal(openXmlElement);
      value.Decorated = GetDecorated(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocPartName? openXmlElement, DMW.DocPartName? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      if (!CmpDecorated(openXmlElement, value.Decorated, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartName value)
    where OpenXmlElementType: DXW.DocPartName, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocPartName openXmlElement, DMW.DocPartName value)
  {
    SetVal(openXmlElement, value?.Val);
    SetDecorated(openXmlElement, value?.Decorated);
  }
}
