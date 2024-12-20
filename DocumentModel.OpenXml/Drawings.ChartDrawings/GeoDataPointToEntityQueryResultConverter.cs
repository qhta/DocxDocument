namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public static class GeoDataPointToEntityQueryResultConverter
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  private static DMDCDs.GeoDataPointQuery? GetGeoDataPointQuery(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoDataPointQuery>();
    if (element != null)
      return DMXDCDs.GeoDataPointQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataPointQuery(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement, DMDCDs.GeoDataPointQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoDataPointQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoDataPointQuery>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoDataPointQuery(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement, DMDCDs.GeoDataPointQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoDataPointQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoDataPointQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointQuery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  private static DMDCDs.GeoDataPointToEntityQuery? GetGeoDataPointToEntityQuery(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoDataPointToEntityQuery>();
    if (element != null)
      return DMXDCDs.GeoDataPointToEntityQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataPointToEntityQuery(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement, DMDCDs.GeoDataPointToEntityQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoDataPointToEntityQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoDataPointToEntityQuery>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoDataPointToEntityQuery(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement, DMDCDs.GeoDataPointToEntityQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoDataPointToEntityQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoDataPointToEntityQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointToEntityQuery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.GeoDataPointToEntityQueryResult? CreateModelElement(DXO16DCD.GeoDataPointToEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoDataPointToEntityQueryResult();
      value.GeoDataPointQuery = GetGeoDataPointQuery(openXmlElement);
      value.GeoDataPointToEntityQuery = GetGeoDataPointToEntityQuery(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoDataPointToEntityQueryResult? openXmlElement, DMDCDs.GeoDataPointToEntityQueryResult? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoDataPointQuery(openXmlElement, value.GeoDataPointQuery, diffs, objName, propName))
        ok = false;
      if (!CmpGeoDataPointToEntityQuery(openXmlElement, value.GeoDataPointToEntityQuery, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoDataPointToEntityQueryResult value)
    where OpenXmlElementType: DXO16DCD.GeoDataPointToEntityQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoDataPointToEntityQueryResult openXmlElement, DMDCDs.GeoDataPointToEntityQueryResult value)
  {
    SetGeoDataPointQuery(openXmlElement, value?.GeoDataPointQuery);
    SetGeoDataPointToEntityQuery(openXmlElement, value?.GeoDataPointToEntityQuery);
  }
}
