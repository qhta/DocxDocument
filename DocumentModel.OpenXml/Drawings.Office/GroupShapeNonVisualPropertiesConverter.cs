namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public static class GroupShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  private static DMDO.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DXOD.GroupShapeNonVisualProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.NonVisualDrawingProperties>();
    if (element != null)
      return DMXDO.NonVisualDrawingPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualDrawingProperties(DXOD.GroupShapeNonVisualProperties openXmlElement, DMDO.NonVisualDrawingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDO.NonVisualDrawingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.NonVisualDrawingProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualDrawingProperties(DXOD.GroupShapeNonVisualProperties openXmlElement, DMDO.NonVisualDrawingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.NonVisualDrawingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualDrawingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  private static DMDO.NonVisualGroupDrawingShapeProperties? GetNonVisualGroupDrawingShapeProperties(DXOD.GroupShapeNonVisualProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.NonVisualGroupDrawingShapeProperties>();
    if (element != null)
      return DMXDO.NonVisualGroupDrawingShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupDrawingShapeProperties(DXOD.GroupShapeNonVisualProperties openXmlElement, DMDO.NonVisualGroupDrawingShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDO.NonVisualGroupDrawingShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.NonVisualGroupDrawingShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGroupDrawingShapeProperties(DXOD.GroupShapeNonVisualProperties openXmlElement, DMDO.NonVisualGroupDrawingShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.NonVisualGroupDrawingShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.NonVisualGroupDrawingShapePropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualGroupDrawingShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? CreateModelElement(DXOD.GroupShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.GroupShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupDrawingShapeProperties = GetNonVisualGroupDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.GroupShapeNonVisualProperties? openXmlElement, DMDO.GroupShapeNonVisualProperties? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.GroupShapeNonVisualProperties value)
    where OpenXmlElementType: DXOD.GroupShapeNonVisualProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.GroupShapeNonVisualProperties openXmlElement, DMDO.GroupShapeNonVisualProperties value)
  {
    SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
    SetNonVisualGroupDrawingShapeProperties(openXmlElement, value?.NonVisualGroupDrawingShapeProperties);
  }
}
