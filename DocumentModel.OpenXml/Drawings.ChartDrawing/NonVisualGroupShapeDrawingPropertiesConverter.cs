namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public static class NonVisualGroupShapeDrawingPropertiesConverter
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  private static DMD.GroupShapeLocks? GetGroupShapeLocks(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GroupShapeLocks>();
    if (element != null)
      return DMXD.GroupShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupShapeLocks(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement, DMD.GroupShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXD.GroupShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GroupShapeLocks>(), value, diffs, objName);
  }
  
  private static void SetGroupShapeLocks(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement, DMD.GroupShapeLocks? value)
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
  private static DMD.NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>();
    if (element != null)
      return DMXD.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNonVisualGroupDrawingShapePropsExtensionList(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.NonVisualGroupDrawingShapePropsExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.NonVisualGroupDrawingShapePropsExtensionList>(), value, diffs, objName);
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensionList(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement, DMD.NonVisualGroupDrawingShapePropsExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties? CreateModelElement(DXDCD.NonVisualGroupShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties();
      value.GroupShapeLocks = GetGroupShapeLocks(openXmlElement);
      value.NonVisualGroupDrawingShapePropsExtensionList = GetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualGroupShapeDrawingProperties? openXmlElement, DMDCD.NonVisualGroupShapeDrawingProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualGroupShapeDrawingProperties value)
    where OpenXmlElementType: DXDCD.NonVisualGroupShapeDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement, DMDCD.NonVisualGroupShapeDrawingProperties value)
  {
    SetGroupShapeLocks(openXmlElement, value?.GroupShapeLocks);
    SetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensionList);
  }
}
