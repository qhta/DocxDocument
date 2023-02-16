namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public static class CheckBoxSymbolTypeConverter
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetFont(DXO2010W.CheckBoxSymbolType openXmlElement)
  {
    return openXmlElement?.Font?.Value;
  }
  
  private static bool CmpFont(DXO2010W.CheckBoxSymbolType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Font?.Value == value) return true;
    diffs?.Add(objName, "Font", openXmlElement?.Font?.Value, value);
    return false;
  }
  
  private static void SetFont(DXO2010W.CheckBoxSymbolType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Font = new StringValue { Value = value };
    else
      openXmlElement.Font = null;
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetVal(DXO2010W.CheckBoxSymbolType openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.Val.Value);
    return null;
  }
  
  private static bool CmpVal(DXO2010W.CheckBoxSymbolType openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value != null)
      if (HexIntConverter.GetValue(openXmlElement.Val.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXO2010W.CheckBoxSymbolType openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.Val = value.ToString();
    else
      openXmlElement.Val = null;
  }
  
  public static DocumentModel.Wordprocessing.CheckBoxSymbolType? CreateModelElement(DXO2010W.CheckBoxSymbolType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CheckBoxSymbolType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CheckBoxSymbolType? value)
    where OpenXmlElementType: DXO2010W.CheckBoxSymbolType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFont(openXmlElement, value?.Font);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
