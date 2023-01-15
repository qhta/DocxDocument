using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the PictureLocks Class.
/// </summary>
public static class PictureLocksConverter
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }

  public static void SetNoGrouping(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoSelection(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }

  public static void SetNoSelection(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoRotation(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }

  public static void SetNoRotation(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeAspect(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }

  public static void SetNoChangeAspect(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoMove(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }

  public static void SetNoMove(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoResize(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }

  public static void SetNoResize(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoEditPoints(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }

  public static void SetNoEditPoints(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoAdjustHandles(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }

  public static void SetNoAdjustHandles(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeArrowheads(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }

  public static void SetNoChangeArrowheads(PictureLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeShapeType(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }

  public static void SetNoChangeShapeType(PictureLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeShapeType = null;
  }

  /// <summary>
  ///   Disallow Crop Changes
  /// </summary>
  public static Boolean? GetNoCrop(PictureLocks? openXmlElement)
  {
    return openXmlElement?.NoCrop?.Value;
  }

  public static void SetNoCrop(PictureLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoCrop = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoCrop = null;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(PictureLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(PictureLocks? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.PictureLocks? CreateModelElement(PictureLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PictureLocks();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PictureLocks? value)
    where OpenXmlElementType : PictureLocks, new()
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