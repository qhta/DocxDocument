using DocumentFormat.OpenXml.Drawing;
using ConnectorLockingExtensionList = DocumentModel.Drawings.ConnectorLockingExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Connection Shape Locks.
/// </summary>
public static class ConnectionShapeLocksConverter
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }

  public static void SetNoGrouping(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoGrouping = null;
  }

  /// <summary>
  ///   Disallow Shape Selection
  /// </summary>
  public static Boolean? GetNoSelection(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }

  public static void SetNoSelection(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoSelection = null;
  }

  /// <summary>
  ///   Disallow Shape Rotation
  /// </summary>
  public static Boolean? GetNoRotation(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }

  public static void SetNoRotation(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoRotation = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoRotation = null;
  }

  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public static Boolean? GetNoChangeAspect(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }

  public static void SetNoChangeAspect(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeAspect = null;
  }

  /// <summary>
  ///   Disallow Shape Movement
  /// </summary>
  public static Boolean? GetNoMove(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }

  public static void SetNoMove(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoMove = null;
  }

  /// <summary>
  ///   Disallow Shape Resize
  /// </summary>
  public static Boolean? GetNoResize(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }

  public static void SetNoResize(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoResize = null;
  }

  /// <summary>
  ///   Disallow Shape Point Editing
  /// </summary>
  public static Boolean? GetNoEditPoints(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }

  public static void SetNoEditPoints(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoEditPoints = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoEditPoints = null;
  }

  /// <summary>
  ///   Disallow Showing Adjust Handles
  /// </summary>
  public static Boolean? GetNoAdjustHandles(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }

  public static void SetNoAdjustHandles(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoAdjustHandles = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoAdjustHandles = null;
  }

  /// <summary>
  ///   Disallow Arrowhead Changes
  /// </summary>
  public static Boolean? GetNoChangeArrowheads(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }

  public static void SetNoChangeArrowheads(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeArrowheads = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeArrowheads = null;
  }

  /// <summary>
  ///   Disallow Shape Type Change
  /// </summary>
  public static Boolean? GetNoChangeShapeType(ConnectionShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }

  public static void SetNoChangeShapeType(ConnectionShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeShapeType = null;
  }

  /// <summary>
  ///   ConnectorLockingExtensionList.
  /// </summary>
  public static ConnectorLockingExtensionList? GetConnectorLockingExtensionList(ConnectionShapeLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList>();
    if (itemElement != null)
      return ConnectorLockingExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConnectorLockingExtensionList(ConnectionShapeLocks? openXmlElement, ConnectorLockingExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectorLockingExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ConnectionShapeLocks? CreateModelElement(ConnectionShapeLocks? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectionShapeLocks? value)
    where OpenXmlElementType : ConnectionShapeLocks, new()
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