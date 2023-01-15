using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Shape Locks.
/// </summary>
public static class ShapeLocksConverter
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }

  public static void SetNoGrouping(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoSelection(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }

  public static void SetNoSelection(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoRotation(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }

  public static void SetNoRotation(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeAspect(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }

  public static void SetNoChangeAspect(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoMove(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }

  public static void SetNoMove(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoResize(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }

  public static void SetNoResize(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoEditPoints(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }

  public static void SetNoEditPoints(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoAdjustHandles(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }

  public static void SetNoAdjustHandles(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeArrowheads(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }

  public static void SetNoChangeArrowheads(ShapeLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeShapeType(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }

  public static void SetNoChangeShapeType(ShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeShapeType = null;
  }

  /// <summary>
  ///   Disallow Shape Text Editing
  /// </summary>
  public static Boolean? GetNoTextEdit(ShapeLocks? openXmlElement)
  {
    return openXmlElement?.NoTextEdit?.Value;
  }

  public static void SetNoTextEdit(ShapeLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoTextEdit = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoTextEdit = null;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(ShapeLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ShapeLocks? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ShapeLocks? CreateModelElement(ShapeLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeLocks();
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
      value.NoTextEdit = GetNoTextEdit(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapeLocks? value)
    where OpenXmlElementType : ShapeLocks, new()
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
      SetNoTextEdit(openXmlElement, value?.NoTextEdit);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}