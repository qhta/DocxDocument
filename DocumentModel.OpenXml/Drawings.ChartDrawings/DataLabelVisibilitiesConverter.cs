namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelVisibilities Class.
/// </summary>
public static class DataLabelVisibilitiesConverter
{
  /// <summary>
  /// seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetSeriesName(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement)
  {
    return openXmlElement?.SeriesName?.Value;
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
  
  private static void SetValue(DXO2016DrawChartDraw.DataLabelVisibilities openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Value = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Value = null;
  }
  
  public static DMDrawsChartDraws.DataLabelVisibilities? CreateModelElement(DXO2016DrawChartDraw.DataLabelVisibilities? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.DataLabelVisibilities();
      value.SeriesName = GetSeriesName(openXmlElement);
      value.CategoryName = GetCategoryName(openXmlElement);
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.DataLabelVisibilities? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.DataLabelVisibilities, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSeriesName(openXmlElement, value?.SeriesName);
      SetCategoryName(openXmlElement, value?.CategoryName);
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
