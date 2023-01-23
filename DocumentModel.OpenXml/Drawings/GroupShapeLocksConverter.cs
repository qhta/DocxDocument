namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
public static class GroupShapeLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoGrouping?.Value == value;
  }
  
  private static void SetNoGrouping(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Ungrouping
  /// </summary>
  private static Boolean? GetNoUngrouping(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoUngrouping?.Value;
  }
  
  private static bool CmpNoUngrouping(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoUngrouping?.Value == value;
  }
  
  private static void SetNoUngrouping(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoUngrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoUngrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoSelection?.Value == value;
  }
  
  private static void SetNoSelection(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static bool CmpNoRotation(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoRotation?.Value == value;
  }
  
  private static void SetNoRotation(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoChangeAspect?.Value == value;
  }
  
  private static void SetNoChangeAspect(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Moving Shape
  /// </summary>
  private static Boolean? GetNoMove(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoMove?.Value == value;
  }
  
  private static void SetNoMove(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resizing
  /// </summary>
  private static Boolean? GetNoResize(DXDraw.GroupShapeLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXDraw.GroupShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoResize?.Value == value;
  }
  
  private static void SetNoResize(DXDraw.GroupShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.GroupShapeLocks openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.GroupShapeLocks openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.GroupShapeLocks openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.GroupShapeLocks? CreateModelElement(DXDraw.GroupShapeLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.GroupShapeLocks();
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
  
  public static bool CompareModelElement(DXDraw.GroupShapeLocks? openXmlElement, DMDraws.GroupShapeLocks? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoGrouping(openXmlElement, value.NoGrouping, diffs, objName))
        ok = false;
      if (!CmpNoUngrouping(openXmlElement, value.NoUngrouping, diffs, objName))
        ok = false;
      if (!CmpNoSelection(openXmlElement, value.NoSelection, diffs, objName))
        ok = false;
      if (!CmpNoRotation(openXmlElement, value.NoRotation, diffs, objName))
        ok = false;
      if (!CmpNoChangeAspect(openXmlElement, value.NoChangeAspect, diffs, objName))
        ok = false;
      if (!CmpNoMove(openXmlElement, value.NoMove, diffs, objName))
        ok = false;
      if (!CmpNoResize(openXmlElement, value.NoResize, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GroupShapeLocks? value)
    where OpenXmlElementType: DXDraw.GroupShapeLocks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoGrouping(openXmlElement, value?.NoGrouping);
      SetNoUngrouping(openXmlElement, value?.NoUngrouping);
      SetNoSelection(openXmlElement, value?.NoSelection);
      SetNoRotation(openXmlElement, value?.NoRotation);
      SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
      SetNoMove(openXmlElement, value?.NoMove);
      SetNoResize(openXmlElement, value?.NoResize);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
