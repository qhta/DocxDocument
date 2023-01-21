namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Frame Locks.
/// </summary>
public static class GraphicFrameLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXDraw.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static void SetNoGrouping(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Selection of Child Shapes
  /// </summary>
  private static Boolean? GetNoDrilldown(DXDraw.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoDrilldown?.Value;
  }
  
  private static void SetNoDrilldown(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoDrilldown = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoDrilldown = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXDraw.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static void SetNoSelection(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXDraw.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static void SetNoChangeAspect(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DXDraw.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static void SetNoMove(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DXDraw.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static void SetNoResize(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.GraphicFrameLocks openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.GraphicFrameLocks openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.GraphicFrameLocks? CreateModelElement(DXDraw.GraphicFrameLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.GraphicFrameLocks();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GraphicFrameLocks? value)
    where OpenXmlElementType: DXDraw.GraphicFrameLocks, new()
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
