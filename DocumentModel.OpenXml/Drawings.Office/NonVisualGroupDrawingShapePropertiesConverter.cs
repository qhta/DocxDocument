namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropertiesConverter
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  private static DMD.GroupShapeLocks? GetGroupShapeLocks(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GroupShapeLocks>();
    if (element != null)
      return DMXD.GroupShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeLocks(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement, DMD.GroupShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXD.GroupShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GroupShapeLocks>(), value, diffs, objName);
  }
  
  private static void SetGroupShapeLocks(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement, DMD.GroupShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GroupShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GroupShapeLocksConverter.CreateOpenXmlElement<DXD.GroupShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  private static DMD.NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>();
    if (element != null)
      return DMXD.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensionList(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.NonVisualGroupDrawingShapePropsExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensionList(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateOpenXmlElement<DXD.NonVisualGroupDrawingShapePropsExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? CreateModelElement(DXOD.NonVisualGroupDrawingShapeProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXOD.NonVisualGroupDrawingShapeProperties? openXmlElement, DMDO.NonVisualGroupDrawingShapeProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.NonVisualGroupDrawingShapeProperties value)
    where OpenXmlElementType: DXOD.NonVisualGroupDrawingShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.NonVisualGroupDrawingShapeProperties openXmlElement, DMDO.NonVisualGroupDrawingShapeProperties value)
  {
    SetGroupShapeLocks(openXmlElement, value?.GroupShapeLocks);
    SetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensionList);
  }
}
