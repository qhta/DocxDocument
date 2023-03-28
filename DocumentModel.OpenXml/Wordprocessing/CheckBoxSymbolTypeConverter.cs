namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class converter from/to OpenXml.
///</summary>
public static class CheckBoxSymbolTypeConverter
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetFont(DXO2010W.CheckBoxSymbolType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Font);
  }
  
  private static bool CmpFont(DXO2010W.CheckBoxSymbolType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Font, value, diffs, objName, "Font");
  }
  
  private static void SetFont(DXO2010W.CheckBoxSymbolType openXmlElement, String? value)
  {
    openXmlElement.Font = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexChar? GetVal(DXO2010W.CheckBoxSymbolType openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Val.Value);
    return null;
  }
  
  private static bool CmpVal(DXO2010W.CheckBoxSymbolType openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Val.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Val?.Value == null && value is null) return true;
    diffs?.Add(objName, "Normal", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXO2010W.CheckBoxSymbolType openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Val = value.ToString();
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.CheckBoxSymbolType? CreateModelElement(DXO2010W.CheckBoxSymbolType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CheckBoxSymbolType();
      value.Font = GetFont(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.CheckBoxSymbolType? openXmlElement, DMW.CheckBoxSymbolType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFont(openXmlElement, value.Font, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CheckBoxSymbolType value)
    where OpenXmlElementType: DXO2010W.CheckBoxSymbolType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.CheckBoxSymbolType openXmlElement, DMW.CheckBoxSymbolType value)
  {
    SetFont(openXmlElement, value?.Font);
    SetVal(openXmlElement, value?.Val);
  }
}
