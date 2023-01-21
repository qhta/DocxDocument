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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GroupShapeLocks>();
    if (itemElement != null)
      return DMXDraws.GroupShapeLocksConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      return DMXDraws.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
