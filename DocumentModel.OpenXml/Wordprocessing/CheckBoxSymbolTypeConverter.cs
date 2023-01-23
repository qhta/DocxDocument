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
    return openXmlElement?.Font?.Value == value;
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
  private static Byte[]? GetVal(DXO2010W.CheckBoxSymbolType openXmlElement)
  {
    if (openXmlElement.Val?.Value != null)
      return Convert.FromHexString(openXmlElement.Val.Value);
    return null;
  }
  
  private static bool CmpVal(DXO2010W.CheckBoxSymbolType openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Val?.Value != null)
      return Convert.FromHexString(openXmlElement.Val.Value) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetVal(DXO2010W.CheckBoxSymbolType openXmlElement, Byte[]? value)
  {
    if (value != null)
      openXmlElement.Val = Convert.ToHexString(value);
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
    return openXmlElement == null && value == null;
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
