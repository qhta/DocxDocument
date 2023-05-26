namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CheckBoxSymbolType Class.
/// </summary>
public static class CheckBoxSymbolTypeConverter
{
  /// <summary>
  /// font, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetFont(DXO10W.CheckBoxSymbolType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Font);
  }
  
  private static bool CmpFont(DXO10W.CheckBoxSymbolType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Font, value, diffs, objName, "Font");
  }
  
  private static void SetFont(DXO10W.CheckBoxSymbolType openXmlElement, String? value)
  {
    openXmlElement.Font = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexChar? GetVal(DXO10W.CheckBoxSymbolType openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Val.Value);
    return null;
  }
  
  private static bool CmpVal(DXO10W.CheckBoxSymbolType openXmlElement, DM.HexChar? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Val.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Val?.Value == null && value is null) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXO10W.CheckBoxSymbolType openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Val = value.ToString();
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.CheckBoxSymbolType? CreateModelElement(DXO10W.CheckBoxSymbolType? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10W.CheckBoxSymbolType? openXmlElement, DMW.CheckBoxSymbolType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFont(openXmlElement, value.Font, diffs, objName, propName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CheckBoxSymbolType value)
    where OpenXmlElementType: DXO10W.CheckBoxSymbolType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.CheckBoxSymbolType openXmlElement, DMW.CheckBoxSymbolType value)
  {
    SetFont(openXmlElement, value?.Font);
    SetVal(openXmlElement, value?.Val);
  }
}
