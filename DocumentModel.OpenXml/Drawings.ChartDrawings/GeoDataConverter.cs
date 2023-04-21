namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public static class GeoDataConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO16DCD.GeoData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityName);
  }
  
  private static bool CmpEntityName(DXO16DCD.GeoData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityName, value, diffs, objName, "EntityName");
  }
  
  private static void SetEntityName(DXO16DCD.GeoData openXmlElement, String? value)
  {
    openXmlElement.EntityName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO16DCD.GeoData openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityId);
  }
  
  private static bool CmpEntityId(DXO16DCD.GeoData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityId, value, diffs, objName, "EntityId");
  }
  
  private static void SetEntityId(DXO16DCD.GeoData openXmlElement, String? value)
  {
    openXmlElement.EntityId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// east, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetEast(DXO16DCD.GeoData openXmlElement)
  {
    return openXmlElement?.East?.Value;
  }
  
  private static bool CmpEast(DXO16DCD.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.East?.Value == value) return true;
    diffs?.Add(objName, "East", openXmlElement?.East?.Value, value);
    return false;
  }
  
  private static void SetEast(DXO16DCD.GeoData openXmlElement, Double? value)
  {
    openXmlElement.East = value;
  }
  
  /// <summary>
  /// west, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetWest(DXO16DCD.GeoData openXmlElement)
  {
    return openXmlElement?.West?.Value;
  }
  
  private static bool CmpWest(DXO16DCD.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.West?.Value == value) return true;
    diffs?.Add(objName, "West", openXmlElement?.West?.Value, value);
    return false;
  }
  
  private static void SetWest(DXO16DCD.GeoData openXmlElement, Double? value)
  {
    openXmlElement.West = value;
  }
  
  /// <summary>
  /// north, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetNorth(DXO16DCD.GeoData openXmlElement)
  {
    return openXmlElement?.North?.Value;
  }
  
  private static bool CmpNorth(DXO16DCD.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.North?.Value == value) return true;
    diffs?.Add(objName, "North", openXmlElement?.North?.Value, value);
    return false;
  }
  
  private static void SetNorth(DXO16DCD.GeoData openXmlElement, Double? value)
  {
    openXmlElement.North = value;
  }
  
  /// <summary>
  /// south, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetSouth(DXO16DCD.GeoData openXmlElement)
  {
    return openXmlElement?.South?.Value;
  }
  
  private static bool CmpSouth(DXO16DCD.GeoData openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.South?.Value == value) return true;
    diffs?.Add(objName, "South", openXmlElement?.South?.Value, value);
    return false;
  }
  
  private static void SetSouth(DXO16DCD.GeoData openXmlElement, Double? value)
  {
    openXmlElement.South = value;
  }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  private static DMDCDs.GeoPolygons? GetGeoPolygons(DXO16DCD.GeoData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoPolygons>();
    if (element != null)
      return DMXDCDs.GeoPolygonsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoPolygons(DXO16DCD.GeoData openXmlElement, DMDCDs.GeoPolygons? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoPolygonsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoPolygons>(), value, diffs, objName);
  }
  
  private static void SetGeoPolygons(DXO16DCD.GeoData openXmlElement, DMDCDs.GeoPolygons? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoPolygons>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoPolygonsConverter.CreateOpenXmlElement<DXO16DCD.GeoPolygons>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  private static DMDCDs.Copyrights? GetCopyrights(DXO16DCD.GeoData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Copyrights>();
    if (element != null)
      return DMXDCDs.CopyrightsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCopyrights(DXO16DCD.GeoData openXmlElement, DMDCDs.Copyrights? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.CopyrightsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Copyrights>(), value, diffs, objName);
  }
  
  private static void SetCopyrights(DXO16DCD.GeoData openXmlElement, DMDCDs.Copyrights? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Copyrights>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.CopyrightsConverter.CreateOpenXmlElement<DXO16DCD.Copyrights>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoData? CreateModelElement(DXO16DCD.GeoData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoData();
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
  
  public static bool CompareModelElement(DXO16DCD.GeoData? openXmlElement, DMDCDs.GeoData? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoData value)
    where OpenXmlElementType: DXO16DCD.GeoData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoData openXmlElement, DMDCDs.GeoData value)
  {
    SetEntityName(openXmlElement, value?.EntityName);
    SetEntityId(openXmlElement, value?.EntityId);
    SetEast(openXmlElement, value?.East);
    SetWest(openXmlElement, value?.West);
    SetNorth(openXmlElement, value?.North);
    SetSouth(openXmlElement, value?.South);
    SetGeoPolygons(openXmlElement, value?.GeoPolygons);
    SetCopyrights(openXmlElement, value?.Copyrights);
  }
}
