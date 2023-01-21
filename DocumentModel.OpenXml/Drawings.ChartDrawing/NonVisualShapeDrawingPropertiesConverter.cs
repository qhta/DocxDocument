namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Drawing Properties.
/// </summary>
public static class NonVisualShapeDrawingPropertiesConverter
{
  /// <summary>
  /// Text Box
  /// </summary>
  private static Boolean? GetTextBox(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }
  
  private static void SetTextBox(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.TextBox = null;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  private static DMDraws.ShapeLocks? GetShapeLocks(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ShapeLocks>();
    if (itemElement != null)
      return DMXDraws.ShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeLocks(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement, DMDraws.ShapeLocks? value)
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
  private static DMDraws.ExtensionList? GetExtensionList(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraw.NonVisualShapeDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualShapeDrawingProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualShapeDrawingProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualShapeDrawingProperties, new()
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
