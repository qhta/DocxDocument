namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelVisibilities Class.
/// </summary>
public static class DataLabelVisibilitiesConverter
{
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetSeriesName(DXO16DCD.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.SeriesName?.Value;
  }
  
  private static bool CmpSeriesName(DXO16DCD.DataLabelVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SeriesName?.Value == value) return true;
    diffs?.Add(objName, "SeriesName", openXmlElement?.SeriesName?.Value, value);
    return false;
  }
  
  private static void SetSeriesName(DXO16DCD.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SeriesName = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SeriesName = null;
  }
  
  /// <summary>
  /// categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetCategoryName(DXO16DCD.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.CategoryName?.Value;
  }
  
  private static bool CmpCategoryName(DXO16DCD.DataLabelVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.CategoryName?.Value == value) return true;
    diffs?.Add(objName, "CategoryName", openXmlElement?.CategoryName?.Value, value);
    return false;
  }
  
  private static void SetCategoryName(DXO16DCD.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CategoryName = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CategoryName = null;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetValue(DXO16DCD.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static bool CmpValue(DXO16DCD.DataLabelVisibilities openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Value?.Value == value) return true;
    diffs?.Add(objName, "Type", openXmlElement?.Value?.Value, value);
    return false;
  }
  
  private static void SetValue(DXO16DCD.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Value = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Value = null;
  }
  
  public static DMDCDs.DataLabelVisibilities? CreateModelElement(DXO16DCD.DataLabelVisibilities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.DataLabelVisibilities();
      value.SeriesName = GetSeriesName(openXmlElement);
      value.CategoryName = GetCategoryName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.DataLabelVisibilities? openXmlElement, DMDCDs.DataLabelVisibilities? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSeriesName(openXmlElement, value.SeriesName, diffs, objName, propName))
        ok = false;
      if (!CmpCategoryName(openXmlElement, value.CategoryName, diffs, objName, propName))
        ok = false;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.DataLabelVisibilities value)
    where OpenXmlElementType: DXO16DCD.DataLabelVisibilities, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.DataLabelVisibilities openXmlElement, DMDCDs.DataLabelVisibilities value)
  {
    SetSeriesName(openXmlElement, value?.SeriesName);
    SetCategoryName(openXmlElement, value?.CategoryName);
    SetValue(openXmlElement, value?.Value);
  }
}
