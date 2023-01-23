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
  
  private static bool CmpTextBox(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.TextBox?.Value == value;
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
    return DMXDraws.ShapeLocksConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeLocks>());
  }
  
  private static bool CmpShapeLocks(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement, DMDraws.ShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeLocksConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ShapeLocks>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawChartDraw.NonVisualShapeDrawingProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawChartDraw.NonVisualShapeDrawingProperties? openXmlElement, DMDrawsChartDraw.NonVisualShapeDrawingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextBox(openXmlElement, value.TextBox, diffs, objName))
        ok = false;
      if (!CmpShapeLocks(openXmlElement, value.ShapeLocks, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
