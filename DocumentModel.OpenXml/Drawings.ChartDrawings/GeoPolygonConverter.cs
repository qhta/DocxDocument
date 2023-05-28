namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public static class GeoPolygonConverter
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPolygonId(DXO16DCD.GeoPolygon openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PolygonId);
  }
  
  private static bool CmpPolygonId(DXO16DCD.GeoPolygon openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PolygonId, value, diffs, objName, "PolygonId");
  }
  
  private static void SetPolygonId(DXO16DCD.GeoPolygon openXmlElement, String? value)
  {
    openXmlElement.PolygonId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int64? GetNumPoints(DXO16DCD.GeoPolygon openXmlElement)
  {
    return openXmlElement?.NumPoints?.Value;
  }
  
  private static bool CmpNumPoints(DXO16DCD.GeoPolygon openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NumPoints?.Value == value) return true;
    diffs?.Add(objName, "NumPoints", openXmlElement?.NumPoints?.Value, value);
    return false;
  }
  
  private static void SetNumPoints(DXO16DCD.GeoPolygon openXmlElement, Int64? value)
  {
    openXmlElement.NumPoints = value;
  }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPcaRings(DXO16DCD.GeoPolygon openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.PcaRings);
  }
  
  private static bool CmpPcaRings(DXO16DCD.GeoPolygon openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.PcaRings, value, diffs, objName, "PcaRings");
  }
  
  private static void SetPcaRings(DXO16DCD.GeoPolygon openXmlElement, String? value)
  {
    openXmlElement.PcaRings = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDCDs.GeoPolygon? CreateModelElement(DXO16DCD.GeoPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoPolygon();
      value.PolygonId = GetPolygonId(openXmlElement);
      value.NumPoints = GetNumPoints(openXmlElement);
      value.PcaRings = GetPcaRings(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoPolygon? openXmlElement, DMDCDs.GeoPolygon? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPolygonId(openXmlElement, value.PolygonId, diffs, objName, propName))
        ok = false;
      if (!CmpNumPoints(openXmlElement, value.NumPoints, diffs, objName, propName))
        ok = false;
      if (!CmpPcaRings(openXmlElement, value.PcaRings, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoPolygon value)
    where OpenXmlElementType: DXO16DCD.GeoPolygon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoPolygon openXmlElement, DMDCDs.GeoPolygon value)
  {
    SetPolygonId(openXmlElement, value?.PolygonId);
    SetNumPoints(openXmlElement, value?.NumPoints);
    SetPcaRings(openXmlElement, value?.PcaRings);
  }
}
