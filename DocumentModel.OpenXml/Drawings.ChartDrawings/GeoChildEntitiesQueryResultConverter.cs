namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public static class GeoChildEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  private static DMDCDs.GeoChildEntitiesQuery? GetGeoChildEntitiesQuery(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoChildEntitiesQuery>();
    if (element != null)
      return DMXDCDs.GeoChildEntitiesQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildEntitiesQuery(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement, DMDCDs.GeoChildEntitiesQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoChildEntitiesQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoChildEntitiesQuery>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoChildEntitiesQuery(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement, DMDCDs.GeoChildEntitiesQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoChildEntitiesQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoChildEntitiesQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntitiesQuery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  private static DMDCDs.GeoChildEntities? GetGeoChildEntities(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoChildEntities>();
    if (element != null)
      return DMXDCDs.GeoChildEntitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildEntities(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement, DMDCDs.GeoChildEntities? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoChildEntitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoChildEntities>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoChildEntities(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement, DMDCDs.GeoChildEntities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoChildEntities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoChildEntitiesConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntities>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.GeoChildEntitiesQueryResult? CreateModelElement(DXO16DCD.GeoChildEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoChildEntitiesQueryResult();
      value.GeoChildEntitiesQuery = GetGeoChildEntitiesQuery(openXmlElement);
      value.GeoChildEntities = GetGeoChildEntities(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoChildEntitiesQueryResult? openXmlElement, DMDCDs.GeoChildEntitiesQueryResult? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoChildEntitiesQuery(openXmlElement, value.GeoChildEntitiesQuery, diffs, objName, propName))
        ok = false;
      if (!CmpGeoChildEntities(openXmlElement, value.GeoChildEntities, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoChildEntitiesQueryResult value)
    where OpenXmlElementType: DXO16DCD.GeoChildEntitiesQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoChildEntitiesQueryResult openXmlElement, DMDCDs.GeoChildEntitiesQueryResult value)
  {
    SetGeoChildEntitiesQuery(openXmlElement, value?.GeoChildEntitiesQuery);
    SetGeoChildEntities(openXmlElement, value?.GeoChildEntities);
  }
}
