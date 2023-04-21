namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoEntity Class.
/// </summary>
public static class GeoEntityConverter
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO16DCD.GeoEntity openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityName);
  }
  
  private static bool CmpEntityName(DXO16DCD.GeoEntity openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityName, value, diffs, objName, "EntityName");
  }
  
  private static void SetEntityName(DXO16DCD.GeoEntity openXmlElement, String? value)
  {
    openXmlElement.EntityName = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.EntityTypeEnum? GetEntityType(DXO16DCD.GeoEntity openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO16DCD.GeoEntity openXmlElement, DMDCDs.EntityTypeEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName);
  }
  
  private static void SetEntityType(DXO16DCD.GeoEntity openXmlElement, DMDCDs.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDCDs.EntityTypeEnum>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoEntity? CreateModelElement(DXO16DCD.GeoEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoEntity();
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoEntity? openXmlElement, DMDCDs.GeoEntity? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityName(openXmlElement, value.EntityName, diffs, objName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoEntity value)
    where OpenXmlElementType: DXO16DCD.GeoEntity, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoEntity openXmlElement, DMDCDs.GeoEntity value)
  {
    SetEntityName(openXmlElement, value?.EntityName);
    SetEntityType(openXmlElement, value?.EntityType);
  }
}
