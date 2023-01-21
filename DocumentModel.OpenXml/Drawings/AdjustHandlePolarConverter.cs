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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Position>();
    if (itemElement != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
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
