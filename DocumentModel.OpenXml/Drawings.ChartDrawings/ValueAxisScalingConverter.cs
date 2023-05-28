namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueAxisScaling Class.
/// </summary>
public static class ValueAxisScalingConverter
{
  /// <summary>
  /// max, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMax(DXO16DCD.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Max);
  }
  
  private static bool CmpMax(DXO16DCD.ValueAxisScaling openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Max, value, diffs, objName, "Max");
  }
  
  private static void SetMax(DXO16DCD.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.Max = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// min, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMin(DXO16DCD.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Min);
  }
  
  private static bool CmpMin(DXO16DCD.ValueAxisScaling openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Min, value, diffs, objName, "Min");
  }
  
  private static void SetMin(DXO16DCD.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.Min = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMajorUnit(DXO16DCD.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MajorUnit);
  }
  
  private static bool CmpMajorUnit(DXO16DCD.ValueAxisScaling openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MajorUnit, value, diffs, objName, "MajorUnit");
  }
  
  private static void SetMajorUnit(DXO16DCD.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.MajorUnit = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetMinorUnit(DXO16DCD.ValueAxisScaling openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinorUnit);
  }
  
  private static bool CmpMinorUnit(DXO16DCD.ValueAxisScaling openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinorUnit, value, diffs, objName, "MinorUnit");
  }
  
  private static void SetMinorUnit(DXO16DCD.ValueAxisScaling openXmlElement, String? value)
  {
    openXmlElement.MinorUnit = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDCDs.ValueAxisScaling? CreateModelElement(DXO16DCD.ValueAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.ValueAxisScaling();
      value.Max = GetMax(openXmlElement);
      value.Min = GetMin(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ValueAxisScaling? openXmlElement, DMDCDs.ValueAxisScaling? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMax(openXmlElement, value.Max, diffs, objName, propName))
        ok = false;
      if (!CmpMin(openXmlElement, value.Min, diffs, objName, propName))
        ok = false;
      if (!CmpMajorUnit(openXmlElement, value.MajorUnit, diffs, objName, propName))
        ok = false;
      if (!CmpMinorUnit(openXmlElement, value.MinorUnit, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ValueAxisScaling value)
    where OpenXmlElementType: DXO16DCD.ValueAxisScaling, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ValueAxisScaling openXmlElement, DMDCDs.ValueAxisScaling value)
  {
    SetMax(openXmlElement, value?.Max);
    SetMin(openXmlElement, value?.Min);
    SetMajorUnit(openXmlElement, value?.MajorUnit);
    SetMinorUnit(openXmlElement, value?.MinorUnit);
  }
}
