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
  
  private static bool CmpPolygonId(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.PolygonId?.Value == value;
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
    return openXmlElement?.NumPoints?.Value;
  }
  
  private static bool CmpNumPoints(DXO2016DrawChartDraw.GeoPolygon openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NumPoints?.Value == value) return true;
    diffs?.Add(objName, "NumPoints", openXmlElement?.NumPoints?.Value, value);
    return false;
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
  
  private static bool CmpPcaRings(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.PcaRings?.Value == value;
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoPolygon? openXmlElement, DMDrawsChartDraws.GeoPolygon? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPolygonId(openXmlElement, value.PolygonId, diffs, objName))
        ok = false;
      if (!CmpNumPoints(openXmlElement, value.NumPoints, diffs, objName))
        ok = false;
      if (!CmpPcaRings(openXmlElement, value.PcaRings, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
