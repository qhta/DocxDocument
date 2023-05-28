namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public static class GeoDataPointToEntityQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.EntityTypeEnum? GetEntityType(DXO16DCD.GeoDataPointToEntityQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO16DCD.GeoDataPointToEntityQuery openXmlElement, DMDCDs.EntityTypeEnum? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEntityType(DXO16DCD.GeoDataPointToEntityQuery openXmlElement, DMDCDs.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO16DCD.GeoDataPointToEntityQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityId);
  }
  
  private static bool CmpEntityId(DXO16DCD.GeoDataPointToEntityQuery openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityId, value, diffs, objName, "EntityId");
  }
  
  private static void SetEntityId(DXO16DCD.GeoDataPointToEntityQuery openXmlElement, String? value)
  {
    openXmlElement.EntityId = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMDCDs.GeoDataPointToEntityQuery? CreateModelElement(DXO16DCD.GeoDataPointToEntityQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoDataPointToEntityQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoDataPointToEntityQuery? openXmlElement, DMDCDs.GeoDataPointToEntityQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName, propName))
        ok = false;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoDataPointToEntityQuery value)
    where OpenXmlElementType: DXO16DCD.GeoDataPointToEntityQuery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoDataPointToEntityQuery openXmlElement, DMDCDs.GeoDataPointToEntityQuery value)
  {
    SetEntityType(openXmlElement, value?.EntityType);
    SetEntityId(openXmlElement, value?.EntityId);
  }
}
