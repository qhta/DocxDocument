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
  
  private static bool CmpTextBox(DXODraw.NonVisualDrawingShapeProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TextBox?.Value == value) return true;
    diffs?.Add(objName, "TextBox", openXmlElement?.TextBox?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ShapeLocks>();
    if (element != null)
      return DMXDraws.ShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeLocks(DXODraw.NonVisualDrawingShapeProperties openXmlElement, DMDraws.ShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ShapeLocks>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXODraw.NonVisualDrawingShapeProperties openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? CreateModelElement(DXODraw.NonVisualDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.NonVisualDrawingShapeProperties? openXmlElement, DMDrawsO.NonVisualDrawingShapeProperties? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.NonVisualDrawingShapeProperties value)
    where OpenXmlElementType: DXODraw.NonVisualDrawingShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.NonVisualDrawingShapeProperties openXmlElement, DMDrawsO.NonVisualDrawingShapeProperties value)
  {
    SetTextBox(openXmlElement, value?.TextBox);
    SetShapeLocks(openXmlElement, value?.ShapeLocks);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
