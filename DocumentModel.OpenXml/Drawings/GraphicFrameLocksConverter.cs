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
  
  private static bool CmpNoGrouping(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoGrouping?.Value == value;
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
  
  private static bool CmpNoDrilldown(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoDrilldown?.Value == value;
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
  
  private static bool CmpNoSelection(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoSelection?.Value == value;
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
  
  private static bool CmpNoChangeAspect(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoChangeAspect?.Value == value;
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
  
  private static bool CmpNoMove(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoMove?.Value == value;
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
  
  private static bool CmpNoResize(DXDraw.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.NoResize?.Value == value;
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
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.GraphicFrameLocks openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.GraphicFrameLocks? openXmlElement, DMDraws.GraphicFrameLocks? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoGrouping(openXmlElement, value.NoGrouping, diffs, objName))
        ok = false;
      if (!CmpNoDrilldown(openXmlElement, value.NoDrilldown, diffs, objName))
        ok = false;
      if (!CmpNoSelection(openXmlElement, value.NoSelection, diffs, objName))
        ok = false;
      if (!CmpNoChangeAspect(openXmlElement, value.NoChangeAspect, diffs, objName))
        ok = false;
      if (!CmpNoMove(openXmlElement, value.NoMove, diffs, objName))
        ok = false;
      if (!CmpNoResize(openXmlElement, value.NoResize, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
