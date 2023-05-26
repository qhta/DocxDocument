namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public static class ShapeHandleConverter
{
  /// <summary>
  /// Handle Position
  /// </summary>
  private static String? GetPosition(DXV.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Position);
  }
  
  private static bool CmpPosition(DXV.ShapeHandle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Position, value, diffs, objName, "Position");
  }
  
  private static void SetPosition(DXV.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.Position = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  private static String? GetPolar(DXV.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Polar);
  }
  
  private static bool CmpPolar(DXV.ShapeHandle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Polar, value, diffs, objName, "Polar");
  }
  
  private static void SetPolar(DXV.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.Polar = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  private static String? GetMap(DXV.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Map);
  }
  
  private static bool CmpMap(DXV.ShapeHandle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Map, value, diffs, objName, "Map");
  }
  
  private static void SetMap(DXV.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.Map = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  private static Boolean? GetInvertX(DXV.ShapeHandle openXmlElement)
  {
    return openXmlElement?.InvertX?.Value;
  }
  
  private static bool CmpInvertX(DXV.ShapeHandle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.InvertX?.Value == value) return true;
    diffs?.Add(objName, "InvertX", openXmlElement?.InvertX?.Value, value);
    return false;
  }
  
  private static void SetInvertX(DXV.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvertX = value;
    else
      openXmlElement.InvertX = null;
  }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  private static Boolean? GetInvertY(DXV.ShapeHandle openXmlElement)
  {
    return openXmlElement?.InvertY?.Value;
  }
  
  private static bool CmpInvertY(DXV.ShapeHandle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.InvertY?.Value == value) return true;
    diffs?.Add(objName, "InvertY", openXmlElement?.InvertY?.Value, value);
    return false;
  }
  
  private static void SetInvertY(DXV.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvertY = value;
    else
      openXmlElement.InvertY = null;
  }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  private static Boolean? GetSwitch(DXV.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Switch?.Value;
  }
  
  private static bool CmpSwitch(DXV.ShapeHandle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Switch?.Value == value) return true;
    diffs?.Add(objName, "Switch", openXmlElement?.Switch?.Value, value);
    return false;
  }
  
  private static void SetSwitch(DXV.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Switch = value;
    else
      openXmlElement.Switch = null;
  }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  private static String? GetXRange(DXV.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.XRange);
  }
  
  private static bool CmpXRange(DXV.ShapeHandle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.XRange, value, diffs, objName, "XRange");
  }
  
  private static void SetXRange(DXV.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.XRange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  private static String? GetYRange(DXV.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.YRange);
  }
  
  private static bool CmpYRange(DXV.ShapeHandle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.YRange, value, diffs, objName, "YRange");
  }
  
  private static void SetYRange(DXV.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.YRange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  private static String? GetRadiusRange(DXV.ShapeHandle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RadiusRange);
  }
  
  private static bool CmpRadiusRange(DXV.ShapeHandle openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RadiusRange, value, diffs, objName, "RadiusRange");
  }
  
  private static void SetRadiusRange(DXV.ShapeHandle openXmlElement, String? value)
  {
    openXmlElement.RadiusRange = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Vml.ShapeHandle? CreateModelElement(DXV.ShapeHandle? openXmlElement)
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
  
  public static bool CompareModelElement(DXV.ShapeHandle? openXmlElement, DMV.ShapeHandle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      if (!CmpPolar(openXmlElement, value.Polar, diffs, objName, propName))
        ok = false;
      if (!CmpMap(openXmlElement, value.Map, diffs, objName, propName))
        ok = false;
      if (!CmpInvertX(openXmlElement, value.InvertX, diffs, objName, propName))
        ok = false;
      if (!CmpInvertY(openXmlElement, value.InvertY, diffs, objName, propName))
        ok = false;
      if (!CmpSwitch(openXmlElement, value.Switch, diffs, objName, propName))
        ok = false;
      if (!CmpXRange(openXmlElement, value.XRange, diffs, objName, propName))
        ok = false;
      if (!CmpYRange(openXmlElement, value.YRange, diffs, objName, propName))
        ok = false;
      if (!CmpRadiusRange(openXmlElement, value.RadiusRange, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.ShapeHandle value)
    where OpenXmlElementType: DXV.ShapeHandle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.ShapeHandle openXmlElement, DMV.ShapeHandle value)
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
