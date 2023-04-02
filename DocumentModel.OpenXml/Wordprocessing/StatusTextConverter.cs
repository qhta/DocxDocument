namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Associated Status Text.
/// </summary>
public static class StatusTextConverter
{
  /// <summary>
  /// Status Text Type
  /// </summary>
  private static DMW.InfoTextKind? GetType(DXW.StatusText openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.StatusText openXmlElement, DMW.InfoTextKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.StatusText openXmlElement, DMW.InfoTextKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.InfoTextValues, DMW.InfoTextKind>(value);
  }
  
  /// <summary>
  /// Status Text Value
  /// </summary>
  private static String? GetVal(DXW.StatusText openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.StatusText openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXW.StatusText openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.StatusText? CreateModelElement(DXW.StatusText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StatusText();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StatusText? openXmlElement, DMW.StatusText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StatusText value)
    where OpenXmlElementType: DXW.StatusText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StatusText openXmlElement, DMW.StatusText value)
  {
    SetType(openXmlElement, value?.Type);
    SetVal(openXmlElement, value?.Val);
  }
}
