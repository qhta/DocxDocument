namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public static class ChartStringValueConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIndex(DXO2016DrawChartDraw.ChartStringValue openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static void SetIndex(DXO2016DrawChartDraw.ChartStringValue openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  public static DMDrawsChartDraws.ChartStringValue? CreateModelElement(DXO2016DrawChartDraw.ChartStringValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ChartStringValue();
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ChartStringValue? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ChartStringValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}
