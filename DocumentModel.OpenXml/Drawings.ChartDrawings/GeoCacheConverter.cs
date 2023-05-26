namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public static class GeoCacheConverter
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetProvider(DXO16DCD.GeoCache openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Provider);
  }
  
  private static bool CmpProvider(DXO16DCD.GeoCache openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Provider, value, diffs, objName, "Provider");
  }
  
  private static void SetProvider(DXO16DCD.GeoCache openXmlElement, String? value)
  {
    openXmlElement.Provider = StringValueConverter.CreateStringValue(value);
  }
  
  private static String? GetXsdbase64Binary(DXO16DCD.GeoCache openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.Xsdbase64Binary>()?.Text;
  }
  
  private static bool CmpXsdbase64Binary(DXO16DCD.GeoCache openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO16DCD.Xsdbase64Binary>()?.Text == value;
  }
  
  private static void SetXsdbase64Binary(DXO16DCD.GeoCache openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Xsdbase64Binary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO16DCD.Xsdbase64Binary { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.Clear? GetClear(DXO16DCD.GeoCache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Clear>();
    if (element != null)
      return DMXDCDs.ClearConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClear(DXO16DCD.GeoCache openXmlElement, DMDCDs.Clear? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.ClearConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Clear>(), value, diffs, objName, propName);
  }
  
  private static void SetClear(DXO16DCD.GeoCache openXmlElement, DMDCDs.Clear? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Clear>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.ClearConverter.CreateOpenXmlElement<DXO16DCD.Clear>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoCache? CreateModelElement(DXO16DCD.GeoCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoCache();
      value.Provider = GetProvider(openXmlElement);
      value.Xsdbase64Binary = GetXsdbase64Binary(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoCache? openXmlElement, DMDCDs.GeoCache? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpProvider(openXmlElement, value.Provider, diffs, objName, propName))
        ok = false;
      if (!CmpXsdbase64Binary(openXmlElement, value.Xsdbase64Binary, diffs, objName, propName))
        ok = false;
      if (!CmpClear(openXmlElement, value.Clear, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoCache value)
    where OpenXmlElementType: DXO16DCD.GeoCache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoCache openXmlElement, DMDCDs.GeoCache value)
  {
    SetProvider(openXmlElement, value?.Provider);
    SetXsdbase64Binary(openXmlElement, value?.Xsdbase64Binary);
    SetClear(openXmlElement, value?.Clear);
  }
}
