namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropertiesConverter
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  private static DMDraws.GroupShapeLocks? GetGroupShapeLocks(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GroupShapeLocks>();
    if (element != null)
      return DMXDraws.GroupShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeLocks(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDraws.GroupShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GroupShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GroupShapeLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupShapeLocks(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDraws.GroupShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GroupShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GroupShapeLocksConverter.CreateOpenXmlElement<DXDraw.GroupShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  private static DMDraws.NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>();
    if (element != null)
      return DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensionList(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensionList(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateOpenXmlElement<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? CreateModelElement(DXODraw.NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties();
      value.GroupShapeLocks = GetGroupShapeLocks(openXmlElement);
      value.NonVisualGroupDrawingShapePropsExtensionList = GetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.NonVisualGroupDrawingShapeProperties? openXmlElement, DMDrawsO.NonVisualGroupDrawingShapeProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGroupShapeLocks(openXmlElement, value.GroupShapeLocks, diffs, objName))
        ok = false;
      if (!CmpNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value.NonVisualGroupDrawingShapePropsExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.NonVisualGroupDrawingShapeProperties value)
    where OpenXmlElementType: DXODraw.NonVisualGroupDrawingShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDrawsO.NonVisualGroupDrawingShapeProperties value)
  {
    SetGroupShapeLocks(openXmlElement, value?.GroupShapeLocks);
    SetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensionList);
  }
}
