namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public static class AdjustHandleXYConverter
{
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  private static String? GetXAdjustmentGuide(DXD.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.XAdjustmentGuide);
  }
  
  private static bool CmpXAdjustmentGuide(DXD.AdjustHandleXY openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.XAdjustmentGuide, value, diffs, objName, "XAdjustmentGuide");
  }
  
  private static void SetXAdjustmentGuide(DXD.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.XAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  private static String? GetMinX(DXD.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinX);
  }
  
  private static bool CmpMinX(DXD.AdjustHandleXY openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinX, value, diffs, objName, "MinX");
  }
  
  private static void SetMinX(DXD.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MinX = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  private static String? GetMaxX(DXD.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxX);
  }
  
  private static bool CmpMaxX(DXD.AdjustHandleXY openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxX, value, diffs, objName, "MaxX");
  }
  
  private static void SetMaxX(DXD.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MaxX = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  private static String? GetYAdjustmentGuide(DXD.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.YAdjustmentGuide);
  }
  
  private static bool CmpYAdjustmentGuide(DXD.AdjustHandleXY openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.YAdjustmentGuide, value, diffs, objName, "YAdjustmentGuide");
  }
  
  private static void SetYAdjustmentGuide(DXD.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.YAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  private static String? GetMinY(DXD.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinY);
  }
  
  private static bool CmpMinY(DXD.AdjustHandleXY openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinY, value, diffs, objName, "MinY");
  }
  
  private static void SetMinY(DXD.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MinY = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  private static String? GetMaxY(DXD.AdjustHandleXY openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxY);
  }
  
  private static bool CmpMaxY(DXD.AdjustHandleXY openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxY, value, diffs, objName, "MaxY");
  }
  
  private static void SetMaxY(DXD.AdjustHandleXY openXmlElement, String? value)
  {
    openXmlElement.MaxY = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  private static DMD.AdjustPoint2DType? GetPosition(DXD.AdjustHandleXY openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Position>();
    if (element != null)
      return DMXD.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPosition(DXD.AdjustHandleXY openXmlElement, DMD.AdjustPoint2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Position>(), value, diffs, objName, propName);
  }
  
  private static void SetPosition(DXD.AdjustHandleXY openXmlElement, DMD.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXD.Position>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.AdjustHandleXY? CreateModelElement(DXD.AdjustHandleXY? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AdjustHandleXY();
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
  
  public static bool CompareModelElement(DXD.AdjustHandleXY? openXmlElement, DMD.AdjustHandleXY? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpXAdjustmentGuide(openXmlElement, value.XAdjustmentGuide, diffs, objName, propName))
        ok = false;
      if (!CmpMinX(openXmlElement, value.MinX, diffs, objName, propName))
        ok = false;
      if (!CmpMaxX(openXmlElement, value.MaxX, diffs, objName, propName))
        ok = false;
      if (!CmpYAdjustmentGuide(openXmlElement, value.YAdjustmentGuide, diffs, objName, propName))
        ok = false;
      if (!CmpMinY(openXmlElement, value.MinY, diffs, objName, propName))
        ok = false;
      if (!CmpMaxY(openXmlElement, value.MaxY, diffs, objName, propName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AdjustHandleXY value)
    where OpenXmlElementType: DXD.AdjustHandleXY, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AdjustHandleXY openXmlElement, DMD.AdjustHandleXY value)
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
