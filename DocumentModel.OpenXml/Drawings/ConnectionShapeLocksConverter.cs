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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ConnectorLockingExtensionList>();
    if (itemElement != null)
      return DMXDraws.ConnectorLockingExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.ConnectionShapeLocks? CreateModelElement(DXDraw.ConnectionShapeLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ConnectionShapeLocks();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectionShapeLocks? value)
    where OpenXmlElementType: DXDraw.ConnectionShapeLocks, new()
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
      SetConnectorLockingExtensionList(openXmlElement, value?.ConnectorLockingExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
