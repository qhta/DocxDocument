namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public static class GeoLocationConverter
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLatitude(DXO2016DrawChartDraw.GeoLocation openXmlElement)
  {
    return openXmlElement.Latitude?.Value;
  }
  
  private static bool CmpLatitude(DXO2016DrawChartDraw.GeoLocation openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Latitude?.Value == value;
  }
  
  private static void SetLatitude(DXO2016DrawChartDraw.GeoLocation openXmlElement, Double? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLongitude(DXO2016DrawChartDraw.GeoLocation openXmlElement)
  {
    return openXmlElement.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXO2016DrawChartDraw.GeoLocation openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Longitude?.Value == value;
  }
  
  private static void SetLongitude(DXO2016DrawChartDraw.GeoLocation openXmlElement, Double? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityName(DXO2016DrawChartDraw.GeoLocation openXmlElement)
  {
    return openXmlElement?.EntityName?.Value;
  }
  
  private static bool CmpEntityName(DXO2016DrawChartDraw.GeoLocation openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EntityName?.Value == value;
  }
  
  private static void SetEntityName(DXO2016DrawChartDraw.GeoLocation openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityName = new StringValue { Value = value };
    else
      openXmlElement.EntityName = null;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.EntityTypeEnum? GetEntityType(DXO2016DrawChartDraw.GeoLocation openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static bool CmpEntityType(DXO2016DrawChartDraw.GeoLocation openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEntityType(DXO2016DrawChartDraw.GeoLocation openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// Address.
  /// </summary>
  private static DMDrawsChartDraws.Address? GetAddress(DXO2016DrawChartDraw.GeoLocation openXmlElement)
  {
    return DMXDrawsChartDraws.AddressConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Address>());
  }
  
  private static bool CmpAddress(DXO2016DrawChartDraw.GeoLocation openXmlElement, DMDrawsChartDraws.Address? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.AddressConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Address>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAddress(DXO2016DrawChartDraw.GeoLocation openXmlElement, DMDrawsChartDraws.Address? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Address>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.AddressConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Address>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoLocation? CreateModelElement(DXO2016DrawChartDraw.GeoLocation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoLocation();
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.EntityName = GetEntityName(openXmlElement);
      value.EntityType = GetEntityType(openXmlElement);
      value.Address = GetAddress(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoLocation? openXmlElement, DMDrawsChartDraws.GeoLocation? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLatitude(openXmlElement, value.Latitude, diffs, objName))
        ok = false;
      if (!CmpLongitude(openXmlElement, value.Longitude, diffs, objName))
        ok = false;
      if (!CmpEntityName(openXmlElement, value.EntityName, diffs, objName))
        ok = false;
      if (!CmpEntityType(openXmlElement, value.EntityType, diffs, objName))
        ok = false;
      if (!CmpAddress(openXmlElement, value.Address, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocation? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocation, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLatitude(openXmlElement, value?.Latitude);
      SetLongitude(openXmlElement, value?.Longitude);
      SetEntityName(openXmlElement, value?.EntityName);
      SetEntityType(openXmlElement, value?.EntityType);
      SetAddress(openXmlElement, value?.Address);
      return openXmlElement;
    }
    return default;
  }
}
