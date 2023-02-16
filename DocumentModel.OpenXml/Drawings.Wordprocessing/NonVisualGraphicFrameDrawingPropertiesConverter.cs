namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public static class NonVisualGraphicFrameDrawingPropertiesConverter
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  private static DMDraws.GraphicFrameLocks? GetGraphicFrameLocks(DXDrawW.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.GraphicFrameLocks>();
    if (element != null)
      return DMXDraws.GraphicFrameLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphicFrameLocks(DXDrawW.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.GraphicFrameLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GraphicFrameLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.GraphicFrameLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGraphicFrameLocks(DXDrawW.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.GraphicFrameLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GraphicFrameLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GraphicFrameLocksConverter.CreateOpenXmlElement<DXDraw.GraphicFrameLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawW.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawW.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawW.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties? CreateModelElement(DXDrawW.NonVisualGraphicFrameDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.NonVisualGraphicFrameDrawingProperties();
      value.GraphicFrameLocks = GetGraphicFrameLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.NonVisualGraphicFrameDrawingProperties? openXmlElement, DMDrawsW.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGraphicFrameLocks(openXmlElement, value.GraphicFrameLocks, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.NonVisualGraphicFrameDrawingProperties? value)
    where OpenXmlElementType: DXDrawW.NonVisualGraphicFrameDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGraphicFrameLocks(openXmlElement, value?.GraphicFrameLocks);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
