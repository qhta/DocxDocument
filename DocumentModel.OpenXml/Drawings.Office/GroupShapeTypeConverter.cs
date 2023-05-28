namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public static class GroupShapeTypeConverter
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  private static DMDO.GroupShapeNonVisualProperties? GetGroupShapeNonVisualProperties(DXOD.GroupShapeType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
    if (element != null)
      return DMXDO.GroupShapeNonVisualPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeNonVisualProperties(DXOD.GroupShapeType openXmlElement, DMDO.GroupShapeNonVisualProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.GroupShapeNonVisualPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.GroupShapeNonVisualProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetGroupShapeNonVisualProperties(DXOD.GroupShapeType openXmlElement, DMDO.GroupShapeNonVisualProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeNonVisualProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  private static DMDO.GroupShapeProperties? GetGroupShapeProperties(DXOD.GroupShapeType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOD.GroupShapeProperties>();
    if (element != null)
      return DMXDO.GroupShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeProperties(DXOD.GroupShapeType openXmlElement, DMDO.GroupShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDO.GroupShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOD.GroupShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetGroupShapeProperties(DXOD.GroupShapeType openXmlElement, DMDO.GroupShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOD.GroupShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDO.GroupShapePropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.GroupShapeType? CreateModelElement(DXOD.GroupShapeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.GroupShapeType();
      value.GroupShapeNonVisualProperties = GetGroupShapeNonVisualProperties(openXmlElement);
      value.GroupShapeProperties = GetGroupShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.GroupShapeType? openXmlElement, DMDO.GroupShapeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGroupShapeNonVisualProperties(openXmlElement, value.GroupShapeNonVisualProperties, diffs, objName, propName))
        ok = false;
      if (!CmpGroupShapeProperties(openXmlElement, value.GroupShapeProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.GroupShapeType value)
    where OpenXmlElementType: DXOD.GroupShapeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.GroupShapeType openXmlElement, DMDO.GroupShapeType value)
  {
    SetGroupShapeNonVisualProperties(openXmlElement, value?.GroupShapeNonVisualProperties);
    SetGroupShapeProperties(openXmlElement, value?.GroupShapeProperties);
  }
}
