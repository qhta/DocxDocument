namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Properties.
/// </summary>
public static class NonVisualGraphicFramePropertiesConverter
{
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGraphicFrameProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGraphicFrameProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGraphicFrameProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Non-Visual Graphic Frame Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties? GetNonVisualGraphicFrameDrawingProperties(DXDrawChartDraw.NonVisualGraphicFrameProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties>();
    if (element != null)
      return DMXDrawsChartDraw.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGraphicFrameDrawingProperties(DXDrawChartDraw.NonVisualGraphicFrameProperties openXmlElement, DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraw.NonVisualGraphicFrameDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualGraphicFrameDrawingProperties(DXDrawChartDraw.NonVisualGraphicFrameProperties openXmlElement, DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualGraphicFrameDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties? CreateModelElement(DXDrawChartDraw.NonVisualGraphicFrameProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualGraphicFrameProperties? openXmlElement, DMDrawsChartDraw.NonVisualGraphicFrameProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualGraphicFrameDrawingProperties(openXmlElement, value.NonVisualGraphicFrameDrawingProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualGraphicFrameProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualGraphicFrameProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGraphicFrameDrawingProperties(openXmlElement, value?.NonVisualGraphicFrameDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
