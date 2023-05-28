namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public static class GeoChildEntitiesQueryConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO16DCD.GeoChildEntitiesQuery openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EntityId);
  }
  
  private static bool CmpEntityId(DXO16DCD.GeoChildEntitiesQuery openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EntityId, value, diffs, objName, "EntityId");
  }
  
  private static void SetEntityId(DXO16DCD.GeoChildEntitiesQuery openXmlElement, String? value)
  {
    openXmlElement.EntityId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  private static DMDCDs.GeoChildTypes? GetGeoChildTypes(DXO16DCD.GeoChildEntitiesQuery openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoChildTypes>();
    if (element != null)
      return DMXDCDs.GeoChildTypesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildTypes(DXO16DCD.GeoChildEntitiesQuery openXmlElement, DMDCDs.GeoChildTypes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoChildTypesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoChildTypes>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoChildTypes(DXO16DCD.GeoChildEntitiesQuery openXmlElement, DMDCDs.GeoChildTypes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoChildTypes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoChildTypesConverter.CreateOpenXmlElement<DXO16DCD.GeoChildTypes>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.GeoChildEntitiesQuery? CreateModelElement(DXO16DCD.GeoChildEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoChildEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      value.GeoChildTypes = GetGeoChildTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoChildEntitiesQuery? openXmlElement, DMDCDs.GeoChildEntitiesQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEntityId(openXmlElement, value.EntityId, diffs, objName, propName))
        ok = false;
      if (!CmpGeoChildTypes(openXmlElement, value.GeoChildTypes, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoChildEntitiesQuery value)
    where OpenXmlElementType: DXO16DCD.GeoChildEntitiesQuery, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoChildEntitiesQuery openXmlElement, DMDCDs.GeoChildEntitiesQuery value)
  {
    SetEntityId(openXmlElement, value?.EntityId);
    SetGeoChildTypes(openXmlElement, value?.GeoChildTypes);
  }
}
