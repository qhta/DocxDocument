namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// XY Adjust Handle converter from/to OpenXml.
///</summary>
public static class AdjustHandleXYConverter
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  private static String? GetXAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.XAdjustmentGuide);
  }
  
  private static bool CmpXAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.XAdjustmentGuide, value, diffs, objName, "XAdjustmentGuide");
  }
  
  private static void SetXAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.XAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  private static String? GetMinX(DXDraw.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinX);
  }
  
  private static bool CmpMinX(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinX, value, diffs, objName, "MinX");
  }
  
  private static void SetMinX(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MinX = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  private static String? GetMaxX(DXDraw.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxX);
  }
  
  private static bool CmpMaxX(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxX, value, diffs, objName, "MaxX");
  }
  
  private static void SetMaxX(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MaxX = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  private static String? GetYAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.YAdjustmentGuide);
  }
  
  private static bool CmpYAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.YAdjustmentGuide, value, diffs, objName, "YAdjustmentGuide");
  }
  
  private static void SetYAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.YAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  private static String? GetMinY(DXDraw.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinY);
  }
  
  private static bool CmpMinY(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinY, value, diffs, objName, "MinY");
  }
  
  private static void SetMinY(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MinY = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  private static String? GetMaxY(DXDraw.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxY);
  }
  
  private static bool CmpMaxY(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxY, value, diffs, objName, "MaxY");
  }
  
  private static void SetMaxY(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MaxY = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPosition(DXDraw.AdjustHandleXY openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Position>();
    if (element != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPosition(DXDraw.AdjustHandleXY openXmlElement, DMDraws.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Position>(), value, diffs, objName);
  }
  
  private static void SetPosition(DXDraw.AdjustHandleXY openXmlElement, DMDraws.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXDraw.Position>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandleXY? CreateModelElement(DXDraw.AdjustHandleXY? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandleXY();
      value.XAdjustmentGuide = GetXAdjustmentGuide(openXmlElement);
      value.MinX = GetMinX(openXmlElement);
      value.MaxX = GetMaxX(openXmlElement);
      value.YAdjustmentGuide = GetYAdjustmentGuide(openXmlElement);
      value.MinY = GetMinY(openXmlElement);
      value.MaxY = GetMaxY(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AdjustHandleXY? openXmlElement, DMDraws.AdjustHandleXY? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpXAdjustmentGuide(openXmlElement, value.XAdjustmentGuide, diffs, objName))
        ok = false;
      if (!CmpMinX(openXmlElement, value.MinX, diffs, objName))
        ok = false;
      if (!CmpMaxX(openXmlElement, value.MaxX, diffs, objName))
        ok = false;
      if (!CmpYAdjustmentGuide(openXmlElement, value.YAdjustmentGuide, diffs, objName))
        ok = false;
      if (!CmpMinY(openXmlElement, value.MinY, diffs, objName))
        ok = false;
      if (!CmpMaxY(openXmlElement, value.MaxY, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustHandleXY value)
    where OpenXmlElementType: DXDraw.AdjustHandleXY, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AdjustHandleXY openXmlElement, DMDraws.AdjustHandleXY value)
  {
    SetXAdjustmentGuide(openXmlElement, value?.XAdjustmentGuide);
    SetMinX(openXmlElement, value?.MinX);
    SetMaxX(openXmlElement, value?.MaxX);
    SetYAdjustmentGuide(openXmlElement, value?.YAdjustmentGuide);
    SetMinY(openXmlElement, value?.MinY);
    SetMaxY(openXmlElement, value?.MaxY);
    SetPosition(openXmlElement, value?.Position);
  }
}
