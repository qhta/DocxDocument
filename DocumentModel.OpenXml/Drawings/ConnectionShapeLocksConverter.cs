namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Connection Shape Locks.
/// </summary>
public static class ConnectionShapeLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoGrouping?.Value == value) return true;
    diffs?.Add(objName, "NoGrouping", openXmlElement?.NoGrouping?.Value, value);
    return false;
  }
  
  private static void SetNoGrouping(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoSelection?.Value == value) return true;
    diffs?.Add(objName, "NoSelection", openXmlElement?.NoSelection?.Value, value);
    return false;
  }
  
  private static void SetNoSelection(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  private static Boolean? GetNoRotation(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }
  
  private static bool CmpNoRotation(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoRotation?.Value == value) return true;
    diffs?.Add(objName, "NoRotation", openXmlElement?.NoRotation?.Value, value);
    return false;
  }
  
  private static void SetNoRotation(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoRotation = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoChangeAspect?.Value == value) return true;
    diffs?.Add(objName, "NoChangeAspect", openXmlElement?.NoChangeAspect?.Value, value);
    return false;
  }
  
  private static void SetNoChangeAspect(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoMove?.Value == value) return true;
    diffs?.Add(objName, "NoMove", openXmlElement?.NoMove?.Value, value);
    return false;
  }
  
  private static void SetNoMove(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoResize?.Value == value) return true;
    diffs?.Add(objName, "NoResize", openXmlElement?.NoResize?.Value, value);
    return false;
  }
  
  private static void SetNoResize(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  private static Boolean? GetNoEditPoints(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }
  
  private static bool CmpNoEditPoints(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoEditPoints?.Value == value) return true;
    diffs?.Add(objName, "NoEditPoints", openXmlElement?.NoEditPoints?.Value, value);
    return false;
  }
  
  private static void SetNoEditPoints(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoEditPoints = null;
  }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  private static Boolean? GetNoAdjustHandles(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }
  
  private static bool CmpNoAdjustHandles(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoAdjustHandles?.Value == value) return true;
    diffs?.Add(objName, "NoAdjustHandles", openXmlElement?.NoAdjustHandles?.Value, value);
    return false;
  }
  
  private static void SetNoAdjustHandles(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoAdjustHandles = null;
  }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  private static Boolean? GetNoChangeArrowheads(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }
  
  private static bool CmpNoChangeArrowheads(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoChangeArrowheads?.Value == value) return true;
    diffs?.Add(objName, "NoChangeArrowheads", openXmlElement?.NoChangeArrowheads?.Value, value);
    return false;
  }
  
  private static void SetNoChangeArrowheads(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeArrowheads = null;
  }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  private static Boolean? GetNoChangeShapeType(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }
  
  private static bool CmpNoChangeShapeType(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.NoChangeShapeType?.Value == value) return true;
    diffs?.Add(objName, "NoChangeShapeType", openXmlElement?.NoChangeShapeType?.Value, value);
    return false;
  }
  
  private static void SetNoChangeShapeType(DXDraw.ConnectionShapeLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeShapeType = null;
  }
  
  /// <summary>
  /// ConnectorLockingExtensionList.
  /// </summary>
  private static DMDraws.ConnectorLockingExtensionList? GetConnectorLockingExtensionList(DXDraw.ConnectionShapeLocks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ConnectorLockingExtensionList>();
    if (element != null)
      return DMXDraws.ConnectorLockingExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConnectorLockingExtensionList(DXDraw.ConnectionShapeLocks openXmlElement, DMDraws.ConnectorLockingExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ConnectorLockingExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ConnectorLockingExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConnectorLockingExtensionList(DXDraw.ConnectionShapeLocks openXmlElement, DMDraws.ConnectorLockingExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ConnectorLockingExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ConnectorLockingExtensionListConverter.CreateOpenXmlElement<DXDraw.ConnectorLockingExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ConnectionShapeLocks? CreateModelElement(DXDraw.ConnectionShapeLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionShapeLocks();
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
      value.ConnectorLockingExtensionList = GetConnectorLockingExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ConnectionShapeLocks? openXmlElement, DMDraws.ConnectionShapeLocks? value, DiffList? diffs, string? objName)
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
      if (!CmpConnectorLockingExtensionList(openXmlElement, value.ConnectorLockingExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionShapeLocks value)
    where OpenXmlElementType: DXDraw.ConnectionShapeLocks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ConnectionShapeLocks openXmlElement, DMDraws.ConnectionShapeLocks value)
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
    SetConnectorLockingExtensionList(openXmlElement, value?.ConnectorLockingExtensionList);
    }
  }
