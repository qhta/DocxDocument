namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public static class MarkerLayoutPropertiesConverter
{
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  private static DMDCS.MarkerStyle? GetSymbol(DXO13DCS.MarkerLayoutProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, DMDCS.MarkerStyle>(openXmlElement?.Symbol?.Value);
  }
  
  private static bool CmpSymbol(DXO13DCS.MarkerLayoutProperties openXmlElement, DMDCS.MarkerStyle? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, DMDCS.MarkerStyle>(openXmlElement?.Symbol?.Value, value, diffs, objName);
  }
  
  private static void SetSymbol(DXO13DCS.MarkerLayoutProperties openXmlElement, DMDCS.MarkerStyle? value)
  {
    openXmlElement.Symbol = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, DMDCS.MarkerStyle>(value);
  }
  
  /// <summary>
  /// size, this property is only available in Office 2013 and later.
  /// </summary>
  private static Byte? GetSize(DXO13DCS.MarkerLayoutProperties openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }
  
  private static bool CmpSize(DXO13DCS.MarkerLayoutProperties openXmlElement, Byte? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Size?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXO13DCS.MarkerLayoutProperties openXmlElement, Byte? value)
  {
    openXmlElement.Size = value;
  }
  
  public static DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? CreateModelElement(DXO13DCS.MarkerLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DCS.MarkerLayoutProperties? openXmlElement, DMDCS.MarkerLayoutProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSymbol(openXmlElement, value.Symbol, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.MarkerLayoutProperties value)
    where OpenXmlElementType: DXO13DCS.MarkerLayoutProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.MarkerLayoutProperties openXmlElement, DMDCS.MarkerLayoutProperties value)
  {
    SetSymbol(openXmlElement, value?.Symbol);
    SetSize(openXmlElement, value?.Size);
  }
}
