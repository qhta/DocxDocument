namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public static class PresentationOfConverter
{
  /// <summary>
  /// Axis
  /// </summary>
  private static DM.ListOf<DMDD.AxisKind>? GetAxis(DXDD.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDD.AxisValues, DMDD.AxisKind>(openXmlElement?.Axis);
  }
  
  private static bool CmpAxis(DXDD.PresentationOf openXmlElement, DM.ListOf<DMDD.AxisKind>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue<DXDD.AxisValues, DMDD.AxisKind>(openXmlElement?.Axis, value, diffs, objName, propName);
  }
  
  private static void SetAxis(DXDD.PresentationOf openXmlElement, DM.ListOf<DMDD.AxisKind>? value)
  {
    if (value != null)
      openXmlElement.Axis = ListValueConverter.CreateListValue<DXDD.AxisValues, DMDD.AxisKind>(value);
    else
      openXmlElement.Axis = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DM.ListOf<DMDD.ElementKind>? GetPointType(DXDD.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDD.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType);
  }
  
  private static bool CmpPointType(DXDD.PresentationOf openXmlElement, DM.ListOf<DMDD.ElementKind>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue<DXDD.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType, value, diffs, objName, propName);
  }
  
  private static void SetPointType(DXDD.PresentationOf openXmlElement, DM.ListOf<DMDD.ElementKind>? value)
  {
    if (value != null)
      openXmlElement.PointType = ListValueConverter.CreateListValue<DXDD.ElementValues, DMDD.ElementKind>(value);
    else
      openXmlElement.PointType = null;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  private static DM.ListOf<Boolean>? GetHideLastTrans(DXDD.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }
  
  private static bool CmpHideLastTrans(DXDD.PresentationOf openXmlElement, DM.ListOf<Boolean>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue(openXmlElement?.HideLastTrans, value, diffs, objName, propName);
  }
  
  private static void SetHideLastTrans(DXDD.PresentationOf openXmlElement, DM.ListOf<Boolean>? value)
  {
    if (value != null)
      openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<DX.BooleanValue>(value);
    else
      openXmlElement.HideLastTrans = null;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  private static DM.ListOf<Int32>? GetStart(DXDD.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static bool CmpStart(DXDD.PresentationOf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Start, value, diffs, objName, propName);
  }
  
  private static void SetStart(DXDD.PresentationOf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Start = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  private static DM.ListOf<UInt32>? GetCount(DXDD.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }
  
  private static bool CmpCount(DXDD.PresentationOf openXmlElement, DM.ListOf<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Count, value, diffs, objName, propName);
  }
  
  private static void SetCount(DXDD.PresentationOf openXmlElement, DM.ListOf<UInt32>? value)
  {
    if (value != null)
      openXmlElement.Count = ListValueConverter.CreateListValue<DX.UInt32Value>(value);
    else
      openXmlElement.Count = null;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  private static DM.ListOf<Int32>? GetStep(DXDD.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }
  
  private static bool CmpStep(DXDD.PresentationOf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Step, value, diffs, objName, propName);
  }
  
  private static void SetStep(DXDD.PresentationOf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDD.ExtensionList? GetExtensionList(DXDD.PresentationOf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.PresentationOf openXmlElement, DMDD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.PresentationOf openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.PresentationOf? CreateModelElement(DXDD.PresentationOf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.PresentationOf();
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.PresentationOf? openXmlElement, DMDD.PresentationOf? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAxis(openXmlElement, value.Axis, diffs, objName, propName))
        ok = false;
      if (!CmpPointType(openXmlElement, value.PointType, diffs, objName, propName))
        ok = false;
      if (!CmpHideLastTrans(openXmlElement, value.HideLastTrans, diffs, objName, propName))
        ok = false;
      if (!CmpStart(openXmlElement, value.Start, diffs, objName, propName))
        ok = false;
      if (!CmpCount(openXmlElement, value.Count, diffs, objName, propName))
        ok = false;
      if (!CmpStep(openXmlElement, value.Step, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.PresentationOf value)
    where OpenXmlElementType: DXDD.PresentationOf, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.PresentationOf openXmlElement, DMDD.PresentationOf value)
  {
    SetAxis(openXmlElement, value?.Axis);
    SetPointType(openXmlElement, value?.PointType);
    SetHideLastTrans(openXmlElement, value?.HideLastTrans);
    SetStart(openXmlElement, value?.Start);
    SetCount(openXmlElement, value?.Count);
    SetStep(openXmlElement, value?.Step);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
