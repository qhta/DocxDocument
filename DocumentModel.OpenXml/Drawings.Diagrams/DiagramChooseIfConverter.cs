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
  
  private static void SetVal(DXDrawDgms.DiagramChooseIf openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.DiagramChooseIf openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>();
    if (itemElement != null)
      return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Shape>();
    if (itemElement != null)
      return DMXDrawsDgms.ShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>();
    if (itemElement != null)
      return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>();
    if (itemElement != null)
      return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>();
    if (itemElement != null)
      return DMXDrawsDgms.RuleListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>();
    if (itemElement != null)
      return DMXDrawsDgms.ForEachConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Choose>();
    if (itemElement != null)
      return DMXDrawsDgms.ChooseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
