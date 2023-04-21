namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Graphic Frame.
/// </summary>
public static class GraphicFrameConverter
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  private static String? GetMacro(DXDCD.GraphicFrame openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Macro);
  }
  
  private static bool CmpMacro(DXDCD.GraphicFrame openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Macro, value, diffs, objName, "Macro");
  }
  
  private static void SetMacro(DXDCD.GraphicFrame openXmlElement, String? value)
  {
    openXmlElement.Macro = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Publish To Server
  /// </summary>
  private static Boolean? GetPublished(DXDCD.GraphicFrame openXmlElement)
  {
    return openXmlElement?.Published?.Value;
  }
  
  private static bool CmpPublished(DXDCD.GraphicFrame openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Published?.Value == value) return true;
    diffs?.Add(objName, "Published", openXmlElement?.Published?.Value, value);
    return false;
  }
  
  private static void SetPublished(DXDCD.GraphicFrame openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Published = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Published = null;
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Properties.
  /// </summary>
  private static DMDCD.NonVisualGraphicFrameProperties? GetNonVisualGraphicFrameProperties(DXDCD.GraphicFrame openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.NonVisualGraphicFrameProperties>();
    if (element != null)
      return DMXDCD.NonVisualGraphicFramePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGraphicFrameProperties(DXDCD.GraphicFrame openXmlElement, DMDCD.NonVisualGraphicFrameProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.NonVisualGraphicFramePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.NonVisualGraphicFrameProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGraphicFrameProperties(DXDCD.GraphicFrame openXmlElement, DMDCD.NonVisualGraphicFrameProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.NonVisualGraphicFrameProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.NonVisualGraphicFramePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualGraphicFrameProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Graphic Frame Transform.
  /// </summary>
  private static DMDCD.Transform? GetTransform(DXDCD.GraphicFrame openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDCD.Transform>();
    if (element != null)
      return DMXDCD.TransformConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTransform(DXDCD.GraphicFrame openXmlElement, DMDCD.Transform? value, DiffList? diffs, string? objName)
  {
    return DMXDCD.TransformConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDCD.Transform>(), value, diffs, objName);
  }
  
  private static void SetTransform(DXDCD.GraphicFrame openXmlElement, DMDCD.Transform? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.Transform>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCD.TransformConverter.CreateOpenXmlElement<DXDCD.Transform>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Graphical Object.
  /// </summary>
  private static DMD.Graphic? GetGraphic(DXDCD.GraphicFrame openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Graphic>();
    if (element != null)
      return DMXD.GraphicConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphic(DXDCD.GraphicFrame openXmlElement, DMD.Graphic? value, DiffList? diffs, string? objName)
  {
    return DMXD.GraphicConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Graphic>(), value, diffs, objName);
  }
  
  private static void SetGraphic(DXDCD.GraphicFrame openXmlElement, DMD.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GraphicConverter.CreateOpenXmlElement<DXD.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.GraphicFrame? CreateModelElement(DXDCD.GraphicFrame? openXmlElement)
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
  
  public static bool CompareModelElement(DXDCD.GraphicFrame? openXmlElement, DMDCD.GraphicFrame? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.GraphicFrame value)
    where OpenXmlElementType: DXDCD.GraphicFrame, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.GraphicFrame openXmlElement, DMDCD.GraphicFrame value)
  {
    SetMacro(openXmlElement, value?.Macro);
    SetPublished(openXmlElement, value?.Published);
    SetNonVisualGraphicFrameProperties(openXmlElement, value?.NonVisualGraphicFrameProperties);
    SetTransform(openXmlElement, value?.Transform);
    SetGraphic(openXmlElement, value?.Graphic);
  }
}
