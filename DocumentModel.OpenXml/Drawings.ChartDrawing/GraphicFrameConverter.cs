namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public static class GraphicFrameConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDrawChartDraw.GraphicFrame openXmlElement)
  {
    return openXmlElement?.Macro?.Value;
  }
  
  private static void SetMacro(DXDrawChartDraw.GraphicFrame openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Macro = new StringValue { Value = value };
    else
      openXmlElement.Macro = null;
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  private static Boolean? GetPublished(DXDrawChartDraw.GraphicFrame openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static void SetPublished(DXDrawChartDraw.GraphicFrame openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualGraphicFrameProperties? GetNonVisualGraphicFrameProperties(DXDrawChartDraw.GraphicFrame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualGraphicFramePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGraphicFrameProperties(DXDrawChartDraw.GraphicFrame openXmlElement, DMDrawsChartDraw.NonVisualGraphicFrameProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualGraphicFramePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualGraphicFrameProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  private static DMDrawsChartDraw.Transform? GetTransform(DXDrawChartDraw.GraphicFrame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.Transform>();
    if (itemElement != null)
      return DMXDrawsChartDraw.TransformConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTransform(DXDrawChartDraw.GraphicFrame openXmlElement, DMDrawsChartDraw.Transform? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.Transform>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.TransformConverter.CreateOpenXmlElement<DXDrawChartDraw.Transform>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  private static DMDraws.Graphic? GetGraphic(DXDrawChartDraw.GraphicFrame openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Graphic>();
    if (itemElement != null)
      return DMXDraws.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphic(DXDrawChartDraw.GraphicFrame openXmlElement, DMDraws.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GraphicConverter.CreateOpenXmlElement<DXDraw.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.GraphicFrame? CreateModelElement(DXDrawChartDraw.GraphicFrame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.GraphicFrame();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualGraphicFrameProperties = GetNonVisualGraphicFrameProperties(openXmlElement);
      value.Transform = GetTransform(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.GraphicFrame? value)
    where OpenXmlElementType: DXDrawChartDraw.GraphicFrame, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacro(openXmlElement, value?.Macro);
      SetPublished(openXmlElement, value?.Published);
      SetNonVisualGraphicFrameProperties(openXmlElement, value?.NonVisualGraphicFrameProperties);
      SetTransform(openXmlElement, value?.Transform);
      SetGraphic(openXmlElement, value?.Graphic);
      return openXmlElement;
    }
    return default;
  }
}
