namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public static class NonVisualDrawingShapePropertiesConverter
{
  /// <summary>
  /// Text Box
  /// </summary>
  private static Boolean? GetTextBox(DXODraw.NonVisualDrawingShapeProperties openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }
  
  private static void SetTextBox(DXODraw.NonVisualDrawingShapeProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.TextBox = null;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  private static DMDraws.ShapeLocks? GetShapeLocks(DXODraw.NonVisualDrawingShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeLocks>();
    if (itemElement != null)
      return DMXDraws.ShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeLocks(DXODraw.NonVisualDrawingShapeProperties openXmlElement, DMDraws.ShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ShapeLocksConverter.CreateOpenXmlElement<DXDraw.ShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXODraw.NonVisualDrawingShapeProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXODraw.NonVisualDrawingShapeProperties openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDrawsO.NonVisualDrawingShapeProperties? CreateModelElement(DXODraw.NonVisualDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsO.NonVisualDrawingShapeProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.NonVisualDrawingShapeProperties? value)
    where OpenXmlElementType: DXODraw.NonVisualDrawingShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextBox(openXmlElement, value?.TextBox);
      SetShapeLocks(openXmlElement, value?.ShapeLocks);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
