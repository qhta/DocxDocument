namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public static class ShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsO.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXODraw.ShapeNonVisualProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsO.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DXODraw.ShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXODraw.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  private static DMDrawsO.NonVisualDrawingShapeProperties? GetNonVisualDrawingShapeProperties(DXODraw.ShapeNonVisualProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingShapeProperties>();
    if (itemElement != null)
      return DMXDrawsO.NonVisualDrawingShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingShapeProperties(DXODraw.ShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualDrawingShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.NonVisualDrawingShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.NonVisualDrawingShapePropertiesConverter.CreateOpenXmlElement<DXODraw.NonVisualDrawingShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsO.ShapeNonVisualProperties? CreateModelElement(DXODraw.ShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.ShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualDrawingShapeProperties = GetNonVisualDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.ShapeNonVisualProperties? value)
    where OpenXmlElementType: DXODraw.ShapeNonVisualProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualDrawingShapeProperties(openXmlElement, value?.NonVisualDrawingShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
