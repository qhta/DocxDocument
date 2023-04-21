namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// If.
/// </summary>
public static class DiagramChooseIfConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDD.DiagramChooseIf openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDD.DiagramChooseIf openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDD.DiagramChooseIf openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  private static DM.ListOf<DMDD.AxisKind>? GetAxis(DXDD.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDD.AxisValues, DMDD.AxisKind>(openXmlElement?.Axis);
  }
  
  private static bool CmpAxis(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<DMDD.AxisKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue<DXDD.AxisValues, DMDD.AxisKind>(openXmlElement?.Axis, value, diffs, objName);
  }
  
  private static void SetAxis(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<DMDD.AxisKind>? value)
  {
    if (value != null)
      openXmlElement.Axis = ListValueConverter.CreateListValue<DXDD.AxisValues, DMDD.AxisKind>(value);
    else
      openXmlElement.Axis = null;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  private static DM.ListOf<DMDD.ElementKind>? GetPointType(DXDD.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue<DXDD.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType);
  }
  
  private static bool CmpPointType(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<DMDD.ElementKind>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue<DXDD.ElementValues, DMDD.ElementKind>(openXmlElement?.PointType, value, diffs, objName);
  }
  
  private static void SetPointType(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<DMDD.ElementKind>? value)
  {
    if (value != null)
      openXmlElement.PointType = ListValueConverter.CreateListValue<DXDD.ElementValues, DMDD.ElementKind>(value);
    else
      openXmlElement.PointType = null;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  private static DM.ListOf<Boolean>? GetHideLastTrans(DXDD.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }
  
  private static bool CmpHideLastTrans(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<Boolean>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.HideLastTrans, value, diffs, objName);
  }
  
  private static void SetHideLastTrans(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<Boolean>? value)
  {
    if (value != null)
      openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<DX.BooleanValue>(value);
    else
      openXmlElement.HideLastTrans = null;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  private static DM.ListOf<Int32>? GetStart(DXDD.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }
  
  private static bool CmpStart(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Start, value, diffs, objName);
  }
  
  private static void SetStart(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Start = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Start = null;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  private static DM.ListOf<UInt32>? GetCount(DXDD.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }
  
  private static bool CmpCount(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<UInt32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Count, value, diffs, objName);
  }
  
  private static void SetCount(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<UInt32>? value)
  {
    if (value != null)
      openXmlElement.Count = ListValueConverter.CreateListValue<DX.UInt32Value>(value);
    else
      openXmlElement.Count = null;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  private static DM.ListOf<Int32>? GetStep(DXDD.DiagramChooseIf openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }
  
  private static bool CmpStep(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Step, value, diffs, objName);
  }
  
  private static void SetStep(DXDD.DiagramChooseIf openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  /// <summary>
  /// Function
  /// </summary>
  private static DMDD.FunctionKind? GetFunction(DXDD.DiagramChooseIf openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DMDD.FunctionKind>(openXmlElement?.Function?.Value);
  }
  
  private static bool CmpFunction(DXDD.DiagramChooseIf openXmlElement, DMDD.FunctionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DMDD.FunctionKind>(openXmlElement?.Function?.Value, value, diffs, objName);
  }
  
  private static void SetFunction(DXDD.DiagramChooseIf openXmlElement, DMDD.FunctionKind? value)
  {
    openXmlElement.Function = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues, DMDD.FunctionKind>(value);
  }
  
  /// <summary>
  /// Argument
  /// </summary>
  private static String? GetArgument(DXDD.DiagramChooseIf openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Argument);
  }
  
  private static bool CmpArgument(DXDD.DiagramChooseIf openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Argument, value, diffs, objName, "Argument");
  }
  
  private static void SetArgument(DXDD.DiagramChooseIf openXmlElement, String? value)
  {
    openXmlElement.Argument = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  private static DMDD.FunctionOperatorKind? GetOperator(DXDD.DiagramChooseIf openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DMDD.FunctionOperatorKind>(openXmlElement?.Operator?.Value);
  }
  
  private static bool CmpOperator(DXDD.DiagramChooseIf openXmlElement, DMDD.FunctionOperatorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DMDD.FunctionOperatorKind>(openXmlElement?.Operator?.Value, value, diffs, objName);
  }
  
  private static void SetOperator(DXDD.DiagramChooseIf openXmlElement, DMDD.FunctionOperatorKind? value)
  {
    openXmlElement.Operator = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues, DMDD.FunctionOperatorKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDD.DiagramChooseIf openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXDD.DiagramChooseIf openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXDD.DiagramChooseIf openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDD.Algorithm? GetAlgorithm(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Algorithm>();
    if (element != null)
      return DMXDD.AlgorithmConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlgorithm(DXDD.DiagramChooseIf openXmlElement, DMDD.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDD.AlgorithmConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Algorithm>(), value, diffs, objName);
  }
  
  private static void SetAlgorithm(DXDD.DiagramChooseIf openXmlElement, DMDD.Algorithm? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Algorithm>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.AlgorithmConverter.CreateOpenXmlElement<DXDD.Algorithm>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.Shape? GetShape(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Shape>();
    if (element != null)
      return DMXDD.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDD.DiagramChooseIf openXmlElement, DMDD.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXDD.DiagramChooseIf openXmlElement, DMDD.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ShapeConverter.CreateOpenXmlElement<DXDD.Shape>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.PresentationOf? GetPresentationOf(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.PresentationOf>();
    if (element != null)
      return DMXDD.PresentationOfConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresentationOf(DXDD.DiagramChooseIf openXmlElement, DMDD.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDD.PresentationOfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.PresentationOf>(), value, diffs, objName);
  }
  
  private static void SetPresentationOf(DXDD.DiagramChooseIf openXmlElement, DMDD.PresentationOf? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.PresentationOf>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.PresentationOfConverter.CreateOpenXmlElement<DXDD.PresentationOf>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.Constraints? GetConstraints(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Constraints>();
    if (element != null)
      return DMXDD.ConstraintsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConstraints(DXDD.DiagramChooseIf openXmlElement, DMDD.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ConstraintsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Constraints>(), value, diffs, objName);
  }
  
  private static void SetConstraints(DXDD.DiagramChooseIf openXmlElement, DMDD.Constraints? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Constraints>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ConstraintsConverter.CreateOpenXmlElement<DXDD.Constraints>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.RuleList? GetRuleList(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.RuleList>();
    if (element != null)
      return DMXDD.RuleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRuleList(DXDD.DiagramChooseIf openXmlElement, DMDD.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.RuleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.RuleList>(), value, diffs, objName);
  }
  
  private static void SetRuleList(DXDD.DiagramChooseIf openXmlElement, DMDD.RuleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.RuleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.RuleListConverter.CreateOpenXmlElement<DXDD.RuleList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.ForEach? GetForEach(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ForEach>();
    if (element != null)
      return DMXDD.ForEachConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpForEach(DXDD.DiagramChooseIf openXmlElement, DMDD.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ForEachConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ForEach>(), value, diffs, objName);
  }
  
  private static void SetForEach(DXDD.DiagramChooseIf openXmlElement, DMDD.ForEach? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ForEach>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ForEachConverter.CreateOpenXmlElement<DXDD.ForEach>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.LayoutNode? GetLayoutNode(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.LayoutNode>();
    if (element != null)
      return DMXDD.LayoutNodeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayoutNode(DXDD.DiagramChooseIf openXmlElement, DMDD.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDD.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.LayoutNode>(), value, diffs, objName);
  }
  
  private static void SetLayoutNode(DXDD.DiagramChooseIf openXmlElement, DMDD.LayoutNode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.LayoutNode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.LayoutNodeConverter.CreateOpenXmlElement<DXDD.LayoutNode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.Choose? GetChoose(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Choose>();
    if (element != null)
      return DMXDD.ChooseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChoose(DXDD.DiagramChooseIf openXmlElement, DMDD.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ChooseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Choose>(), value, diffs, objName);
  }
  
  private static void SetChoose(DXDD.DiagramChooseIf openXmlElement, DMDD.Choose? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Choose>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ChooseConverter.CreateOpenXmlElement<DXDD.Choose>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.ExtensionList? GetExtensionList(DXDD.DiagramChooseIf openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.DiagramChooseIf openXmlElement, DMDD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDD.DiagramChooseIf openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DiagramChooseIf? CreateModelElement(DXDD.DiagramChooseIf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramChooseIf();
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
  
  public static bool CompareModelElement(DXDD.DiagramChooseIf? openXmlElement, DMDD.DiagramChooseIf? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DiagramChooseIf value)
    where OpenXmlElementType: DXDD.DiagramChooseIf, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DiagramChooseIf openXmlElement, DMDD.DiagramChooseIf value)
  {
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
  }
}
