namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Graphic Frame Locks.
/// </summary>
public static class GraphicFrameLocksConverter
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  private static Boolean? GetNoGrouping(DXD.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoGrouping?.Value;
  }
  
  private static bool CmpNoGrouping(DXD.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoGrouping?.Value == value) return true;
    diffs?.Add(objName, "NoGrouping", openXmlElement?.NoGrouping?.Value, value);
    return false;
  }
  
  private static void SetNoGrouping(DXD.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoGrouping = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoGrouping = null;
  }
  
  /// <summary>
  /// Disallow Selection of Child Shapes
  /// </summary>
  private static Boolean? GetNoDrilldown(DXD.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoDrilldown?.Value;
  }
  
  private static bool CmpNoDrilldown(DXD.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoDrilldown?.Value == value) return true;
    diffs?.Add(objName, "NoDrilldown", openXmlElement?.NoDrilldown?.Value, value);
    return false;
  }
  
  private static void SetNoDrilldown(DXD.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoDrilldown = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoDrilldown = null;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  private static Boolean? GetNoSelection(DXD.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoSelection?.Value;
  }
  
  private static bool CmpNoSelection(DXD.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoSelection?.Value == value) return true;
    diffs?.Add(objName, "NoSelection", openXmlElement?.NoSelection?.Value, value);
    return false;
  }
  
  private static void SetNoSelection(DXD.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoSelection = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoSelection = null;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  private static Boolean? GetNoChangeAspect(DXD.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoChangeAspect?.Value;
  }
  
  private static bool CmpNoChangeAspect(DXD.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoChangeAspect?.Value == value) return true;
    diffs?.Add(objName, "NoChangeAspect", openXmlElement?.NoChangeAspect?.Value, value);
    return false;
  }
  
  private static void SetNoChangeAspect(DXD.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoChangeAspect = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoChangeAspect = null;
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  private static Boolean? GetNoMove(DXD.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoMove?.Value;
  }
  
  private static bool CmpNoMove(DXD.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoMove?.Value == value) return true;
    diffs?.Add(objName, "NoMove", openXmlElement?.NoMove?.Value, value);
    return false;
  }
  
  private static void SetNoMove(DXD.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoMove = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoMove = null;
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  private static Boolean? GetNoResize(DXD.GraphicFrameLocks openXmlElement)
  {
    return openXmlElement?.NoResize?.Value;
  }
  
  private static bool CmpNoResize(DXD.GraphicFrameLocks openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.NoResize?.Value == value) return true;
    diffs?.Add(objName, "NoResize", openXmlElement?.NoResize?.Value, value);
    return false;
  }
  
  private static void SetNoResize(DXD.GraphicFrameLocks openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.NoResize = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.GraphicFrameLocks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.GraphicFrameLocks openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXD.GraphicFrameLocks openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.GraphicFrameLocks? CreateModelElement(DXD.GraphicFrameLocks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.GraphicFrameLocks();
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
  
  public static bool CompareModelElement(DXD.GraphicFrameLocks? openXmlElement, DMD.GraphicFrameLocks? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNoGrouping(openXmlElement, value.NoGrouping, diffs, objName, propName))
        ok = false;
      if (!CmpNoDrilldown(openXmlElement, value.NoDrilldown, diffs, objName, propName))
        ok = false;
      if (!CmpNoSelection(openXmlElement, value.NoSelection, diffs, objName, propName))
        ok = false;
      if (!CmpNoChangeAspect(openXmlElement, value.NoChangeAspect, diffs, objName, propName))
        ok = false;
      if (!CmpNoMove(openXmlElement, value.NoMove, diffs, objName, propName))
        ok = false;
      if (!CmpNoResize(openXmlElement, value.NoResize, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.GraphicFrameLocks value)
    where OpenXmlElementType: DXD.GraphicFrameLocks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.GraphicFrameLocks openXmlElement, DMD.GraphicFrameLocks value)
  {
    SetNoGrouping(openXmlElement, value?.NoGrouping);
    SetNoDrilldown(openXmlElement, value?.NoDrilldown);
    SetNoSelection(openXmlElement, value?.NoSelection);
    SetNoChangeAspect(openXmlElement, value?.NoChangeAspect);
    SetNoMove(openXmlElement, value?.NoMove);
    SetNoResize(openXmlElement, value?.NoResize);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
