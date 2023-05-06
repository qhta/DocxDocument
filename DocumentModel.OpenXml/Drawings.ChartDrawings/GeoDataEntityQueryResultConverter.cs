namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public static class GeoDataEntityQueryResultConverter
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  private static DMDCDs.GeoDataEntityQuery? GetGeoDataEntityQuery(DXO16DCD.GeoDataEntityQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoDataEntityQuery>();
    if (element != null)
      return DMXDCDs.GeoDataEntityQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataEntityQuery(DXO16DCD.GeoDataEntityQueryResult openXmlElement, DMDCDs.GeoDataEntityQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoDataEntityQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoDataEntityQuery>(), value, diffs, objName);
  }
  
  private static void SetGeoDataEntityQuery(DXO16DCD.GeoDataEntityQueryResult openXmlElement, DMDCDs.GeoDataEntityQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoDataEntityQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoDataEntityQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoDataEntityQuery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  private static DMDCDs.GeoData? GetGeoData(DXO16DCD.GeoDataEntityQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoData>();
    if (element != null)
      return DMXDCDs.GeoDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoData(DXO16DCD.GeoDataEntityQueryResult openXmlElement, DMDCDs.GeoData? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoData>(), value, diffs, objName);
  }
  
  private static void SetGeoData(DXO16DCD.GeoDataEntityQueryResult openXmlElement, DMDCDs.GeoData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoDataConverter.CreateOpenXmlElement<DXO16DCD.GeoData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult? CreateModelElement(DXO16DCD.GeoDataEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult();
      value.GeoDataEntityQuery = GetGeoDataEntityQuery(openXmlElement);
      value.GeoData = GetGeoData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoDataEntityQueryResult? openXmlElement, DMDCDs.GeoDataEntityQueryResult? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoDataEntityQuery(openXmlElement, value.GeoDataEntityQuery, diffs, objName))
        ok = false;
      if (!CmpGeoData(openXmlElement, value.GeoData, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoDataEntityQueryResult value)
    where OpenXmlElementType: DXO16DCD.GeoDataEntityQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoDataEntityQueryResult openXmlElement, DMDCDs.GeoDataEntityQueryResult value)
  {
    SetGeoDataEntityQuery(openXmlElement, value?.GeoDataEntityQuery);
    SetGeoData(openXmlElement, value?.GeoData);
  }
}
