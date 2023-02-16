namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public static class AdjustHandleXYConverter
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  private static String? GetXAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement)
  {
    return openXmlElement?.XAdjustmentGuide?.Value;
  }
  
  private static bool CmpXAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.XAdjustmentGuide?.Value == value) return true;
    diffs?.Add(objName, "XAdjustmentGuide", openXmlElement?.XAdjustmentGuide?.Value, value);
    return false;
  }
  
  private static void SetXAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.XAdjustmentGuide = new StringValue { Value = value };
    else
      openXmlElement.XAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  private static String? GetMinX(DXDraw.AdjustHandleXY openXmlElement)
  {
    return openXmlElement?.MinX?.Value;
  }
  
  private static bool CmpMinX(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MinX?.Value == value) return true;
    diffs?.Add(objName, "MinX", openXmlElement?.MinX?.Value, value);
    return false;
  }
  
  private static void SetMinX(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinX = new StringValue { Value = value };
    else
      openXmlElement.MinX = null;
  }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  private static String? GetMaxX(DXDraw.AdjustHandleXY openXmlElement)
  {
    return openXmlElement?.MaxX?.Value;
  }
  
  private static bool CmpMaxX(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxX?.Value == value) return true;
    diffs?.Add(objName, "MaxX", openXmlElement?.MaxX?.Value, value);
    return false;
  }
  
  private static void SetMaxX(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MaxX = new StringValue { Value = value };
    else
      openXmlElement.MaxX = null;
  }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  private static String? GetYAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement)
  {
    return openXmlElement?.YAdjustmentGuide?.Value;
  }
  
  private static bool CmpYAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.YAdjustmentGuide?.Value == value) return true;
    diffs?.Add(objName, "YAdjustmentGuide", openXmlElement?.YAdjustmentGuide?.Value, value);
    return false;
  }
  
  private static void SetYAdjustmentGuide(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.YAdjustmentGuide = new StringValue { Value = value };
    else
      openXmlElement.YAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  private static String? GetMinY(DXDraw.AdjustHandleXY openXmlElement)
  {
    return openXmlElement?.MinY?.Value;
  }
  
  private static bool CmpMinY(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MinY?.Value == value) return true;
    diffs?.Add(objName, "MinY", openXmlElement?.MinY?.Value, value);
    return false;
  }
  
  private static void SetMinY(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinY = new StringValue { Value = value };
    else
      openXmlElement.MinY = null;
  }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  private static String? GetMaxY(DXDraw.AdjustHandleXY openXmlElement)
  {
    return openXmlElement?.MaxY?.Value;
  }
  
  private static bool CmpMaxY(DXDraw.AdjustHandleXY openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxY?.Value == value) return true;
    diffs?.Add(objName, "MaxY", openXmlElement?.MaxY?.Value, value);
    return false;
  }
  
  private static void SetMaxY(DXDraw.AdjustHandleXY openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MaxY = new StringValue { Value = value };
    else
      openXmlElement.MaxY = null;
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
    return DMXDraws.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Position>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustHandleXY? value)
    where OpenXmlElementType: DXDraw.AdjustHandleXY, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetXAdjustmentGuide(openXmlElement, value?.XAdjustmentGuide);
      SetMinX(openXmlElement, value?.MinX);
      SetMaxX(openXmlElement, value?.MaxX);
      SetYAdjustmentGuide(openXmlElement, value?.YAdjustmentGuide);
      SetMinY(openXmlElement, value?.MinY);
      SetMaxY(openXmlElement, value?.MaxY);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}
