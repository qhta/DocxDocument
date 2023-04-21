namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public static class ClearConverter
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  private static DMDCDs.GeoLocationQueryResults? GetGeoLocationQueryResults(DXO16DCD.Clear openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoLocationQueryResults>();
    if (element != null)
      return DMXDCDs.GeoLocationQueryResultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocationQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoLocationQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoLocationQueryResultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoLocationQueryResults>(), value, diffs, objName);
  }
  
  private static void SetGeoLocationQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoLocationQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoLocationQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoLocationQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoLocationQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  private static DMDCDs.GeoDataEntityQueryResults? GetGeoDataEntityQueryResults(DXO16DCD.Clear openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoDataEntityQueryResults>();
    if (element != null)
      return DMXDCDs.GeoDataEntityQueryResultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataEntityQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoDataEntityQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoDataEntityQueryResultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoDataEntityQueryResults>(), value, diffs, objName);
  }
  
  private static void SetGeoDataEntityQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoDataEntityQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoDataEntityQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoDataEntityQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoDataEntityQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  private static DMDCDs.GeoDataPointToEntityQueryResults? GetGeoDataPointToEntityQueryResults(DXO16DCD.Clear openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoDataPointToEntityQueryResults>();
    if (element != null)
      return DMXDCDs.GeoDataPointToEntityQueryResultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataPointToEntityQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoDataPointToEntityQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoDataPointToEntityQueryResultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoDataPointToEntityQueryResults>(), value, diffs, objName);
  }
  
  private static void SetGeoDataPointToEntityQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoDataPointToEntityQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoDataPointToEntityQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoDataPointToEntityQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointToEntityQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  private static DMDCDs.GeoChildEntitiesQueryResults? GetGeoChildEntitiesQueryResults(DXO16DCD.Clear openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoChildEntitiesQueryResults>();
    if (element != null)
      return DMXDCDs.GeoChildEntitiesQueryResultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildEntitiesQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoChildEntitiesQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoChildEntitiesQueryResultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoChildEntitiesQueryResults>(), value, diffs, objName);
  }
  
  private static void SetGeoChildEntitiesQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoChildEntitiesQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoChildEntitiesQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoChildEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntitiesQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  private static DMDCDs.GeoParentEntitiesQueryResults? GetGeoParentEntitiesQueryResults(DXO16DCD.Clear openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoParentEntitiesQueryResults>();
    if (element != null)
      return DMXDCDs.GeoParentEntitiesQueryResultsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoParentEntitiesQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoParentEntitiesQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoParentEntitiesQueryResultsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoParentEntitiesQueryResults>(), value, diffs, objName);
  }
  
  private static void SetGeoParentEntitiesQueryResults(DXO16DCD.Clear openXmlElement, DMDCDs.GeoParentEntitiesQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoParentEntitiesQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoParentEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntitiesQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Clear? CreateModelElement(DXO16DCD.Clear? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Clear();
      value.GeoLocationQueryResults = GetGeoLocationQueryResults(openXmlElement);
      value.GeoDataEntityQueryResults = GetGeoDataEntityQueryResults(openXmlElement);
      value.GeoDataPointToEntityQueryResults = GetGeoDataPointToEntityQueryResults(openXmlElement);
      value.GeoChildEntitiesQueryResults = GetGeoChildEntitiesQueryResults(openXmlElement);
      value.GeoParentEntitiesQueryResults = GetGeoParentEntitiesQueryResults(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.Clear? openXmlElement, DMDCDs.Clear? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoLocationQueryResults(openXmlElement, value.GeoLocationQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoDataEntityQueryResults(openXmlElement, value.GeoDataEntityQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoDataPointToEntityQueryResults(openXmlElement, value.GeoDataPointToEntityQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoChildEntitiesQueryResults(openXmlElement, value.GeoChildEntitiesQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoParentEntitiesQueryResults(openXmlElement, value.GeoParentEntitiesQueryResults, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Clear value)
    where OpenXmlElementType: DXO16DCD.Clear, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Clear openXmlElement, DMDCDs.Clear value)
  {
    SetGeoLocationQueryResults(openXmlElement, value?.GeoLocationQueryResults);
    SetGeoDataEntityQueryResults(openXmlElement, value?.GeoDataEntityQueryResults);
    SetGeoDataPointToEntityQueryResults(openXmlElement, value?.GeoDataPointToEntityQueryResults);
    SetGeoChildEntitiesQueryResults(openXmlElement, value?.GeoChildEntitiesQueryResults);
    SetGeoParentEntitiesQueryResults(openXmlElement, value?.GeoParentEntitiesQueryResults);
  }
}
