namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueAxisScaling Class converter from/to OpenXml.
///</summary>
public static class ValueAxisScalingConverter
{
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMax(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Max);
  }
  
  private static bool CmpMax(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Max, value, diffs, objName, "Max");
  }
  
  private static void SetMax(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.Max = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMin(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Min);
  }
  
  private static bool CmpMin(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Min, value, diffs, objName, "Min");
  }
  
  private static void SetMin(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.Min = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMajorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MajorUnit);
  }
  
  private static bool CmpMajorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MajorUnit, value, diffs, objName, "MajorUnit");
  }
  
  private static void SetMajorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.MajorUnit = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMinorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinorUnit);
  }
  
  private static bool CmpMinorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinorUnit, value, diffs, objName, "MinorUnit");
  }
  
  private static void SetMinorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.MinorUnit = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueAxisScaling? CreateModelElement(DXO2016DrawChartDraw.ValueAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueAxisScaling();
      value.Max = GetMax(openXmlElement);
      value.Min = GetMin(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ValueAxisScaling? openXmlElement, DMDrawsChartDraws.ValueAxisScaling? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMax(openXmlElement, value.Max, diffs, objName))
        ok = false;
      if (!CmpMin(openXmlElement, value.Min, diffs, objName))
        ok = false;
      if (!CmpMajorUnit(openXmlElement, value.MajorUnit, diffs, objName))
        ok = false;
      if (!CmpMinorUnit(openXmlElement, value.MinorUnit, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueAxisScaling value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueAxisScaling, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, DMDrawsChartDraws.ValueAxisScaling value)
  {
    SetMax(openXmlElement, value?.Max);
    SetMin(openXmlElement, value?.Min);
    SetMajorUnit(openXmlElement, value?.MajorUnit);
    SetMinorUnit(openXmlElement, value?.MinorUnit);
  }
}
