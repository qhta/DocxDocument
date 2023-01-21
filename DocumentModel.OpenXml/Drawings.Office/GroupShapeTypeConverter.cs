namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public static class GroupShapeTypeConverter
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  private static DMDrawsO.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DXODraw.GroupShapeType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeNonVisualProperties(DXODraw.GroupShapeType openXmlElement, DMDrawsO.GroupShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXODraw.GroupShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  private static DMDrawsO.GroupShapeProperties? GetGroupShapeProperties(DXODraw.GroupShapeType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODraw.GroupShapeProperties>();
    if (itemElement != null)
      return DMXDrawsO.GroupShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeProperties(DXODraw.GroupShapeType openXmlElement, DMDrawsO.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODraw.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsO.GroupShapePropertiesConverter.CreateOpenXmlElement<DXODraw.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsO.GroupShapeType? CreateModelElement(DXODraw.GroupShapeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.GroupShapeType();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.GroupShapeType? value)
    where OpenXmlElementType: DXODraw.GroupShapeType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
      SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
