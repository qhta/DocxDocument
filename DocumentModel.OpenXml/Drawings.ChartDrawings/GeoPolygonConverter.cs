namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public static class GeoPolygonConverter
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPolygonId(DXO2016DrawChartDraw.GeoPolygon openXmlElement)
  {
    return openXmlElement?.PolygonId?.Value;
  }
  
  private static void SetPolygonId(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.PolygonId = new StringValue { Value = value };
    else
      openXmlElement.PolygonId = null;
  }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int64? GetNumPoints(DXO2016DrawChartDraw.GeoPolygon openXmlElement)
  {
    return openXmlElement.NumPoints?.Value;
  }
  
  private static void SetNumPoints(DXO2016DrawChartDraw.GeoPolygon openXmlElement, Int64? value)
  {
    openXmlElement.NumPoints = value;
  }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPcaRings(DXO2016DrawChartDraw.GeoPolygon openXmlElement)
  {
    return openXmlElement?.PcaRings?.Value;
  }
  
  private static void SetPcaRings(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.PcaRings = new StringValue { Value = value };
    else
      openXmlElement.PcaRings = null;
  }
  
  public static DMDrawsChartDraws.GeoPolygon? CreateModelElement(DXO2016DrawChartDraw.GeoPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoPolygon();
      value.PolygonId = GetPolygonId(openXmlElement);
      value.NumPoints = GetNumPoints(openXmlElement);
      value.PcaRings = GetPcaRings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoPolygon? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoPolygon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPolygonId(openXmlElement, value?.PolygonId);
      SetNumPoints(openXmlElement, value?.NumPoints);
      SetPcaRings(openXmlElement, value?.PcaRings);
      return openXmlElement;
    }
    return default;
  }
}
