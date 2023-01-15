using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Graphic Frame Locks.
/// </summary>
public static class GraphicFrameLocksConverter
{
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  public static Boolean? GetNoGrouping(GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }

  public static void SetNoGrouping(GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoGrouping = null;
  }

  /// <summary>
  ///   Disallow Selection of Child Shapes
  /// </summary>
  public static Boolean? GetNoDrilldown(GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoDrilldown?.Value;
  }

  public static void SetNoDrilldown(GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoDrilldown = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoDrilldown = null;
  }

  /// <summary>
  ///   Disallow Shape Selection
  /// </summary>
  public static Boolean? GetNoSelection(GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }

  public static void SetNoSelection(GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoSelection = null;
  }

  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public static Boolean? GetNoChangeAspect(GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }

  public static void SetNoChangeAspect(GraphicFrameLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoMove(GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }

  public static void SetNoMove(GraphicFrameLocks? openXmlElement, Boolean? value)
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
  public static Boolean? GetNoResize(GraphicFrameLocks? openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }

  public static void SetNoResize(GraphicFrameLocks? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.NoResize = null;
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(GraphicFrameLocks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(GraphicFrameLocks? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.GraphicFrameLocks? CreateModelElement(GraphicFrameLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.GraphicFrameLocks();
      value.NoGrouping = GetNoGrouping(openXmlElement);
      value.NoDrilldown = GetNoDrilldown(openXmlElement);
      value.NoSelection = GetNoSelection(openXmlElement);
      value.NoChangeAspect = GetNoChangeAspect(openXmlElement);
      value.NoMove = GetNoMove(openXmlElement);
      value.NoResize = GetNoResize(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.GraphicFrameLocks? value)
    where OpenXmlElementType : GraphicFrameLocks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoGrouping(openXmlElement, value?.NoGrouping);
      SetNoDrilldown(openXmlElement, value?.NoDrilldown);
      SetNoSelection(openXmlElement, value?.NoSelection);
      SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
      SetNoMove(openXmlElement, value?.NoMove);
      SetNoResize(openXmlElement, value?.NoResize);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}