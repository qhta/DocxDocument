namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Connector Non Visual Properties.
/// </summary>
public static class NonVisualConnectorShapeDrawingPropertiesConverter
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualConnectionShapeProperties? GetNonVisualConnectionShapeProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualConnectionShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualConnectionShapeProperties(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties openXmlElement, DMDrawsChartDraw.NonVisualConnectionShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualConnectionShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualConnectionShapePropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualConnectionShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualConnectionShapeProperties = GetNonVisualConnectionShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualConnectorShapeDrawingProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualConnectorShapeDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualConnectionShapeProperties(openXmlElement, value?.NonVisualConnectionShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
