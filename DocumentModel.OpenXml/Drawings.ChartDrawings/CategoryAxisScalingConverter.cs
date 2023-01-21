namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public static class CategoryAxisScalingConverter
{
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetGapWidth(DXO2016DrawChartDraw.CategoryAxisScaling openXmlElement)
  {
    return openXmlElement?.GapWidth?.Value;
  }
  
  private static void SetGapWidth(DXO2016DrawChartDraw.CategoryAxisScaling openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GapWidth = new StringValue { Value = value };
    else
      openXmlElement.GapWidth = null;
  }
  
  public static DMDrawsChartDraws.CategoryAxisScaling? CreateModelElement(DXO2016DrawChartDraw.CategoryAxisScaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.CategoryAxisScaling();
      value.GapWidth = GetGapWidth(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.CategoryAxisScaling? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.CategoryAxisScaling, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGapWidth(openXmlElement, value?.GapWidth);
      return openXmlElement;
    }
    return default;
  }
}
