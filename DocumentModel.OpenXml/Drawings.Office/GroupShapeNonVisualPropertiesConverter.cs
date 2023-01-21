namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public static class GroupShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsO.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXODraw.GroupShapeNonVisualProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DMXDrawsO.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingProperties(DXODraw.GroupShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualDrawingProperties? value)
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
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  private static DMDrawsO.NonVisualGroupDrawingShapeProperties? GetNonVisualGroupDrawingShapeProperties(DXODraw.GroupShapeNonVisualProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.NonVisualGroupDrawingShapeProperties>();
    if (itemElement != null)
      return DMXDrawsO.NonVisualGroupDrawingShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupDrawingShapeProperties(DXODraw.GroupShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualGroupDrawingShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.NonVisualGroupDrawingShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.NonVisualGroupDrawingShapePropertiesConverter.CreateOpenXmlElement<DXODraw.NonVisualGroupDrawingShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsO.GroupShapeNonVisualProperties? CreateModelElement(DXODraw.GroupShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.GroupShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupDrawingShapeProperties = GetNonVisualGroupDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.GroupShapeNonVisualProperties? value)
    where OpenXmlElementType: DXODraw.GroupShapeNonVisualProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGroupDrawingShapeProperties(openXmlElement, value?.NonVisualGroupDrawingShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
