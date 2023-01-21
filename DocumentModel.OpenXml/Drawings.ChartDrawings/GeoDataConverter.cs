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
    return openXmlElement.East?.Value;
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
    return openXmlElement.West?.Value;
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
    return openXmlElement.North?.Value;
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
    return openXmlElement.South?.Value;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoPolygons>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoPolygonsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Copyrights>();
    if (itemElement != null)
      return DMXDrawsChartDraws.CopyrightsConverter.CreateModelElement(itemElement);
    return null;
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
