namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeNonVisualProperties Class converter from/to OpenXml.
///</summary>
public static class ShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDrawsO.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXODraw.ShapeNonVisualProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDrawsO.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXODraw.ShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.NonVisualDrawingProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXODraw.NonVisualDrawingShapeProperties>();
    if (element != null)
      return DMXDrawsO.NonVisualDrawingShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingShapeProperties(DXODraw.ShapeNonVisualProperties openXmlElement, DMDrawsO.NonVisualDrawingShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsO.NonVisualDrawingShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODraw.NonVisualDrawingShapeProperties>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Office.ShapeNonVisualProperties? CreateModelElement(DXODraw.ShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualDrawingShapeProperties = GetNonVisualDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.ShapeNonVisualProperties? openXmlElement, DMDrawsO.ShapeNonVisualProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName))
        ok = false;
      if (!CmpNonVisualDrawingShapeProperties(openXmlElement, value.NonVisualDrawingShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.ShapeNonVisualProperties value)
    where OpenXmlElementType: DXODraw.ShapeNonVisualProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.ShapeNonVisualProperties openXmlElement, DMDrawsO.ShapeNonVisualProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualDrawingShapeProperties(openXmlElement, value?.NonVisualDrawingShapeProperties);
  }
}
