namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQuery Class converter from/to OpenXml.
///</summary>
public static class GeoParentEntitiesQueryConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoParentEntitiesQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityId);
  }
  
  private static bool CmpEntityId(DXO2016DrawChartDraw.GeoParentEntitiesQuery openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityId, value, diffs, objName, "EntityId");
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoParentEntitiesQuery openXmlElement, String? value)
  {
    openXmlElement.EntityId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery? CreateModelElement(DXO2016DrawChartDraw.GeoParentEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoParentEntitiesQuery? openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQuery? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoParentEntitiesQuery value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoParentEntitiesQuery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoParentEntitiesQuery openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQuery value)
  {
    SetEntityId(openXmlElement, value?.EntityId);
  }
}
