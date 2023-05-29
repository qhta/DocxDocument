namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public static class NonVisualDrawingShapePropertiesConverter
{
  /// <summary>
  /// Text Box
  /// </summary>
  private static Boolean? GetTextBox(DXOD.NonVisualDrawingShapeProperties openXmlElement)
  {
    return openXmlElement?.TextBox?.Value;
  }
  
  private static bool CmpTextBox(DXOD.NonVisualDrawingShapeProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.TextBox?.Value == value) return true;
    diffs?.Add(objName, "TextBox", openXmlElement?.TextBox?.Value, value);
    return false;
  }
  
  private static void SetTextBox(DXOD.NonVisualDrawingShapeProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TextBox = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.TextBox = null;
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  private static DMD.ShapeLocks? GetShapeLocks(DXOD.NonVisualDrawingShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ShapeLocks>();
    if (element != null)
      return DMXD.ShapeLocksConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeLocks(DXOD.NonVisualDrawingShapeProperties openXmlElement, DMD.ShapeLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ShapeLocksConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ShapeLocks>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeLocks(DXOD.NonVisualDrawingShapeProperties openXmlElement, DMD.ShapeLocks? value)
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
  private static DMD.ExtensionList? GetExtensionList(DXOD.NonVisualDrawingShapeProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXOD.NonVisualDrawingShapeProperties openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXOD.NonVisualDrawingShapeProperties openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.NonVisualDrawingShapeProperties? CreateModelElement(DXOD.NonVisualDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.NonVisualDrawingShapeProperties();
      value.TextBox = GetTextBox(openXmlElement);
      value.ShapeLocks = GetShapeLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOD.NonVisualDrawingShapeProperties? openXmlElement, DMDO.NonVisualDrawingShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextBox(openXmlElement, value.TextBox, diffs, objName, propName))
        ok = false;
      if (!CmpShapeLocks(openXmlElement, value.ShapeLocks, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDO.NonVisualDrawingShapeProperties value)
    where OpenXmlElementType: DXOD.NonVisualDrawingShapeProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOD.NonVisualDrawingShapeProperties openXmlElement, DMDO.NonVisualDrawingShapeProperties value)
  {
    SetTextBox(openXmlElement, value?.TextBox);
    SetShapeLocks(openXmlElement, value?.ShapeLocks);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
