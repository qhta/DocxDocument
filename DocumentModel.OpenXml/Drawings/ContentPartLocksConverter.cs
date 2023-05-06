namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ContentPartLocks Class.
/// </summary>
public static class ContentPartLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoGrouping?.Value == value) return true;
    diffs?.Add(objName, "NoGrouping", openXmlElement?.NoGrouping?.Value, value);
    return false;
  }
  
  private static void SetNoGrouping(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoSelection?.Value == value) return true;
    diffs?.Add(objName, "NoSelection", openXmlElement?.NoSelection?.Value, value);
    return false;
  }
  
  private static void SetNoSelection(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static bool CmpNoRotation(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoRotation?.Value == value) return true;
    diffs?.Add(objName, "NoRotation", openXmlElement?.NoRotation?.Value, value);
    return false;
  }
  
  private static void SetNoRotation(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoChangeAspect?.Value == value) return true;
    diffs?.Add(objName, "NoChangeAspect", openXmlElement?.NoChangeAspect?.Value, value);
    return false;
  }
  
  private static void SetNoChangeAspect(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoMove?.Value == value) return true;
    diffs?.Add(objName, "NoMove", openXmlElement?.NoMove?.Value, value);
    return false;
  }
  
  private static void SetNoMove(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoResize?.Value == value) return true;
    diffs?.Add(objName, "NoResize", openXmlElement?.NoResize?.Value, value);
    return false;
  }
  
  private static void SetNoResize(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  private static Boolean? GetNoEditPoints(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }
  
  private static bool CmpNoEditPoints(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoEditPoints?.Value == value) return true;
    diffs?.Add(objName, "NoEditPoints", openXmlElement?.NoEditPoints?.Value, value);
    return false;
  }
  
  private static void SetNoEditPoints(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoEditPoints = null;
  }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  private static Boolean? GetNoAdjustHandles(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }
  
  private static bool CmpNoAdjustHandles(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoAdjustHandles?.Value == value) return true;
    diffs?.Add(objName, "NoAdjustHandles", openXmlElement?.NoAdjustHandles?.Value, value);
    return false;
  }
  
  private static void SetNoAdjustHandles(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoAdjustHandles = null;
  }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  private static Boolean? GetNoChangeArrowheads(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }
  
  private static bool CmpNoChangeArrowheads(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoChangeArrowheads?.Value == value) return true;
    diffs?.Add(objName, "NoChangeArrowheads", openXmlElement?.NoChangeArrowheads?.Value, value);
    return false;
  }
  
  private static void SetNoChangeArrowheads(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeArrowheads = null;
  }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  private static Boolean? GetNoChangeShapeType(DXO10D.ContentPartLocks openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }
  
  private static bool CmpNoChangeShapeType(DXO10D.ContentPartLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoChangeShapeType?.Value == value) return true;
    diffs?.Add(objName, "NoChangeShapeType", openXmlElement?.NoChangeShapeType?.Value, value);
    return false;
  }
  
  private static void SetNoChangeShapeType(DXO10D.ContentPartLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeShapeType = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMD.OfficeArtExtensionList2? GetOfficeArtExtensionList(DXO10D.ContentPartLocks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.OfficeArtExtensionList>();
    if (element != null)
      return DMXD.OfficeArtExtensionList2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO10D.ContentPartLocks openXmlElement, DMD.OfficeArtExtensionList2? value, DiffList? diffs, string? objName)
  {
    return DMXD.OfficeArtExtensionList2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO10D.ContentPartLocks openXmlElement, DMD.OfficeArtExtensionList2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OfficeArtExtensionList2Converter.CreateOpenXmlElement<DXO10D.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ContentPartLocks? CreateModelElement(DXO10D.ContentPartLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ContentPartLocks();
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
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10D.ContentPartLocks? openXmlElement, DMD.ContentPartLocks? value, DiffList? diffs, string? objName)
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
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ContentPartLocks value)
    where OpenXmlElementType: DXO10D.ContentPartLocks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10D.ContentPartLocks openXmlElement, DMD.ContentPartLocks value)
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
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
