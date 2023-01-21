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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualGraphicFrameDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraw.NonVisualGraphicFrameProperties? CreateModelElement(DXDrawChartDraw.NonVisualGraphicFrameProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualGraphicFrameProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGraphicFrameDrawingProperties = GetNonVisualGraphicFrameDrawingProperties(openXmlElement);
      return value;
    }
    return null;
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
