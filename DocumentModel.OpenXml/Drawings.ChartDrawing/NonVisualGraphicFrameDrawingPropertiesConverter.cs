namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public static class NonVisualGraphicFrameDrawingPropertiesConverter
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  private static DMD.GraphicFrameLocks? GetGraphicFrameLocks(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GraphicFrameLocks>();
    if (element != null)
      return DMXD.GraphicFrameLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrameLocks(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement, DMD.GraphicFrameLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GraphicFrameLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GraphicFrameLocks>(), value, diffs, objName, propName);
  }
  
  private static void SetGraphicFrameLocks(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement, DMD.GraphicFrameLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GraphicFrameLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GraphicFrameLocksConverter.CreateOpenXmlElement<DXD.GraphicFrameLocks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.NonVisualGraphicFrameDrawingProperties? CreateModelElement(DXDCD.NonVisualGraphicFrameDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.NonVisualGraphicFrameDrawingProperties();
      value.GraphicFrameLocks = GetGraphicFrameLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualGraphicFrameDrawingProperties? openXmlElement, DMDCD.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGraphicFrameLocks(openXmlElement, value.GraphicFrameLocks, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualGraphicFrameDrawingProperties value)
    where OpenXmlElementType: DXDCD.NonVisualGraphicFrameDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDCD.NonVisualGraphicFrameDrawingProperties value)
  {
    SetGraphicFrameLocks(openXmlElement, value?.GraphicFrameLocks);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
