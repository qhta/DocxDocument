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
    return DMXDrawsO.NonVisualDrawingPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingProperties>());
  }
  
  private static bool CmpNonVisualDrawingProperties(DXODraw.GroupShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsO.NonVisualGroupDrawingShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXODraw.NonVisualGroupDrawingShapeProperties>());
  }
  
  private static bool CmpNonVisualGroupDrawingShapeProperties(DXODraw.GroupShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualGroupDrawingShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.NonVisualGroupDrawingShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXODraw.NonVisualGroupDrawingShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXODraw.GroupShapeNonVisualProperties? openXmlElement, DMDrawsO.GroupShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualGroupDrawingShapeProperties(openXmlElement, value.NonVisualGroupDrawingShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
