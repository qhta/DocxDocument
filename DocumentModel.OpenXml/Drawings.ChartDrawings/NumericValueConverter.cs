namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public static class NumericValueConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO2016DrawChartDraw.NumericValue openXmlElement)
  {
    return openXmlElement.Idx?.Value;
  }
  
  private static void SetIdx(DXO2016DrawChartDraw.NumericValue openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  public static DMDrawsChartDraws.NumericValue? CreateModelElement(DXO2016DrawChartDraw.NumericValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.NumericValue();
      value.Idx = GetIdx(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NumericValue? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.NumericValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdx(openXmlElement, value?.Idx);
      return openXmlElement;
    }
    return default;
  }
}
