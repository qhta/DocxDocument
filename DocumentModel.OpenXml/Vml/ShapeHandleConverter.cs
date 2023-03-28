namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public static class ShapeHandleConverter
{
  /// <summary>
  /// Handle Position
  /// </summary>
  private static String? GetPosition(DXVml.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Position);
  }
  
  private static bool CmpPosition(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Position, value, diffs, objName, "Position");
  }
  
  private static void SetPosition(DXVml.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.Position = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  private static String? GetPolar(DXVml.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Polar);
  }
  
  private static bool CmpPolar(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Polar, value, diffs, objName, "Polar");
  }
  
  private static void SetPolar(DXVml.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.Polar = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  private static String? GetMap(DXVml.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Map);
  }
  
  private static bool CmpMap(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Map, value, diffs, objName, "Map");
  }
  
  private static void SetMap(DXVml.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.Map = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  private static Boolean? GetInvertX(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.InvertX?.Value;
  }
  
  private static bool CmpInvertX(DXVml.ShapeHandle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InvertX?.Value == value) return true;
    diffs?.Add(objName, "InvertX", openXmlElement?.InvertX?.Value, value);
    return false;
  }
  
  private static void SetInvertX(DXVml.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvertX = value;
    else
      openXmlElement.InvertX = null;
  }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  private static Boolean? GetInvertY(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.InvertY?.Value;
  }
  
  private static bool CmpInvertY(DXVml.ShapeHandle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InvertY?.Value == value) return true;
    diffs?.Add(objName, "InvertY", openXmlElement?.InvertY?.Value, value);
    return false;
  }
  
  private static void SetInvertY(DXVml.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvertY = value;
    else
      openXmlElement.InvertY = null;
  }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  private static Boolean? GetSwitch(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Switch?.Value;
  }
  
  private static bool CmpSwitch(DXVml.ShapeHandle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Switch?.Value == value) return true;
    diffs?.Add(objName, "Switch", openXmlElement?.Switch?.Value, value);
    return false;
  }
  
  private static void SetSwitch(DXVml.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Switch = value;
    else
      openXmlElement.Switch = null;
  }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  private static String? GetXRange(DXVml.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.XRange);
  }
  
  private static bool CmpXRange(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.XRange, value, diffs, objName, "XRange");
  }
  
  private static void SetXRange(DXVml.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.XRange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  private static String? GetYRange(DXVml.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.YRange);
  }
  
  private static bool CmpYRange(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.YRange, value, diffs, objName, "YRange");
  }
  
  private static void SetYRange(DXVml.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.YRange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  private static String? GetRadiusRange(DXVml.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RadiusRange);
  }
  
  private static bool CmpRadiusRange(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RadiusRange, value, diffs, objName, "RadiusRange");
  }
  
  private static void SetRadiusRange(DXVml.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.RadiusRange = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ShapeHandle? CreateModelElement(DXVml.ShapeHandle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeHandle();
      value.Position = GetPosition(openXmlElement);
      value.Polar = GetPolar(openXmlElement);
      value.Map = GetMap(openXmlElement);
      value.InvertX = GetInvertX(openXmlElement);
      value.InvertY = GetInvertY(openXmlElement);
      value.Switch = GetSwitch(openXmlElement);
      value.XRange = GetXRange(openXmlElement);
      value.YRange = GetYRange(openXmlElement);
      value.RadiusRange = GetRadiusRange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXVml.ShapeHandle? openXmlElement, DMVml.ShapeHandle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      if (!CmpPolar(openXmlElement, value.Polar, diffs, objName))
        ok = false;
      if (!CmpMap(openXmlElement, value.Map, diffs, objName))
        ok = false;
      if (!CmpInvertX(openXmlElement, value.InvertX, diffs, objName))
        ok = false;
      if (!CmpInvertY(openXmlElement, value.InvertY, diffs, objName))
        ok = false;
      if (!CmpSwitch(openXmlElement, value.Switch, diffs, objName))
        ok = false;
      if (!CmpXRange(openXmlElement, value.XRange, diffs, objName))
        ok = false;
      if (!CmpYRange(openXmlElement, value.YRange, diffs, objName))
        ok = false;
      if (!CmpRadiusRange(openXmlElement, value.RadiusRange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeHandle value)
    where OpenXmlElementType: DXVml.ShapeHandle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.ShapeHandle openXmlElement, DMVml.ShapeHandle value)
  {
    SetPosition(openXmlElement, value?.Position);
    SetPolar(openXmlElement, value?.Polar);
    SetMap(openXmlElement, value?.Map);
    SetInvertX(openXmlElement, value?.InvertX);
    SetInvertY(openXmlElement, value?.InvertY);
    SetSwitch(openXmlElement, value?.Switch);
    SetXRange(openXmlElement, value?.XRange);
    SetYRange(openXmlElement, value?.YRange);
    SetRadiusRange(openXmlElement, value?.RadiusRange);
  }
}
