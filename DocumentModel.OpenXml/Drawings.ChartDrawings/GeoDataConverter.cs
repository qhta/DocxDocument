namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public static class GeoDataConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }
  
  private static bool CmpEntityName(DXO2016DrawChartDraw.GeoData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EntityName?.Value == value) return true;
    diffs?.Add(objName, "EntityName", openXmlElement?.EntityName?.Value, value);
    return false;
  }
  
  private static void SetEntityName(DXO2016DrawChartDraw.GeoData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityName = new StringValue { Value = value };
    else
      openXmlElement.EntityName = null;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static bool CmpEntityId(DXO2016DrawChartDraw.GeoData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EntityId?.Value == value) return true;
    diffs?.Add(objName, "EntityId", openXmlElement?.EntityId?.Value, value);
    return false;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoData openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// east, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetEast(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return openXmlElement?.East?.Value;
  }
  
  private static bool CmpEast(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.East?.Value == value) return true;
    diffs?.Add(objName, "East", openXmlElement?.East?.Value, value);
    return false;
  }
  
  private static void SetEast(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value)
  {
    openXmlElement.East = value;
  }
  
  /// <summary>
  /// west, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetWest(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return openXmlElement?.West?.Value;
  }
  
  private static bool CmpWest(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.West?.Value == value) return true;
    diffs?.Add(objName, "West", openXmlElement?.West?.Value, value);
    return false;
  }
  
  private static void SetWest(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value)
  {
    openXmlElement.West = value;
  }
  
  /// <summary>
  /// north, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetNorth(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return openXmlElement?.North?.Value;
  }
  
  private static bool CmpNorth(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.North?.Value == value) return true;
    diffs?.Add(objName, "North", openXmlElement?.North?.Value, value);
    return false;
  }
  
  private static void SetNorth(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value)
  {
    openXmlElement.North = value;
  }
  
  /// <summary>
  /// south, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetSouth(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return openXmlElement?.South?.Value;
  }
  
  private static bool CmpSouth(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.South?.Value == value) return true;
    diffs?.Add(objName, "South", openXmlElement?.South?.Value, value);
    return false;
  }
  
  private static void SetSouth(DXO2016DrawChartDraw.GeoData openXmlElement, Double? value)
  {
    openXmlElement.South = value;
  }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  private static DMDrawsChartDraws.GeoPolygons? GetGeoPolygons(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return DMXDrawsChartDraws.GeoPolygonsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoPolygons>());
  }
  
  private static bool CmpGeoPolygons(DXO2016DrawChartDraw.GeoData openXmlElement, DMDrawsChartDraws.GeoPolygons? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoPolygonsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoPolygons>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoPolygons(DXO2016DrawChartDraw.GeoData openXmlElement, DMDrawsChartDraws.GeoPolygons? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoPolygons>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoPolygonsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoPolygons>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  private static DMDrawsChartDraws.Copyrights? GetCopyrights(DXO2016DrawChartDraw.GeoData openXmlElement)
  {
    return DMXDrawsChartDraws.CopyrightsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Copyrights>());
  }
  
  private static bool CmpCopyrights(DXO2016DrawChartDraw.GeoData openXmlElement, DMDrawsChartDraws.Copyrights? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.CopyrightsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Copyrights>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCopyrights(DXO2016DrawChartDraw.GeoData openXmlElement, DMDrawsChartDraws.Copyrights? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Copyrights>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.CopyrightsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Copyrights>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoData? CreateModelElement(DXO2016DrawChartDraw.GeoData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoData();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      value.East = GetEast(openXmlElement);
      value.West = GetWest(openXmlElement);
      value.North = GetNorth(openXmlElement);
      value.South = GetSouth(openXmlElement);
      value.GeoPolygons = GetGeoPolygons(openXmlElement);
      value.Copyrights = GetCopyrights(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoData? openXmlElement, DMDrawsChartDraws.GeoData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityName(openXmlElement, value.EntityName, diffs, objName))
        ok = false;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName))
        ok = false;
      if (!CmpEast(openXmlElement, value.East, diffs, objName))
        ok = false;
      if (!CmpWest(openXmlElement, value.West, diffs, objName))
        ok = false;
      if (!CmpNorth(openXmlElement, value.North, diffs, objName))
        ok = false;
      if (!CmpSouth(openXmlElement, value.South, diffs, objName))
        ok = false;
      if (!CmpGeoPolygons(openXmlElement, value.GeoPolygons, diffs, objName))
        ok = false;
      if (!CmpCopyrights(openXmlElement, value.Copyrights, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoData? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityId(openXmlElement, value?.EntityId);
      SetEast(openXmlElement, value?.East);
      SetWest(openXmlElement, value?.West);
      SetNorth(openXmlElement, value?.North);
      SetSouth(openXmlElement, value?.South);
      SetGeoPolygons(openXmlElement, value?.GeoPolygons);
      SetCopyrights(openXmlElement, value?.Copyrights);
      return openXmlElement;
    }
    return default;
  }
}
