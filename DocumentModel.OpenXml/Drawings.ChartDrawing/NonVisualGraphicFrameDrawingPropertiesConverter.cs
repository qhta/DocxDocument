namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public static class NonVisualGraphicFrameDrawingPropertiesConverter
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  private static DMDraws.GraphicFrameLocks? GetGraphicFrameLocks(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    return DMXDraws.GraphicFrameLocksConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.GraphicFrameLocks>());
  }
  
  private static bool CmpGraphicFrameLocks(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.GraphicFrameLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GraphicFrameLocksConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.GraphicFrameLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGraphicFrameLocks(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.GraphicFrameLocks? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties();
      value.GraphicFrameLocks = GetGraphicFrameLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties? openXmlElement, DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualGraphicFrameDrawingProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualGraphicFrameDrawingProperties, new()
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
