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
    return openXmlElement?.Position?.Value;
  }
  
  private static bool CmpPosition(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Position?.Value == value;
  }
  
  private static void SetPosition(DXVml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Position = new StringValue { Value = value };
    else
      openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  private static String? GetPolar(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Polar?.Value;
  }
  
  private static bool CmpPolar(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Polar?.Value == value;
  }
  
  private static void SetPolar(DXVml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Polar = new StringValue { Value = value };
    else
      openXmlElement.Polar = null;
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  private static String? GetMap(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Map?.Value;
  }
  
  private static bool CmpMap(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Map?.Value == value;
  }
  
  private static void SetMap(DXVml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Map = new StringValue { Value = value };
    else
      openXmlElement.Map = null;
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
    return openXmlElement?.InvertX?.Value == value;
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
    return openXmlElement?.InvertY?.Value == value;
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
    return openXmlElement?.Switch?.Value == value;
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
    return openXmlElement?.XRange?.Value;
  }
  
  private static bool CmpXRange(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.XRange?.Value == value;
  }
  
  private static void SetXRange(DXVml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.XRange = new StringValue { Value = value };
    else
      openXmlElement.XRange = null;
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  private static String? GetYRange(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.YRange?.Value;
  }
  
  private static bool CmpYRange(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.YRange?.Value == value;
  }
  
  private static void SetYRange(DXVml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.YRange = new StringValue { Value = value };
    else
      openXmlElement.YRange = null;
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  private static String? GetRadiusRange(DXVml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.RadiusRange?.Value;
  }
  
  private static bool CmpRadiusRange(DXVml.ShapeHandle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RadiusRange?.Value == value;
  }
  
  private static void SetRadiusRange(DXVml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RadiusRange = new StringValue { Value = value };
    else
      openXmlElement.RadiusRange = null;
  }
  
  public static DMVml.ShapeHandle? CreateModelElement(DXVml.ShapeHandle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.ShapeHandle();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.ShapeHandle? value)
    where OpenXmlElementType: DXVml.ShapeHandle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPosition(openXmlElement, value?.Position);
      SetPolar(openXmlElement, value?.Polar);
      SetMap(openXmlElement, value?.Map);
      SetInvertX(openXmlElement, value?.InvertX);
      SetInvertY(openXmlElement, value?.InvertY);
      SetSwitch(openXmlElement, value?.Switch);
      SetXRange(openXmlElement, value?.XRange);
      SetYRange(openXmlElement, value?.YRange);
      SetRadiusRange(openXmlElement, value?.RadiusRange);
      return openXmlElement;
    }
    return default;
  }
}
