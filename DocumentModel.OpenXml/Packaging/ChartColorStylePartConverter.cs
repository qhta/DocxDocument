namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public static class ChartColorStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsChartsStyle.ColorStyle? GetColorStyle(DXPack.ChartColorStylePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2013DrawChartStyle.ColorStyle rootElement)
      return DMXDrawsChartsStyle.ColorStyleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetColorStyle(DXPack.ChartColorStylePart openXmlElement, DMDrawsChartsStyle.ColorStyle? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsChartsStyle.ColorStyleConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ColorStyle>(value);
       if (rootElement != null)
         openXmlElement.ColorStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DXPack.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.ChartColorStylePart? CreateModelElement(DXPack.ChartColorStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ChartColorStylePart();
      value.ColorStyle = GetColorStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartColorStylePart? value)
    where OpenXmlElementType: DXPack.ChartColorStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorStyle(openXmlElement, value?.ColorStyle);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
