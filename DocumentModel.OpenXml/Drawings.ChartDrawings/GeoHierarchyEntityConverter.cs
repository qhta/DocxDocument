namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public static class GeoHierarchyEntityConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO16DCD.GeoHierarchyEntity openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityName);
  }
  
  private static bool CmpEntityName(DXO16DCD.GeoHierarchyEntity openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityName, value, diffs, objName, "EntityName");
  }
  
  private static void SetEntityName(DXO16DCD.GeoHierarchyEntity openXmlElement, String? value)
  {
    openXmlElement.EntityName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO16DCD.GeoHierarchyEntity openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityId);
  }
  
  private static bool CmpEntityId(DXO16DCD.GeoHierarchyEntity openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityId, value, diffs, objName, "EntityId");
  }
  
  private static void SetEntityId(DXO16DCD.GeoHierarchyEntity openXmlElement, String? value)
  {
    openXmlElement.EntityId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.EntityTypeEnum? GetEntityType(DXO16DCD.GeoHierarchyEntity openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO16DCD.GeoHierarchyEntity openXmlElement, DMDCDs.EntityTypeEnum? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEntityType(DXO16DCD.GeoHierarchyEntity openXmlElement, DMDCDs.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(value);
  }
  
  public static DMDCDs.GeoHierarchyEntity? CreateModelElement(DXO16DCD.GeoHierarchyEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoHierarchyEntity();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoHierarchyEntity? openXmlElement, DMDCDs.GeoHierarchyEntity? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityName(openXmlElement, value.EntityName, diffs, objName, propName))
        ok = false;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName, propName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoHierarchyEntity value)
    where OpenXmlElementType: DXO16DCD.GeoHierarchyEntity, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoHierarchyEntity openXmlElement, DMDCDs.GeoHierarchyEntity value)
  {
    SetEntityName(openXmlElement, value?.EntityName);
    SetEntityId(openXmlElement, value?.EntityId);
    SetEntityType(openXmlElement, value?.EntityType);
  }
}
