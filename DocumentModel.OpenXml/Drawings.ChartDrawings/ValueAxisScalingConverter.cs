namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueAxisScaling Class.
/// </summary>
public static class ValueAxisScalingConverter
{
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMax(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.Max?.Value;
  }
  
  private static bool CmpMax(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Max?.Value == value;
  }
  
  private static void SetMax(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Max = new StringValue { Value = value };
    else
      openXmlElement.Max = null;
  }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMin(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.Min?.Value;
  }
  
  private static bool CmpMin(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Min?.Value == value;
  }
  
  private static void SetMin(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Min = new StringValue { Value = value };
    else
      openXmlElement.Min = null;
  }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMajorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.MajorUnit?.Value;
  }
  
  private static bool CmpMajorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MajorUnit?.Value == value;
  }
  
  private static void SetMajorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MajorUnit = new StringValue { Value = value };
    else
      openXmlElement.MajorUnit = null;
  }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMinorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement)
  {
    return openXmlElement?.MinorUnit?.Value;
  }
  
  private static bool CmpMinorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MinorUnit?.Value == value;
  }
  
  private static void SetMinorUnit(DXO2016DrawChartDraw.ValueAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinorUnit = new StringValue { Value = value };
    else
      openXmlElement.MinorUnit = null;
  }
  
  public static DMDrawsChartDraws.ValueAxisScaling? CreateModelElement(DXO2016DrawChartDraw.ValueAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ValueAxisScaling();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ValueAxisScaling? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ValueAxisScaling, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMax(openXmlElement, value?.Max);
      SetMin(openXmlElement, value?.Min);
      SetMajorUnit(openXmlElement, value?.MajorUnit);
      SetMinorUnit(openXmlElement, value?.MinorUnit);
      return openXmlElement;
    }
    return default;
  }
}
