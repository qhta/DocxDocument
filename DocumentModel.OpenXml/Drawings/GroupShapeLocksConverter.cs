namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
public static class GroupShapeLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoGrouping?.Value == value) return true;
    diffs?.Add(objName, "NoGrouping", openXmlElement?.NoGrouping?.Value, value);
    return false;
  }
  
  private static void SetNoGrouping(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Ungrouping
  /// </summary>
  private static Boolean? GetNoUngrouping(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoUngrouping?.Value;
  }
  
  private static bool CmpNoUngrouping(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoUngrouping?.Value == value) return true;
    diffs?.Add(objName, "NoUngrouping", openXmlElement?.NoUngrouping?.Value, value);
    return false;
  }
  
  private static void SetNoUngrouping(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoUngrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoUngrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoSelection?.Value == value) return true;
    diffs?.Add(objName, "NoSelection", openXmlElement?.NoSelection?.Value, value);
    return false;
  }
  
  private static void SetNoSelection(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static bool CmpNoRotation(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoRotation?.Value == value) return true;
    diffs?.Add(objName, "NoRotation", openXmlElement?.NoRotation?.Value, value);
    return false;
  }
  
  private static void SetNoRotation(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoChangeAspect?.Value == value) return true;
    diffs?.Add(objName, "NoChangeAspect", openXmlElement?.NoChangeAspect?.Value, value);
    return false;
  }
  
  private static void SetNoChangeAspect(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Moving Shape
  /// </summary>
  private static Boolean? GetNoMove(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoMove?.Value == value) return true;
    diffs?.Add(objName, "NoMove", openXmlElement?.NoMove?.Value, value);
    return false;
  }
  
  private static void SetNoMove(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resizing
  /// </summary>
  private static Boolean? GetNoResize(DXD.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXD.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoResize?.Value == value) return true;
    diffs?.Add(objName, "NoResize", openXmlElement?.NoResize?.Value, value);
    return false;
  }
  
  private static void SetNoResize(DXD.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.GroupShapeLocks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.GroupShapeLocks openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.GroupShapeLocks openXmlElement, DMD.ExtensionList? value)
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
  
  public static DMD.GroupShapeLocks? CreateModelElement(DXD.GroupShapeLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.GroupShapeLocks();
      value.NoGrouping = GetNoGrouping(openXmlElement);
      value.NoUngrouping = GetNoUngrouping(openXmlElement);
      value.NoSelection = GetNoSelection(openXmlElement);
      value.NoRotation = GetNoRotation(openXmlElement);
      value.NoChangeAspect = GetNoChangeAspect(openXmlElement);
      value.NoMove = GetNoMove(openXmlElement);
      value.NoResize = GetNoResize(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.GroupShapeLocks? openXmlElement, DMD.GroupShapeLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoGrouping(openXmlElement, value.NoGrouping, diffs, objName, propName))
        ok = false;
      if (!CmpNoUngrouping(openXmlElement, value.NoUngrouping, diffs, objName, propName))
        ok = false;
      if (!CmpNoSelection(openXmlElement, value.NoSelection, diffs, objName, propName))
        ok = false;
      if (!CmpNoRotation(openXmlElement, value.NoRotation, diffs, objName, propName))
        ok = false;
      if (!CmpNoChangeAspect(openXmlElement, value.NoChangeAspect, diffs, objName, propName))
        ok = false;
      if (!CmpNoMove(openXmlElement, value.NoMove, diffs, objName, propName))
        ok = false;
      if (!CmpNoResize(openXmlElement, value.NoResize, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.GroupShapeLocks value)
    where OpenXmlElementType: DXD.GroupShapeLocks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.GroupShapeLocks openXmlElement, DMD.GroupShapeLocks value)
  {
    SetNoGrouping(openXmlElement, value?.NoGrouping);
    SetNoUngrouping(openXmlElement, value?.NoUngrouping);
    SetNoSelection(openXmlElement, value?.NoSelection);
    SetNoRotation(openXmlElement, value?.NoRotation);
    SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
    SetNoMove(openXmlElement, value?.NoMove);
    SetNoResize(openXmlElement, value?.NoResize);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
