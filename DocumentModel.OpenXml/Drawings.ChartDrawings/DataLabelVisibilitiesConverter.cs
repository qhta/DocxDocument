namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelVisibilities Class converter from/to OpenXml.
///</summary>
public static class DataLabelVisibilitiesConverter
{
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetSeriesName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.SeriesName?.Value;
  }
  
  private static bool CmpSeriesName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SeriesName?.Value == value) return true;
    diffs?.Add(objName, "SeriesName", openXmlElement?.SeriesName?.Value, value);
    return false;
  }
  
  private static void SetSeriesName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SeriesName = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.SeriesName = null;
  }
  
  /// <summary>
  /// categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetCategoryName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.CategoryName?.Value;
  }
  
  private static bool CmpCategoryName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CategoryName?.Value == value) return true;
    diffs?.Add(objName, "CategoryName", openXmlElement?.CategoryName?.Value, value);
    return false;
  }
  
  private static void SetCategoryName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CategoryName = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CategoryName = null;
  }
  
  /// <summary>
  /// value, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetValue(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static bool CmpValue(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Value?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Value?.Value, value);
    return false;
  }
  
  private static void SetValue(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Value = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Value = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? CreateModelElement(DXO2016DrawChartDraw.DataLabelVisibilities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities();
      value.SeriesName = GetSeriesName(openXmlElement);
      value.CategoryName = GetCategoryName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.DataLabelVisibilities? openXmlElement, DMDrawsChartDraws.DataLabelVisibilities? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSeriesName(openXmlElement, value.SeriesName, diffs, objName))
        ok = false;
      if (!CmpCategoryName(openXmlElement, value.CategoryName, diffs, objName))
        ok = false;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.DataLabelVisibilities value)
    where OpenXmlElementType: DXO2016DrawChartDraw.DataLabelVisibilities, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, DMDrawsChartDraws.DataLabelVisibilities value)
  {
    SetSeriesName(openXmlElement, value?.SeriesName);
    SetCategoryName(openXmlElement, value?.CategoryName);
    SetValue(openXmlElement, value?.Value);
  }
}
