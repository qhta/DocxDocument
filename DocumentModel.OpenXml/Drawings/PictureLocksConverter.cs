namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PictureLocks Class.
/// </summary>
public static class PictureLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoGrouping?.Value == value;
  }
  
  private static void SetNoGrouping(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoSelection?.Value == value;
  }
  
  private static void SetNoSelection(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static bool CmpNoRotation(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoRotation?.Value == value;
  }
  
  private static void SetNoRotation(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoChangeAspect?.Value == value;
  }
  
  private static void SetNoChangeAspect(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoMove?.Value == value;
  }
  
  private static void SetNoMove(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoResize?.Value == value;
  }
  
  private static void SetNoResize(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  private static Boolean? GetNoEditPoints(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }
  
  private static bool CmpNoEditPoints(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoEditPoints?.Value == value;
  }
  
  private static void SetNoEditPoints(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoEditPoints = null;
  }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  private static Boolean? GetNoAdjustHandles(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }
  
  private static bool CmpNoAdjustHandles(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoAdjustHandles?.Value == value;
  }
  
  private static void SetNoAdjustHandles(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoAdjustHandles = null;
  }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  private static Boolean? GetNoChangeArrowheads(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }
  
  private static bool CmpNoChangeArrowheads(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoChangeArrowheads?.Value == value;
  }
  
  private static void SetNoChangeArrowheads(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeArrowheads = null;
  }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  private static Boolean? GetNoChangeShapeType(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }
  
  private static bool CmpNoChangeShapeType(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoChangeShapeType?.Value == value;
  }
  
  private static void SetNoChangeShapeType(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeShapeType = null;
  }
  
  /// <summary>
  /// Disallow Crop Changes
  /// </summary>
  private static Boolean? GetNoCrop(DXDraw.PictureLocks openXmlElement)
  {
    return openXmlElement?.NoCrop?.Value;
  }
  
  private static bool CmpNoCrop(DXDraw.PictureLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoCrop?.Value == value;
  }
  
  private static void SetNoCrop(DXDraw.PictureLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoCrop = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoCrop = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.PictureLocks openXmlElement)
  {
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.PictureLocks openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.PictureLocks openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.PictureLocks? CreateModelElement(DXDraw.PictureLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PictureLocks();
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
  
  public static bool CompareModelElement(DXDraw.PictureLocks? openXmlElement, DMDraws.PictureLocks? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoGrouping(openXmlElement, value.NoGrouping, diffs, objName))
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
      if (!CmpNoEditPoints(openXmlElement, value.NoEditPoints, diffs, objName))
        ok = false;
      if (!CmpNoAdjustHandles(openXmlElement, value.NoAdjustHandles, diffs, objName))
        ok = false;
      if (!CmpNoChangeArrowheads(openXmlElement, value.NoChangeArrowheads, diffs, objName))
        ok = false;
      if (!CmpNoChangeShapeType(openXmlElement, value.NoChangeShapeType, diffs, objName))
        ok = false;
      if (!CmpNoCrop(openXmlElement, value.NoCrop, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PictureLocks? value)
    where OpenXmlElementType: DXDraw.PictureLocks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
