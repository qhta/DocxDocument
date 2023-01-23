namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public static class NumberFormatConverter
{
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetFormatCode(DXO2016DrawChartDraw.NumberFormat openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  private static bool CmpFormatCode(DXO2016DrawChartDraw.NumberFormat openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FormatCode?.Value == value;
  }
  
  private static void SetFormatCode(DXO2016DrawChartDraw.NumberFormat openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FormatCode = new StringValue { Value = value };
    else
      openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetSourceLinked(DXO2016DrawChartDraw.NumberFormat openXmlElement)
  {
    return openXmlElement?.SourceLinked?.Value;
  }
  
  private static bool CmpSourceLinked(DXO2016DrawChartDraw.NumberFormat openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SourceLinked?.Value == value;
  }
  
  private static void SetSourceLinked(DXO2016DrawChartDraw.NumberFormat openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SourceLinked = null;
  }
  
  public static DMDrawsChartDraws.NumberFormat? CreateModelElement(DXO2016DrawChartDraw.NumberFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.NumberFormat();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.SourceLinked = GetSourceLinked(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.NumberFormat? openXmlElement, DMDrawsChartDraws.NumberFormat? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NumberFormat? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.NumberFormat, new()
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
