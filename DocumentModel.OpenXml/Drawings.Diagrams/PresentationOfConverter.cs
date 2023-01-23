namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public static class PresentationOfConverter
{
  /// <summary>
  /// Axis
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.AxisKind>? GetAxis(DXDrawDgms.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis);
  }
  
  private static bool CmpAxis(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<DMDrawsDgms.AxisKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis) == value;
  }
  
  private static void SetAxis(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<DMDrawsDgms.AxisKind>? value)
  {
    if (value != null)
      openXmlElement.Axis = ListValueConverter.CreateListValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(value);
    else
      openXmlElement.Axis = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.ElementKind>? GetPointType(DXDrawDgms.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType);
  }
  
  private static bool CmpPointType(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<DMDrawsDgms.ElementKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType) == value;
  }
  
  private static void SetPointType(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<DMDrawsDgms.ElementKind>? value)
  {
    if (value != null)
      openXmlElement.PointType = ListValueConverter.CreateListValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(value);
    else
      openXmlElement.PointType = null;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  private static DM.ListOf<Boolean>? GetHideLastTrans(DXDrawDgms.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }
  
  private static bool CmpHideLastTrans(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<Boolean>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans) == value;
  }
  
  private static void SetHideLastTrans(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<Boolean>? value)
  {
    if (value != null)
      openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<DX.BooleanValue>(value);
    else
      openXmlElement.HideLastTrans = null;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  private static DM.ListOf<Int32>? GetStart(DXDrawDgms.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static bool CmpStart(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start) == value;
  }
  
  private static void SetStart(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Start = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  private static DM.ListOf<UInt32>? GetCount(DXDrawDgms.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }
  
  private static bool CmpCount(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<UInt32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count) == value;
  }
  
  private static void SetCount(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<UInt32>? value)
  {
    if (value != null)
      openXmlElement.Count = ListValueConverter.CreateListValue<DX.UInt32Value>(value);
    else
      openXmlElement.Count = null;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  private static DM.ListOf<Int32>? GetStep(DXDrawDgms.PresentationOf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }
  
  private static bool CmpStep(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step) == value;
  }
  
  private static void SetStep(DXDrawDgms.PresentationOf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.PresentationOf openXmlElement)
  {
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.PresentationOf openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.PresentationOf openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.PresentationOf? CreateModelElement(DXDrawDgms.PresentationOf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.PresentationOf();
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
  
  public static bool CompareModelElement(DXDrawDgms.PresentationOf? openXmlElement, DMDrawsDgms.PresentationOf? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAxis(openXmlElement, value.Axis, diffs, objName))
        ok = false;
      if (!CmpPointType(openXmlElement, value.PointType, diffs, objName))
        ok = false;
      if (!CmpHideLastTrans(openXmlElement, value.HideLastTrans, diffs, objName))
        ok = false;
      if (!CmpStart(openXmlElement, value.Start, diffs, objName))
        ok = false;
      if (!CmpCount(openXmlElement, value.Count, diffs, objName))
        ok = false;
      if (!CmpStep(openXmlElement, value.Step, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PresentationOf? value)
    where OpenXmlElementType: DXDrawDgms.PresentationOf, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
