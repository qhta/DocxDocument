namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
public static class AdjustHandlePolarConverter
{
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  private static String? GetRadialAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RadialAdjustmentGuide);
  }
  
  private static bool CmpRadialAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RadialAdjustmentGuide, value, diffs, objName, "RadialAdjustmentGuide");
  }
  
  private static void SetRadialAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.RadialAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  private static String? GetMinRadial(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinRadial);
  }
  
  private static bool CmpMinRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinRadial, value, diffs, objName, "MinRadial");
  }
  
  private static void SetMinRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MinRadial = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  private static String? GetMaxRadial(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxRadial);
  }
  
  private static bool CmpMaxRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxRadial, value, diffs, objName, "MaxRadial");
  }
  
  private static void SetMaxRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MaxRadial = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  private static String? GetAngleAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AngleAdjustmentGuide);
  }
  
  private static bool CmpAngleAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AngleAdjustmentGuide, value, diffs, objName, "AngleAdjustmentGuide");
  }
  
  private static void SetAngleAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.AngleAdjustmentGuide = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  private static String? GetMinAngle(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinAngle);
  }
  
  private static bool CmpMinAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinAngle, value, diffs, objName, "MinAngle");
  }
  
  private static void SetMinAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MinAngle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  private static String? GetMaxAngle(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MaxAngle);
  }
  
  private static bool CmpMaxAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MaxAngle, value, diffs, objName, "MaxAngle");
  }
  
  private static void SetMaxAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    openXmlElement.MaxAngle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPosition(DXDraw.AdjustHandlePolar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Position>();
    if (element != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPosition(DXDraw.AdjustHandlePolar openXmlElement, DMDraws.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Position>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPosition(DXDraw.AdjustHandlePolar openXmlElement, DMDraws.AdjustPoint2DType? value)
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
  
  public static DocumentModel.Drawings.AdjustHandlePolar? CreateModelElement(DXDraw.AdjustHandlePolar? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.AdjustHandlePolar? openXmlElement, DMDraws.AdjustHandlePolar? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustHandlePolar value)
    where OpenXmlElementType: DXDraw.AdjustHandlePolar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AdjustHandlePolar openXmlElement, DMDraws.AdjustHandlePolar value)
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
