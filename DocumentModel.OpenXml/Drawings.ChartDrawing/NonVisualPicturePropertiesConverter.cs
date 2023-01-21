namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public static class NonVisualPicturePropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement, DMDrawsChartDraw.NonVisualDrawingProperties? value)
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
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  private static DMDrawsChartDraw.NonVisualPictureDrawingProperties? GetNonVisualPictureDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.NonVisualPictureDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraw.NonVisualPictureDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualPictureDrawingProperties(DXDrawChartDraw.NonVisualPictureProperties openXmlElement, DMDrawsChartDraw.NonVisualPictureDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.NonVisualPictureDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraw.NonVisualPictureDrawingPropertiesConverter.CreateOpenXmlElement<DXDrawChartDraw.NonVisualPictureDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.NonVisualPictureProperties? CreateModelElement(DXDrawChartDraw.NonVisualPictureProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualPictureProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualPictureDrawingProperties = GetNonVisualPictureDrawingProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualPictureProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualPictureProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualPictureDrawingProperties(openXmlElement, value?.NonVisualPictureDrawingProperties);
      return openXmlElement;
    }
    return default;
  }
}
