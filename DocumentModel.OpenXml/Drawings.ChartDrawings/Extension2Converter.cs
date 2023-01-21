namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Extension2 Class.
/// </summary>
public static class Extension2Converter
{
  /// <summary>
  /// uri, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUri(DXO2016DrawChartDraw.Extension2 openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXO2016DrawChartDraw.Extension2 openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  public static DMDrawsChartDraws.Extension2? CreateModelElement(DXO2016DrawChartDraw.Extension2? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Extension2();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Extension2? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Extension2, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
