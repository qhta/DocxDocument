namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public static class StatisticsConverter
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.QuartileMethod? GetQuartileMethod(DXO2016DrawChartDraw.Statistics openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDrawsChartDraws.QuartileMethod>(openXmlElement?.QuartileMethod?.Value);
  }
  
  private static void SetQuartileMethod(DXO2016DrawChartDraw.Statistics openXmlElement, DMDrawsChartDraws.QuartileMethod? value)
  {
    openXmlElement.QuartileMethod = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.QuartileMethod, DMDrawsChartDraws.QuartileMethod>(value);
  }
  
  public static DMDrawsChartDraws.Statistics? CreateModelElement(DXO2016DrawChartDraw.Statistics? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Statistics();
      value.QuartileMethod = GetQuartileMethod(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Statistics? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Statistics, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetQuartileMethod(openXmlElement, value?.QuartileMethod);
      return openXmlElement;
    }
    return default;
  }
}
