namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public static class NonVisualGroupShapeDrawingPropertiesConverter
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  private static DMDraws.GroupShapeLocks? GetGroupShapeLocks(DXDrawChartDraw.NonVisualGroupShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GroupShapeLocks>();
    if (itemElement != null)
      return DMXDraws.GroupShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeLocks(DXDrawChartDraw.NonVisualGroupShapeDrawingProperties openXmlElement, DMDraws.GroupShapeLocks? value)
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
  private static DMDraws.NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(DXDrawChartDraw.NonVisualGroupShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      return DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensionList(DXDrawChartDraw.NonVisualGroupShapeDrawingProperties openXmlElement, DMDraws.NonVisualGroupDrawingShapePropsExtensionList? value)
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
  
  public static DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualGroupShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties();
      value.GroupShapeLocks = GetGroupShapeLocks(openXmlElement);
      value.NonVisualGroupDrawingShapePropsExtensionList = GetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualGroupShapeDrawingProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualGroupShapeDrawingProperties, new()
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
