namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public static class GeoParentEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoParentEntitiesQuery? GetGeoParentEntitiesQuery(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQuery>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoParentEntitiesQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoParentEntitiesQuery(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoParentEntitiesQueryConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoParentEntitiesQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  private static DMDrawsChartDraws.GeoEntity? GetGeoEntity(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoEntity>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoEntityConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoEntity(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoEntity? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoEntity>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoEntityConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoEntity>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  private static DMDrawsChartDraws.GeoParentEntity? GetGeoParentEntity(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntity>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoParentEntityConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoParentEntity(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoParentEntity? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntity>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoParentEntityConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoParentEntity>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoParentEntitiesQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoParentEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoParentEntitiesQueryResult();
      value.GeoParentEntitiesQuery = GetGeoParentEntitiesQuery(openXmlElement);
      value.GeoEntity = GetGeoEntity(openXmlElement);
      value.GeoParentEntity = GetGeoParentEntity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoParentEntitiesQueryResult? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoParentEntitiesQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoParentEntitiesQuery(openXmlElement, value?.GeoParentEntitiesQuery);
      SetGeoEntity(openXmlElement, value?.GeoEntity);
      SetGeoParentEntity(openXmlElement, value?.GeoParentEntity);
      return openXmlElement;
    }
    return default;
  }
}
