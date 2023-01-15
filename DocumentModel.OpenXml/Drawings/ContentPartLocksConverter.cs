using DocumentModel.Drawings;
using ContentPartLocks = DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ContentPartLocks Class.
/// </summary>
public static class ContentPartLocksConverter
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }

  public static void SetNoGrouping(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoSelection(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }

  public static void SetNoSelection(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoRotation(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoRotation?.Value;
  }

  public static void SetNoRotation(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeAspect(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }

  public static void SetNoChangeAspect(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoMove(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }

  public static void SetNoMove(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoResize(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }

  public static void SetNoResize(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoEditPoints(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoEditPoints?.Value;
  }

  public static void SetNoEditPoints(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoAdjustHandles(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoAdjustHandles?.Value;
  }

  public static void SetNoAdjustHandles(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeArrowheads(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeArrowheads?.Value;
  }

  public static void SetNoChangeArrowheads(ContentPartLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoChangeShapeType(ContentPartLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeShapeType?.Value;
  }

  public static void SetNoChangeShapeType(ContentPartLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoChangeShapeType = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoChangeShapeType = null;
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static OfficeArtExtensionList2? GetOfficeArtExtensionList(ContentPartLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionList2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(ContentPartLocks? openXmlElement, OfficeArtExtensionList2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionList2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ContentPartLocks? CreateModelElement(ContentPartLocks? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ContentPartLocks? value)
    where OpenXmlElementType : ContentPartLocks, new()
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
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}