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
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXDrawChartDraw.GraphicFrame openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXDrawChartDraw.GraphicFrame openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  private static Boolean? GetPublished(DXDrawChartDraw.GraphicFrame openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDrawChartDraw.GraphicFrame openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualGraphicFramePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGraphicFrameProperties(DXDrawChartDraw.GraphicFrame openXmlElement, DMDrawsChartDraw.NonVisualGraphicFrameProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualGraphicFramePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.Transform>();
    if (element != null)
      return DMXDrawsChartDraw.TransformConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform(DXDrawChartDraw.GraphicFrame openXmlElement, DMDrawsChartDraw.Transform? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.TransformConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.Transform>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.Graphic>();
    if (element != null)
      return DMXDraws.GraphicConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphic(DXDrawChartDraw.GraphicFrame openXmlElement, DMDraws.Graphic? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GraphicConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Graphic>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ChartDrawing.GraphicFrame? CreateModelElement(DXDrawChartDraw.GraphicFrame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.GraphicFrame();
      value.Macro = GetMacro(openXmlElement);
      value.Published = GetPublished(openXmlElement);
      value.NonVisualGraphicFrameProperties = GetNonVisualGraphicFrameProperties(openXmlElement);
      value.Transform = GetTransform(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.GraphicFrame? openXmlElement, DMDrawsChartDraw.GraphicFrame? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMacro(openXmlElement, value.Macro, diffs, objName))
        ok = false;
      if (!CmpPublished(openXmlElement, value.Published, diffs, objName))
        ok = false;
      if (!CmpNonVisualGraphicFrameProperties(openXmlElement, value.NonVisualGraphicFrameProperties, diffs, objName))
        ok = false;
      if (!CmpTransform(openXmlElement, value.Transform, diffs, objName))
        ok = false;
      if (!CmpGraphic(openXmlElement, value.Graphic, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.GraphicFrame value)
    where OpenXmlElementType: DXDrawChartDraw.GraphicFrame, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawChartDraw.GraphicFrame openXmlElement, DMDrawsChartDraw.GraphicFrame value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetPublished(openXmlElement, value?.Published);
    SetNonVisualGraphicFrameProperties(openXmlElement, value?.NonVisualGraphicFrameProperties);
    SetTransform(openXmlElement, value?.Transform);
    SetGraphic(openXmlElement, value?.Graphic);
  }
}
