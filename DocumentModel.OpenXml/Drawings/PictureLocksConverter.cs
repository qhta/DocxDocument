namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PictureLocks Class.
/// </summary>
public static class PictureLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoGrouping?.Value == value) return true;
    diffs?.Add(objName, "NoGrouping", openXmlElement?.NoGrouping?.Value, value);
    return false;
  }
  
  private static void SetNoGrouping(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoSelection?.Value == value) return true;
    diffs?.Add(objName, "NoSelection", openXmlElement?.NoSelection?.Value, value);
    return false;
  }
  
  private static void SetNoSelection(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static bool CmpNoRotation(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoRotation?.Value == value) return true;
    diffs?.Add(objName, "NoRotation", openXmlElement?.NoRotation?.Value, value);
    return false;
  }
  
  private static void SetNoRotation(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoChangeAspect?.Value == value) return true;
    diffs?.Add(objName, "NoChangeAspect", openXmlElement?.NoChangeAspect?.Value, value);
    return false;
  }
  
  private static void SetNoChangeAspect(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoMove?.Value == value) return true;
    diffs?.Add(objName, "NoMove", openXmlElement?.NoMove?.Value, value);
    return false;
  }
  
  private static void SetNoMove(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoResize?.Value == value) return true;
    diffs?.Add(objName, "NoResize", openXmlElement?.NoResize?.Value, value);
    return false;
  }
  
  private static void SetNoResize(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  private static Boolean? GetNoEditPoints(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }
  
  private static bool CmpNoEditPoints(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoEditPoints?.Value == value) return true;
    diffs?.Add(objName, "NoEditPoints", openXmlElement?.NoEditPoints?.Value, value);
    return false;
  }
  
  private static void SetNoEditPoints(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoEditPoints = null;
  }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  private static Boolean? GetNoAdjustHandles(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }
  
  private static bool CmpNoAdjustHandles(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoAdjustHandles?.Value == value) return true;
    diffs?.Add(objName, "NoAdjustHandles", openXmlElement?.NoAdjustHandles?.Value, value);
    return false;
  }
  
  private static void SetNoAdjustHandles(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoAdjustHandles = null;
  }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  private static Boolean? GetNoChangeArrowheads(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }
  
  private static bool CmpNoChangeArrowheads(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoChangeArrowheads?.Value == value) return true;
    diffs?.Add(objName, "NoChangeArrowheads", openXmlElement?.NoChangeArrowheads?.Value, value);
    return false;
  }
  
  private static void SetNoChangeArrowheads(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeArrowheads = null;
  }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  private static Boolean? GetNoChangeShapeType(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }
  
  private static bool CmpNoChangeShapeType(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoChangeShapeType?.Value == value) return true;
    diffs?.Add(objName, "NoChangeShapeType", openXmlElement?.NoChangeShapeType?.Value, value);
    return false;
  }
  
  private static void SetNoChangeShapeType(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeShapeType = null;
  }
  
  /// <summary>
  /// Disallow Crop Changes
  /// </summary>
  private static Boolean? GetNoCrop(DXD.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoCrop?.Value;
  }
  
  private static bool CmpNoCrop(DXD.PictureLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoCrop?.Value == value) return true;
    diffs?.Add(objName, "NoCrop", openXmlElement?.NoCrop?.Value, value);
    return false;
  }
  
  private static void SetNoCrop(DXD.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoCrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoCrop = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.PictureLocks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.PictureLocks openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.PictureLocks openXmlElement, DMD.ExtensionList? value)
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
  
  public static DMD.PictureLocks? CreateModelElement(DXD.PictureLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.PictureLocks();
      value.NoGrouping = GetNoGrouping(openXmlElement);
      value.NoSelection = GetNoSelection(openXmlElement);
      value.NoRotation = GetNoRotation(openXmlElement);
      value.NoChangeAspect = GetNoChangeAspect(openXmlElement);
      value.NoMove = GetNoMove(openXmlElement);
      value.NoResize = GetNoResize(openXmlElement);
      value.NoEditPoints = GetNoEditPoints(openXmlElement);
      value.NoAdjustHandles = GetNoAdjustHandles(openXmlElement);
      value.NoChangeArrowheads = GetNoChangeArrowheads(openXmlElement);
      value.NoChangeShapeType = GetNoChangeShapeType(openXmlElement);
      value.NoCrop = GetNoCrop(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.PictureLocks? openXmlElement, DMD.PictureLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoGrouping(openXmlElement, value.NoGrouping, diffs, objName, propName))
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
      if (!CmpNoEditPoints(openXmlElement, value.NoEditPoints, diffs, objName, propName))
        ok = false;
      if (!CmpNoAdjustHandles(openXmlElement, value.NoAdjustHandles, diffs, objName, propName))
        ok = false;
      if (!CmpNoChangeArrowheads(openXmlElement, value.NoChangeArrowheads, diffs, objName, propName))
        ok = false;
      if (!CmpNoChangeShapeType(openXmlElement, value.NoChangeShapeType, diffs, objName, propName))
        ok = false;
      if (!CmpNoCrop(openXmlElement, value.NoCrop, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PictureLocks value)
    where OpenXmlElementType: DXD.PictureLocks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.PictureLocks openXmlElement, DMD.PictureLocks value)
  {
    SetNoGrouping(openXmlElement, value?.NoGrouping);
    SetNoSelection(openXmlElement, value?.NoSelection);
    SetNoRotation(openXmlElement, value?.NoRotation);
    SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
    SetNoMove(openXmlElement, value?.NoMove);
    SetNoResize(openXmlElement, value?.NoResize);
    SetNoEditPoints(openXmlElement, value?.NoEditPoints);
    SetNoAdjustHandles(openXmlElement, value?.NoAdjustHandles);
    SetNoChangeArrowheads(openXmlElement, value?.NoChangeArrowheads);
    SetNoChangeShapeType(openXmlElement, value?.NoChangeShapeType);
    SetNoCrop(openXmlElement, value?.NoCrop);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
