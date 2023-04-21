namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public static class NumberingFormat3Converter
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  private static String? GetFormatCode(DXO13DC.NumberingFormat openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FormatCode);
  }
  
  private static bool CmpFormatCode(DXO13DC.NumberingFormat openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FormatCode, value, diffs, objName, "FormatCode");
  }
  
  private static void SetFormatCode(DXO13DC.NumberingFormat openXmlElement, String? value)
  {
    openXmlElement.FormatCode = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  private static Boolean? GetSourceLinked(DXO13DC.NumberingFormat openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }
  
  private static bool CmpSourceLinked(DXO13DC.NumberingFormat openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SourceLinked?.Value == value) return true;
    diffs?.Add(objName, "SourceLinked", openXmlElement?.SourceLinked?.Value, value);
    return false;
  }
  
  private static void SetSourceLinked(DXO13DC.NumberingFormat openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SourceLinked = null;
  }
  
  public static DocumentModel.Drawings.Charts.NumberingFormat3? CreateModelElement(DXO13DC.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberingFormat3();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.NumberingFormat? openXmlElement, DMDC.NumberingFormat3? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.NumberingFormat3 value)
    where OpenXmlElementType: DXO13DC.NumberingFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.NumberingFormat openXmlElement, DMDC.NumberingFormat3 value)
  {
    SetFormatCode(openXmlElement, value?.FormatCode);
    SetSourceLinked(openXmlElement, value?.SourceLinked);
  }
}
