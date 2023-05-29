namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// For Each.
/// </summary>
public static class ForEachConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.ForEach openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDrawDgms.ForEach openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDrawDgms.ForEach openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  private static String? GetReference(DXDrawDgms.ForEach openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Reference);
  }
  
  private static bool CmpReference(DXDrawDgms.ForEach openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Reference, value, diffs, objName, "Reference");
  }
  
  private static void SetReference(DXDrawDgms.ForEach openXmlElement, String? value)
  {
    openXmlElement.Reference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.AxisKind>? GetAxis(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis);
  }
  
  private static bool CmpAxis(DXDrawDgms.ForEach openXmlElement, DM.ListOf<DMDrawsDgms.AxisKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis, value, diffs, objName);
  }
  
  private static void SetAxis(DXDrawDgms.ForEach openXmlElement, DM.ListOf<DMDrawsDgms.AxisKind>? value)
  {
    if (value != null)
      openXmlElement.Axis = ListValueConverter.CreateListValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(value);
    else
      openXmlElement.Axis = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.ElementKind>? GetPointType(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType);
  }
  
  private static bool CmpPointType(DXDrawDgms.ForEach openXmlElement, DM.ListOf<DMDrawsDgms.ElementKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType, value, diffs, objName);
  }
  
  private static void SetPointType(DXDrawDgms.ForEach openXmlElement, DM.ListOf<DMDrawsDgms.ElementKind>? value)
  {
    if (value != null)
      openXmlElement.PointType = ListValueConverter.CreateListValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(value);
    else
      openXmlElement.PointType = null;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  private static DM.ListOf<Boolean>? GetHideLastTrans(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }
  
  private static bool CmpHideLastTrans(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Boolean>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.HideLastTrans, value, diffs, objName);
  }
  
  private static void SetHideLastTrans(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Boolean>? value)
  {
    if (value != null)
      openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<DX.BooleanValue>(value);
    else
      openXmlElement.HideLastTrans = null;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  private static DM.ListOf<Int32>? GetStart(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static bool CmpStart(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Start, value, diffs, objName);
  }
  
  private static void SetStart(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Start = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  private static DM.ListOf<UInt32>? GetCount(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }
  
  private static bool CmpCount(DXDrawDgms.ForEach openXmlElement, DM.ListOf<UInt32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Count, value, diffs, objName);
  }
  
  private static void SetCount(DXDrawDgms.ForEach openXmlElement, DM.ListOf<UInt32>? value)
  {
    if (value != null)
      openXmlElement.Count = ListValueConverter.CreateListValue<DX.UInt32Value>(value);
    else
      openXmlElement.Count = null;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  private static DM.ListOf<Int32>? GetStep(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }
  
  private static bool CmpStep(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Step, value, diffs, objName);
  }
  
  private static void SetStep(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>();
    if (element != null)
      return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlgorithm(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.AlgorithmConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Algorithm>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlgorithm(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Algorithm? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Algorithm>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.AlgorithmConverter.CreateOpenXmlElement<DXDrawDgms.Algorithm>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.Shape? GetShape(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.Shape>();
    if (element != null)
      return DMXDrawsDgms.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ShapeConverter.CreateOpenXmlElement<DXDrawDgms.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.PresentationOf? GetPresentationOf(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>();
    if (element != null)
      return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresentationOf(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PresentationOfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PresentationOf>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresentationOf(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.PresentationOf? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.PresentationOf>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.PresentationOfConverter.CreateOpenXmlElement<DXDrawDgms.PresentationOf>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.Constraints? GetConstraints(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>();
    if (element != null)
      return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConstraints(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ConstraintsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Constraints>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConstraints(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Constraints? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Constraints>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ConstraintsConverter.CreateOpenXmlElement<DXDrawDgms.Constraints>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.RuleList? GetRuleList(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>();
    if (element != null)
      return DMXDrawsDgms.RuleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRuleList(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.RuleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.RuleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRuleList(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.RuleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.RuleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.RuleListConverter.CreateOpenXmlElement<DXDrawDgms.RuleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.ForEach? GetChildForEach(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>();
    if (element != null)
      return DMXDrawsDgms.ForEachConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildForEach(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ForEachConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ForEach>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildForEach(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.ForEach? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ForEach>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ForEachConverter.CreateOpenXmlElement<DXDrawDgms.ForEach>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.LayoutNode? GetLayoutNode(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (element != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayoutNode(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.LayoutNode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutNode(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.LayoutNode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.LayoutNodeConverter.CreateOpenXmlElement<DXDrawDgms.LayoutNode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.Choose? GetChoose(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.Choose>();
    if (element != null)
      return DMXDrawsDgms.ChooseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChoose(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ChooseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Choose>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChoose(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.Choose? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Choose>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ChooseConverter.CreateOpenXmlElement<DXDrawDgms.Choose>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.ForEach openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.ForEach? CreateModelElement(DXDrawDgms.ForEach? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ForEach();
      value.Name = GetName(openXmlElement);
      value.Reference = GetReference(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.ChildForEach = GetChildForEach(openXmlElement);
      value.LayoutNode = GetLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.ForEach? openXmlElement, DMDrawsDgms.ForEach? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpReference(openXmlElement, value.Reference, diffs, objName))
        ok = false;
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
      if (!CmpAlgorithm(openXmlElement, value.Algorithm, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpPresentationOf(openXmlElement, value.PresentationOf, diffs, objName))
        ok = false;
      if (!CmpConstraints(openXmlElement, value.Constraints, diffs, objName))
        ok = false;
      if (!CmpRuleList(openXmlElement, value.RuleList, diffs, objName))
        ok = false;
      if (!CmpChildForEach(openXmlElement, value.ChildForEach, diffs, objName))
        ok = false;
      if (!CmpLayoutNode(openXmlElement, value.LayoutNode, diffs, objName))
        ok = false;
      if (!CmpChoose(openXmlElement, value.Choose, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ForEach value)
    where OpenXmlElementType: DXDrawDgms.ForEach, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ForEach openXmlElement, DMDrawsDgms.ForEach value)
  {
    SetName(openXmlElement, value?.Name);
    SetReference(openXmlElement, value?.Reference);
    SetAxis(openXmlElement, value?.Axis);
    SetPointType(openXmlElement, value?.PointType);
    SetHideLastTrans(openXmlElement, value?.HideLastTrans);
    SetStart(openXmlElement, value?.Start);
    SetCount(openXmlElement, value?.Count);
    SetStep(openXmlElement, value?.Step);
    SetAlgorithm(openXmlElement, value?.Algorithm);
    SetShape(openXmlElement, value?.Shape);
    SetPresentationOf(openXmlElement, value?.PresentationOf);
    SetConstraints(openXmlElement, value?.Constraints);
    SetRuleList(openXmlElement, value?.RuleList);
    SetChildForEach(openXmlElement, value?.ChildForEach);
    SetLayoutNode(openXmlElement, value?.LayoutNode);
    SetChoose(openXmlElement, value?.Choose);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
