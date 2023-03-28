namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoPolygon Class converter from/to OpenXml.
///</summary>
public static class GeoPolygonConverter
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPolygonId(DXO2016DrawChartDraw.GeoPolygon openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PolygonId);
  }
  
  private static bool CmpPolygonId(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PolygonId, value, diffs, objName, "PolygonId");
  }
  
  private static void SetPolygonId(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value)
  {
    openXmlElement.PolygonId = StringValueConverter.CreateStringValue(value);
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
    return StringValueConverter.GetValue(openXmlElement?.PcaRings);
  }
  
  private static bool CmpPcaRings(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PcaRings, value, diffs, objName, "PcaRings");
  }
  
  private static void SetPcaRings(DXO2016DrawChartDraw.GeoPolygon openXmlElement, String? value)
  {
    openXmlElement.PcaRings = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoPolygon? CreateModelElement(DXO2016DrawChartDraw.GeoPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoPolygon();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoPolygon value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoPolygon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoPolygon openXmlElement, DMDrawsChartDraws.GeoPolygon value)
  {
    SetPolygonId(openXmlElement, value?.PolygonId);
    SetNumPoints(openXmlElement, value?.NumPoints);
    SetPcaRings(openXmlElement, value?.PcaRings);
  }
}
