namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public static class ChartStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsChartsStyle.ChartStyle? GetChartStyle(DXPack.ChartStylePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2013DrawChartStyle.ChartStyle rootElement)
      return DMXDrawsChartsStyle.ChartStyleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetChartStyle(DXPack.ChartStylePart openXmlElement, DMDrawsChartsStyle.ChartStyle? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsChartsStyle.ChartStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ChartStyle>(value);
       if (rootElement != null)
         openXmlElement.ChartStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.ChartStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.ChartStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.ChartStylePart? CreateModelElement(DXPack.ChartStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ChartStylePart();
      value.ChartStyle = GetChartStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartStylePart? value)
    where OpenXmlElementType: DXPack.ChartStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartStyle(openXmlElement, value?.ChartStyle);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
