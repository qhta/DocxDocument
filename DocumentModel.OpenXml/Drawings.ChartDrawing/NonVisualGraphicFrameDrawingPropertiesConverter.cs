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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GraphicFrameLocks>();
    if (itemElement != null)
      return DMXDraws.GraphicFrameLocksConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
