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
    return DMXDraws.GroupShapeLocksConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.GroupShapeLocks>());
  }
  
  private static bool CmpGroupShapeLocks(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDraws.GroupShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GroupShapeLocksConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.GroupShapeLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>());
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensionList(DXODraw.NonVisualGroupDrawingShapeProperties openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsO.NonVisualGroupDrawingShapeProperties? CreateModelElement(DXODraw.NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.NonVisualGroupDrawingShapeProperties();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.NonVisualGroupDrawingShapeProperties? value)
    where OpenXmlElementType: DXODraw.NonVisualGroupDrawingShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeLocks(openXmlElement, value?.GroupShapeLocks);
      SetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
