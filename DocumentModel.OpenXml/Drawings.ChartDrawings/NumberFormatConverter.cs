namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public static class NumberFormatConverter
{
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetFormatCode(DXO16DCD.NumberFormat openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FormatCode);
  }
  
  private static bool CmpFormatCode(DXO16DCD.NumberFormat openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FormatCode, value, diffs, objName, "FormatCode");
  }
  
  private static void SetFormatCode(DXO16DCD.NumberFormat openXmlElement, String? value)
  {
    openXmlElement.FormatCode = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetSourceLinked(DXO16DCD.NumberFormat openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }
  
  private static bool CmpSourceLinked(DXO16DCD.NumberFormat openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SourceLinked?.Value == value) return true;
    diffs?.Add(objName, "SourceLinked", openXmlElement?.SourceLinked?.Value, value);
    return false;
  }
  
  private static void SetSourceLinked(DXO16DCD.NumberFormat openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SourceLinked = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumberFormat? CreateModelElement(DXO16DCD.NumberFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumberFormat();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.NumberFormat? openXmlElement, DMDCDs.NumberFormat? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormatCode(openXmlElement, value.FormatCode, diffs, objName))
        ok = false;
      if (!CmpSourceLinked(openXmlElement, value.SourceLinked, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.NumberFormat value)
    where OpenXmlElementType: DXO16DCD.NumberFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.NumberFormat openXmlElement, DMDCDs.NumberFormat value)
  {
    SetFormatCode(openXmlElement, value?.FormatCode);
    SetSourceLinked(openXmlElement, value?.SourceLinked);
  }
}
