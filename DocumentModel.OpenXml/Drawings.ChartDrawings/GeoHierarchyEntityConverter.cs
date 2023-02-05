namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public static class GeoHierarchyEntityConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }
  
  private static bool CmpEntityName(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EntityName?.Value == value) return true;
    diffs?.Add(objName, "EntityName", openXmlElement?.EntityName?.Value, value);
    return false;
  }
  
  private static void SetEntityName(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityName = new StringValue { Value = value };
    else
      openXmlElement.EntityName = null;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static bool CmpEntityId(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.EntityId?.Value == value) return true;
    diffs?.Add(objName, "EntityId", openXmlElement?.EntityId?.Value, value);
    return false;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.EntityTypeEnum? GetEntityType(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEntityType(DXO2016DrawChartDraw.GeoHierarchyEntity openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(value);
  }
  
  public static DMDrawsChartDraws.GeoHierarchyEntity? CreateModelElement(DXO2016DrawChartDraw.GeoHierarchyEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoHierarchyEntity();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoHierarchyEntity? openXmlElement, DMDrawsChartDraws.GeoHierarchyEntity? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityName(openXmlElement, value.EntityName, diffs, objName))
        ok = false;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoHierarchyEntity? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoHierarchyEntity, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityId(openXmlElement, value?.EntityId);
      SetEntityType(openXmlElement, value?.EntityType);
      return openXmlElement;
    }
    return default;
  }
}
