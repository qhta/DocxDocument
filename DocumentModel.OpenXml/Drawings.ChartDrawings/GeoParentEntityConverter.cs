namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public static class GeoParentEntityConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoParentEntity openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static bool CmpEntityId(DXO2016DrawChartDraw.GeoParentEntity openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EntityId?.Value == value;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoParentEntity openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  public static DMDrawsChartDraws.GeoParentEntity? CreateModelElement(DXO2016DrawChartDraw.GeoParentEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoParentEntity();
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoParentEntity? openXmlElement, DMDrawsChartDraws.GeoParentEntity? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoParentEntity? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoParentEntity, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      return openXmlElement;
    }
    return default;
  }
}
