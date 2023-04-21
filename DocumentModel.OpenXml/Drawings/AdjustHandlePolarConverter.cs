namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
public static class AdjustHandlePolarConverter
{
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  private static String? GetRadialAdjustmentGuide(DXD.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RadialAdjustmentGuide);
  }
  
  private static bool CmpRadialAdjustmentGuide(DXD.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RadialAdjustmentGuide, value, diffs, objName, "RadialAdjustmentGuide");
  }
  
  private static void SetRadialAdjustmentGuide(DXD.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.RadialAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  private static String? GetMinRadial(DXD.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinRadial);
  }
  
  private static bool CmpMinRadial(DXD.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinRadial, value, diffs, objName, "MinRadial");
  }
  
  private static void SetMinRadial(DXD.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MinRadial = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  private static String? GetMaxRadial(DXD.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxRadial);
  }
  
  private static bool CmpMaxRadial(DXD.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxRadial, value, diffs, objName, "MaxRadial");
  }
  
  private static void SetMaxRadial(DXD.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MaxRadial = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  private static String? GetAngleAdjustmentGuide(DXD.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AngleAdjustmentGuide);
  }
  
  private static bool CmpAngleAdjustmentGuide(DXD.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AngleAdjustmentGuide, value, diffs, objName, "AngleAdjustmentGuide");
  }
  
  private static void SetAngleAdjustmentGuide(DXD.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.AngleAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  private static String? GetMinAngle(DXD.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinAngle);
  }
  
  private static bool CmpMinAngle(DXD.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinAngle, value, diffs, objName, "MinAngle");
  }
  
  private static void SetMinAngle(DXD.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MinAngle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  private static String? GetMaxAngle(DXD.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxAngle);
  }
  
  private static bool CmpMaxAngle(DXD.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxAngle, value, diffs, objName, "MaxAngle");
  }
  
  private static void SetMaxAngle(DXD.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MaxAngle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  private static DMD.AdjustPoint2DType? GetPosition(DXD.AdjustHandlePolar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Position>();
    if (element != null)
      return DMXD.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPosition(DXD.AdjustHandlePolar openXmlElement, DMD.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXD.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Position>(), value, diffs, objName);
  }
  
  private static void SetPosition(DXD.AdjustHandlePolar openXmlElement, DMD.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Position>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXD.Position>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandlePolar? CreateModelElement(DXD.AdjustHandlePolar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandlePolar();
      value.RadialAdjustmentGuide = GetRadialAdjustmentGuide(openXmlElement);
      value.MinRadial = GetMinRadial(openXmlElement);
      value.MaxRadial = GetMaxRadial(openXmlElement);
      value.AngleAdjustmentGuide = GetAngleAdjustmentGuide(openXmlElement);
      value.MinAngle = GetMinAngle(openXmlElement);
      value.MaxAngle = GetMaxAngle(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AdjustHandlePolar? openXmlElement, DMD.AdjustHandlePolar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadialAdjustmentGuide(openXmlElement, value.RadialAdjustmentGuide, diffs, objName))
        ok = false;
      if (!CmpMinRadial(openXmlElement, value.MinRadial, diffs, objName))
        ok = false;
      if (!CmpMaxRadial(openXmlElement, value.MaxRadial, diffs, objName))
        ok = false;
      if (!CmpAngleAdjustmentGuide(openXmlElement, value.AngleAdjustmentGuide, diffs, objName))
        ok = false;
      if (!CmpMinAngle(openXmlElement, value.MinAngle, diffs, objName))
        ok = false;
      if (!CmpMaxAngle(openXmlElement, value.MaxAngle, diffs, objName))
        ok = false;
      if (!CmpPosition(openXmlElement, value.Position, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AdjustHandlePolar value)
    where OpenXmlElementType: DXD.AdjustHandlePolar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AdjustHandlePolar openXmlElement, DMD.AdjustHandlePolar value)
  {
    SetRadialAdjustmentGuide(openXmlElement, value?.RadialAdjustmentGuide);
    SetMinRadial(openXmlElement, value?.MinRadial);
    SetMaxRadial(openXmlElement, value?.MaxRadial);
    SetAngleAdjustmentGuide(openXmlElement, value?.AngleAdjustmentGuide);
    SetMinAngle(openXmlElement, value?.MinAngle);
    SetMaxAngle(openXmlElement, value?.MaxAngle);
    SetPosition(openXmlElement, value?.Position);
  }
}
