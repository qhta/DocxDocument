namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Drawing Properties.
/// </summary>
public static class NonVisualShapeDrawingPropertiesConverter
{
  /// <summary>
  /// Text Box
  /// </summary>
  private static Boolean? GetTextBox(DXDCD.NonVisualShapeDrawingProperties openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }
  
  private static bool CmpTextBox(DXDCD.NonVisualShapeDrawingProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.TextBox?.Value == value) return true;
    diffs?.Add(objName, "TextBox", openXmlElement?.TextBox?.Value, value);
    return false;
  }
  
  private static void SetTextBox(DXDCD.NonVisualShapeDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.TextBox = null;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  private static DMD.ShapeLocks? GetShapeLocks(DXDCD.NonVisualShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeLocks>();
    if (element != null)
      return DMXD.ShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeLocks(DXDCD.NonVisualShapeDrawingProperties openXmlElement, DMD.ShapeLocks? value, DiffList? diffs, string? objName)
  {
    return DMXD.ShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeLocks>(), value, diffs, objName);
  }
  
  private static void SetShapeLocks(DXDCD.NonVisualShapeDrawingProperties openXmlElement, DMD.ShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ShapeLocksConverter.CreateOpenXmlElement<DXD.ShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXDCD.NonVisualShapeDrawingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDCD.NonVisualShapeDrawingProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDCD.NonVisualShapeDrawingProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties? CreateModelElement(DXDCD.NonVisualShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualShapeDrawingProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.NonVisualShapeDrawingProperties? openXmlElement, DMDCD.NonVisualShapeDrawingProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.NonVisualShapeDrawingProperties value)
    where OpenXmlElementType: DXDCD.NonVisualShapeDrawingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.NonVisualShapeDrawingProperties openXmlElement, DMDCD.NonVisualShapeDrawingProperties value)
  {
    SetTextBox(openXmlElement, value?.TextBox);
    SetShapeLocks(openXmlElement, value?.ShapeLocks);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
