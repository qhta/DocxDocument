namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public static class ShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDO.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXOD.ShapeNonVisualProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDO.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXOD.ShapeNonVisualProperties openXmlElement, DMDO.NonVisualDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.NonVisualDrawingProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingProperties(DXOD.ShapeNonVisualProperties openXmlElement, DMDO.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  private static DMDO.NonVisualDrawingShapeProperties? GetNonVisualDrawingShapeProperties(DXOD.ShapeNonVisualProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.NonVisualDrawingShapeProperties>();
    if (element != null)
      return DMXDO.NonVisualDrawingShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingShapeProperties(DXOD.ShapeNonVisualProperties openXmlElement, DMDO.NonVisualDrawingShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.NonVisualDrawingShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.NonVisualDrawingShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNonVisualDrawingShapeProperties(DXOD.ShapeNonVisualProperties openXmlElement, DMDO.NonVisualDrawingShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.NonVisualDrawingShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.NonVisualDrawingShapePropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualDrawingShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.ShapeNonVisualProperties? CreateModelElement(DXOD.ShapeNonVisualProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXOD.ShapeNonVisualProperties? openXmlElement, DMDO.ShapeNonVisualProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNonVisualDrawingProperties(openXmlElement, value.NonVisualDrawingProperties, diffs, objName, propName))
        ok = false;
      if (!CmpNonVisualDrawingShapeProperties(openXmlElement, value.NonVisualDrawingShapeProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.ShapeNonVisualProperties value)
    where OpenXmlElementType: DXOD.ShapeNonVisualProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.ShapeNonVisualProperties openXmlElement, DMDO.ShapeNonVisualProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualDrawingShapeProperties(openXmlElement, value?.NonVisualDrawingShapeProperties);
  }
}
