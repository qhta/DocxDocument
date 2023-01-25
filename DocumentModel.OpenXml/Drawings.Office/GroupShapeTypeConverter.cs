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
    return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>());
  }
  
  private static bool CmpGroupShapeNonVisualProperties(DXODraw.GroupShapeType openXmlElement, DMDrawsO.GroupShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.GroupShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.GroupShapeNonVisualProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.GroupShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.GroupShapeProperties>());
  }
  
  private static bool CmpGroupShapeProperties(DXODraw.GroupShapeType openXmlElement, DMDrawsO.GroupShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.GroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.GroupShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXODraw.GroupShapeType? openXmlElement, DMDrawsO.GroupShapeType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGroupShapeNonVisualProperties(openXmlElement, value.GroupShapeNonVisualProperties, diffs, objName))
        ok = false;
      if (!CmpGroupShapeProperties(openXmlElement, value.GroupShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
