namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// If.
/// </summary>
public static class DiagramChooseIfConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDrawDgms.DiagramChooseIf openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDrawDgms.DiagramChooseIf openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.AxisKind>? GetAxis(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis);
  }
  
  private static bool CmpAxis(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<DMDrawsDgms.AxisKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis) == value;
  }
  
  private static void SetAxis(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<DMDrawsDgms.AxisKind>? value)
  {
    if (value != null)
      openXmlElement.Axis = ListValueConverter.CreateListValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(value);
    else
      openXmlElement.Axis = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.ElementKind>? GetPointType(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType);
  }
  
  private static bool CmpPointType(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<DMDrawsDgms.ElementKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(openXmlElement?.PointType) == value;
  }
  
  private static void SetPointType(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<DMDrawsDgms.ElementKind>? value)
  {
    if (value != null)
      openXmlElement.PointType = ListValueConverter.CreateListValue<DXDrawDgms.ElementValues, DMDrawsDgms.ElementKind>(value);
    else
      openXmlElement.PointType = null;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  private static DM.ListOf<Boolean>? GetHideLastTrans(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }
  
  private static bool CmpHideLastTrans(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<Boolean>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans) == value;
  }
  
  private static void SetHideLastTrans(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<Boolean>? value)
  {
    if (value != null)
      openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<DX.BooleanValue>(value);
    else
      openXmlElement.HideLastTrans = null;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  private static DM.ListOf<Int32>? GetStart(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static bool CmpStart(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start) == value;
  }
  
  private static void SetStart(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Start = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  private static DM.ListOf<UInt32>? GetCount(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }
  
  private static bool CmpCount(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<UInt32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count) == value;
  }
  
  private static void SetCount(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<UInt32>? value)
  {
    if (value != null)
      openXmlElement.Count = ListValueConverter.CreateListValue<DX.UInt32Value>(value);
    else
      openXmlElement.Count = null;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  private static DM.ListOf<Int32>? GetStep(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }
  
  private static bool CmpStep(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step) == value;
  }
  
  private static void SetStep(DXDrawDgms.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  /// <summary>
  /// Function
  /// </summary>
  private static DMDrawsDgms.FunctionKind? GetFunction(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DMDrawsDgms.FunctionKind>(openXmlElement?.Function?.Value);
  }
  
  private static bool CmpFunction(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.FunctionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DMDrawsDgms.FunctionKind>(openXmlElement?.Function?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFunction(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.FunctionKind? value)
  {
    openXmlElement.Function = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DMDrawsDgms.FunctionKind>(value);
  }
  
  /// <summary>
  /// Argument
  /// </summary>
  private static String? GetArgument(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return openXmlElement?.Argument?.Value;
  }
  
  private static bool CmpArgument(DXDrawDgms.DiagramChooseIf openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Argument?.Value == value;
  }
  
  private static void SetArgument(DXDrawDgms.DiagramChooseIf openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Argument = new StringValue { Value = value };
    else
      openXmlElement.Argument = null;
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  private static DMDrawsDgms.FunctionOperatorKind? GetOperator(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DMDrawsDgms.FunctionOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  private static bool CmpOperator(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.FunctionOperatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DMDrawsDgms.FunctionOperatorKind>(openXmlElement?.Operator?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOperator(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.FunctionOperatorKind? value)
  {
    openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DMDrawsDgms.FunctionOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXDrawDgms.DiagramChooseIf openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXDrawDgms.DiagramChooseIf openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>());
  }
  
  private static bool CmpAlgorithm(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.AlgorithmConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlgorithm(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Algorithm? value)
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
  
  private static DMDrawsDgms.Shape? GetShape(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.ShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape>());
  }
  
  private static bool CmpShape(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ShapeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Shape? value)
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
  
  private static DMDrawsDgms.PresentationOf? GetPresentationOf(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>());
  }
  
  private static bool CmpPresentationOf(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PresentationOfConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresentationOf(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.PresentationOf? value)
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
  
  private static DMDrawsDgms.Constraints? GetConstraints(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>());
  }
  
  private static bool CmpConstraints(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ConstraintsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConstraints(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Constraints? value)
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
  
  private static DMDrawsDgms.RuleList? GetRuleList(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.RuleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>());
  }
  
  private static bool CmpRuleList(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.RuleListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRuleList(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.RuleList? value)
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
  
  private static DMDrawsDgms.ForEach? GetForEach(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.ForEachConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>());
  }
  
  private static bool CmpForEach(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ForEachConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetForEach(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.ForEach? value)
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
  
  private static DMDrawsDgms.LayoutNode? GetLayoutNode(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>());
  }
  
  private static bool CmpLayoutNode(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutNode(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.LayoutNode? value)
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
  
  private static DMDrawsDgms.Choose? GetChoose(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.ChooseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Choose>());
  }
  
  private static bool CmpChoose(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ChooseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Choose>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChoose(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.Choose? value)
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
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.DiagramChooseIf openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DMDrawsDgms.DiagramChooseIf? CreateModelElement(DXDrawDgms.DiagramChooseIf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DiagramChooseIf();
      value.Name = GetName(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.Function = GetFunction(openXmlElement);
      value.Argument = GetArgument(openXmlElement);
      value.Operator = GetOperator(openXmlElement);
      value.Val = GetVal(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.ForEach = GetForEach(openXmlElement);
      value.LayoutNode = GetLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.DiagramChooseIf? openXmlElement, DMDrawsDgms.DiagramChooseIf? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
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
      if (!CmpFunction(openXmlElement, value.Function, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, value.Argument, diffs, objName))
        ok = false;
      if (!CmpOperator(openXmlElement, value.Operator, diffs, objName))
        ok = false;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
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
      if (!CmpForEach(openXmlElement, value.ForEach, diffs, objName))
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DiagramChooseIf? value)
    where OpenXmlElementType: DXDrawDgms.DiagramChooseIf, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetFunction(openXmlElement, value?.Function);
      SetArgument(openXmlElement, value?.Argument);
      SetOperator(openXmlElement, value?.Operator);
      SetVal(openXmlElement, value?.Val);
      SetAlgorithm(openXmlElement, value?.Algorithm);
      SetShape(openXmlElement, value?.Shape);
      SetPresentationOf(openXmlElement, value?.PresentationOf);
      SetConstraints(openXmlElement, value?.Constraints);
      SetRuleList(openXmlElement, value?.RuleList);
      SetForEach(openXmlElement, value?.ForEach);
      SetLayoutNode(openXmlElement, value?.LayoutNode);
      SetChoose(openXmlElement, value?.Choose);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
