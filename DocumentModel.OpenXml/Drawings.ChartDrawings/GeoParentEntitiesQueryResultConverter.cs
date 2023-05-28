namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public static class GeoParentEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  private static DMDCDs.GeoParentEntitiesQuery? GetGeoParentEntitiesQuery(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoParentEntitiesQuery>();
    if (element != null)
      return DMXDCDs.GeoParentEntitiesQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoParentEntitiesQuery(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoParentEntitiesQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoParentEntitiesQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoParentEntitiesQuery>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoParentEntitiesQuery(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoParentEntitiesQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoParentEntitiesQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoParentEntitiesQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntitiesQuery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  private static DMDCDs.GeoEntity? GetGeoEntity(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoEntity>();
    if (element != null)
      return DMXDCDs.GeoEntityConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoEntity(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoEntity? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoEntityConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoEntity>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoEntity(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoEntity? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoEntity>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoEntityConverter.CreateOpenXmlElement<DXO16DCD.GeoEntity>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  private static DMDCDs.GeoParentEntity? GetGeoParentEntity(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoParentEntity>();
    if (element != null)
      return DMXDCDs.GeoParentEntityConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoParentEntity(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoParentEntity? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoParentEntityConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoParentEntity>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoParentEntity(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoParentEntity? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoParentEntity>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoParentEntityConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntity>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.GeoParentEntitiesQueryResult? CreateModelElement(DXO16DCD.GeoParentEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoParentEntitiesQueryResult();
      value.GeoParentEntitiesQuery = GetGeoParentEntitiesQuery(openXmlElement);
      value.GeoEntity = GetGeoEntity(openXmlElement);
      value.GeoParentEntity = GetGeoParentEntity(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoParentEntitiesQueryResult? openXmlElement, DMDCDs.GeoParentEntitiesQueryResult? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoParentEntitiesQuery(openXmlElement, value.GeoParentEntitiesQuery, diffs, objName, propName))
        ok = false;
      if (!CmpGeoEntity(openXmlElement, value.GeoEntity, diffs, objName, propName))
        ok = false;
      if (!CmpGeoParentEntity(openXmlElement, value.GeoParentEntity, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoParentEntitiesQueryResult value)
    where OpenXmlElementType: DXO16DCD.GeoParentEntitiesQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoParentEntitiesQueryResult openXmlElement, DMDCDs.GeoParentEntitiesQueryResult value)
  {
    SetGeoParentEntitiesQuery(openXmlElement, value?.GeoParentEntitiesQuery);
    SetGeoEntity(openXmlElement, value?.GeoEntity);
    SetGeoParentEntity(openXmlElement, value?.GeoParentEntity);
  }
}
