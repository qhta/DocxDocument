namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
public static class NonVisualShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualShapeDrawingProperties? GetNonVisualShapeDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualShapeDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualShapeDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualShapeDrawingProperties(DXDrawChartDraw.NonVisualShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.NonVisualShapeProperties? CreateModelElement(DXDrawChartDraw.NonVisualShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualShapeDrawingProperties = GetNonVisualShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualShapeProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualShapeDrawingProperties(openXmlElement, value?.NonVisualShapeDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
