namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public static class ClearConverter
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoLocationQueryResults? GetGeoLocationQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQueryResults>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoLocationQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoLocationQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoLocationQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoLocationQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocationQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataEntityQueryResults? GetGeoDataEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQueryResults>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoDataEntityQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoDataEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoDataEntityQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataEntityQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataEntityQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataPointToEntityQueryResults? GetGeoDataPointToEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoDataPointToEntityQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoDataPointToEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataPointToEntityQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildEntitiesQueryResults? GetGeoChildEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoChildEntitiesQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoChildEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoParentEntitiesQueryResults? GetGeoParentEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoParentEntitiesQueryResultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoParentEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoParentEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.Clear? CreateModelElement(DXO2016DrawChartDraw.Clear? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Clear();
      value.GeoLocationQueryResults = GetGeoLocationQueryResults(openXmlElement);
      value.GeoDataEntityQueryResults = GetGeoDataEntityQueryResults(openXmlElement);
      value.GeoDataPointToEntityQueryResults = GetGeoDataPointToEntityQueryResults(openXmlElement);
      value.GeoChildEntitiesQueryResults = GetGeoChildEntitiesQueryResults(openXmlElement);
      value.GeoParentEntitiesQueryResults = GetGeoParentEntitiesQueryResults(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Clear? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Clear, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoLocationQueryResults(openXmlElement, value?.GeoLocationQueryResults);
      SetGeoDataEntityQueryResults(openXmlElement, value?.GeoDataEntityQueryResults);
      SetGeoDataPointToEntityQueryResults(openXmlElement, value?.GeoDataPointToEntityQueryResults);
      SetGeoChildEntitiesQueryResults(openXmlElement, value?.GeoChildEntitiesQueryResults);
      SetGeoParentEntitiesQueryResults(openXmlElement, value?.GeoParentEntitiesQueryResults);
      return openXmlElement;
    }
    return default;
  }
}
