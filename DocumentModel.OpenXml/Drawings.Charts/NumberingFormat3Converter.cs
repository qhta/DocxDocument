namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public static class NumberingFormat3Converter
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  private static String? GetFormatCode(DXO2013DrawChart.NumberingFormat openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  private static bool CmpFormatCode(DXO2013DrawChart.NumberingFormat openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FormatCode?.Value == value;
  }
  
  private static void SetFormatCode(DXO2013DrawChart.NumberingFormat openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FormatCode = new StringValue { Value = value };
    else
      openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  private static Boolean? GetSourceLinked(DXO2013DrawChart.NumberingFormat openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }
  
  private static bool CmpSourceLinked(DXO2013DrawChart.NumberingFormat openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SourceLinked?.Value == value;
  }
  
  private static void SetSourceLinked(DXO2013DrawChart.NumberingFormat openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SourceLinked = null;
  }
  
  public static DMDrawsCharts.NumberingFormat3? CreateModelElement(DXO2013DrawChart.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.NumberingFormat3();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.NumberingFormat? openXmlElement, DMDrawsCharts.NumberingFormat3? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.NumberingFormat3? value)
    where OpenXmlElementType: DXO2013DrawChart.NumberingFormat, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetSourceLinked(openXmlElement, value?.SourceLinked);
      return openXmlElement;
    }
    return default;
  }
}
