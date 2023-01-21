namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public static class NonVisualGroupShapePropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? GetNonVisualGroupShapeDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualGroupShapeDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupShapeDrawingProperties(DXDrawChartDraw.NonVisualGroupShapeProperties openXmlElement, DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualGroupShapeDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualGroupShapeDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.NonVisualGroupShapeProperties? CreateModelElement(DXDrawChartDraw.NonVisualGroupShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualGroupShapeProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupShapeDrawingProperties = GetNonVisualGroupShapeDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualGroupShapeProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualGroupShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGroupShapeDrawingProperties(openXmlElement, value?.NonVisualGroupShapeDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
