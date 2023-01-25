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
    return openXmlElement?.RadialAdjustmentGuide?.Value;
  }
  
  private static bool CmpRadialAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RadialAdjustmentGuide?.Value == value;
  }
  
  private static void SetRadialAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RadialAdjustmentGuide = new StringValue { Value = value };
    else
      openXmlElement.RadialAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  private static String? GetMinRadial(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MinRadial?.Value;
  }
  
  private static bool CmpMinRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MinRadial?.Value == value;
  }
  
  private static void SetMinRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinRadial = new StringValue { Value = value };
    else
      openXmlElement.MinRadial = null;
  }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  private static String? GetMaxRadial(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MaxRadial?.Value;
  }
  
  private static bool CmpMaxRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MaxRadial?.Value == value;
  }
  
  private static void SetMaxRadial(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MaxRadial = new StringValue { Value = value };
    else
      openXmlElement.MaxRadial = null;
  }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  private static String? GetAngleAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.AngleAdjustmentGuide?.Value;
  }
  
  private static bool CmpAngleAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.AngleAdjustmentGuide?.Value == value;
  }
  
  private static void SetAngleAdjustmentGuide(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AngleAdjustmentGuide = new StringValue { Value = value };
    else
      openXmlElement.AngleAdjustmentGuide = null;
  }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  private static String? GetMinAngle(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MinAngle?.Value;
  }
  
  private static bool CmpMinAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MinAngle?.Value == value;
  }
  
  private static void SetMinAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinAngle = new StringValue { Value = value };
    else
      openXmlElement.MinAngle = null;
  }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  private static String? GetMaxAngle(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return openXmlElement?.MaxAngle?.Value;
  }
  
  private static bool CmpMaxAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MaxAngle?.Value == value;
  }
  
  private static void SetMaxAngle(DXDraw.AdjustHandlePolar openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MaxAngle = new StringValue { Value = value };
    else
      openXmlElement.MaxAngle = null;
  }
  
  /// <summary>
  /// Shape Position Coordinate.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPosition(DXDraw.AdjustHandlePolar openXmlElement)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Position>());
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
  
  public static DMDraws.AdjustHandlePolar? CreateModelElement(DXDraw.AdjustHandlePolar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AdjustHandlePolar();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustHandlePolar? value)
    where OpenXmlElementType: DXDraw.AdjustHandlePolar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadialAdjustmentGuide(openXmlElement, value?.RadialAdjustmentGuide);
      SetMinRadial(openXmlElement, value?.MinRadial);
      SetMaxRadial(openXmlElement, value?.MaxRadial);
      SetAngleAdjustmentGuide(openXmlElement, value?.AngleAdjustmentGuide);
      SetMinAngle(openXmlElement, value?.MinAngle);
      SetMaxAngle(openXmlElement, value?.MaxAngle);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}
