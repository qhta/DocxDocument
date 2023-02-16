namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public static class GeoChildEntitiesQueryConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static bool CmpEntityId(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EntityId?.Value == value) return true;
    diffs?.Add(objName, "EntityId", openXmlElement?.EntityId?.Value, value);
    return false;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildTypes? GetGeoChildTypes(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildTypes>();
    if (element != null)
      return DMXDrawsChartDraws.GeoChildTypesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildTypes(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement, DMDrawsChartDraws.GeoChildTypes? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoChildTypesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildTypes>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoChildTypes(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement, DMDrawsChartDraws.GeoChildTypes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildTypes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoChildTypesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildTypes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      value.GeoChildTypes = GetGeoChildTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQuery? openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQuery? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName))
        ok = false;
      if (!CmpGeoChildTypes(openXmlElement, value.GeoChildTypes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntitiesQuery? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntitiesQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      SetGeoChildTypes(openXmlElement, value?.GeoChildTypes);
      return openXmlElement;
    }
    return default;
  }
}
