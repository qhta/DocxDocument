namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public static class LayoutNodeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.LayoutNode openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDrawDgms.LayoutNode openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDrawDgms.LayoutNode openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Style Label
  /// </summary>
  private static String? GetStyleLabel(DXDrawDgms.LayoutNode openXmlElement)
  {
    return openXmlElement?.StyleLabel?.Value;
  }
  
  private static bool CmpStyleLabel(DXDrawDgms.LayoutNode openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.StyleLabel?.Value == value;
  }
  
  private static void SetStyleLabel(DXDrawDgms.LayoutNode openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StyleLabel = new StringValue { Value = value };
    else
      openXmlElement.StyleLabel = null;
  }
  
  /// <summary>
  /// Child Order
  /// </summary>
  private static DMDrawsDgms.ChildOrderKind? GetChildOrder(DXDrawDgms.LayoutNode openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DMDrawsDgms.ChildOrderKind>(openXmlElement?.ChildOrder?.Value);
  }
  
  private static bool CmpChildOrder(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.ChildOrderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DMDrawsDgms.ChildOrderKind>(openXmlElement?.ChildOrder?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildOrder(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.ChildOrderKind? value)
  {
    openXmlElement.ChildOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DMDrawsDgms.ChildOrderKind>(value);
  }
  
  /// <summary>
  /// Move With
  /// </summary>
  private static String? GetMoveWith(DXDrawDgms.LayoutNode openXmlElement)
  {
    return openXmlElement?.MoveWith?.Value;
  }
  
  private static bool CmpMoveWith(DXDrawDgms.LayoutNode openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MoveWith?.Value == value;
  }
  
  private static void SetMoveWith(DXDrawDgms.LayoutNode openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MoveWith = new StringValue { Value = value };
    else
      openXmlElement.MoveWith = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>());
  }
  
  private static bool CmpAlgorithm(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.AlgorithmConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Algorithm>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlgorithm(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Algorithm? value)
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
  
  private static DMDrawsDgms.Shape? GetShape(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.ShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape>());
  }
  
  private static bool CmpShape(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Shape? value)
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
  
  private static DMDrawsDgms.PresentationOf? GetPresentationOf(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>());
  }
  
  private static bool CmpPresentationOf(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PresentationOfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.PresentationOf>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresentationOf(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.PresentationOf? value)
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
  
  private static DMDrawsDgms.Constraints? GetConstraints(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>());
  }
  
  private static bool CmpConstraints(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ConstraintsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Constraints>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConstraints(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Constraints? value)
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
  
  private static DMDrawsDgms.RuleList? GetRuleList(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.RuleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>());
  }
  
  private static bool CmpRuleList(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.RuleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.RuleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRuleList(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.RuleList? value)
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
  
  private static DMDrawsDgms.VariableList? GetVariableList(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.VariableListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.VariableList>());
  }
  
  private static bool CmpVariableList(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.VariableList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.VariableListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.VariableList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVariableList(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.VariableList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.VariableList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.VariableListConverter.CreateOpenXmlElement<DXDrawDgms.VariableList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.ForEach? GetForEach(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.ForEachConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>());
  }
  
  private static bool CmpForEach(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ForEachConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ForEach>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetForEach(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.ForEach? value)
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
  
  private static DMDrawsDgms.LayoutNode? GetChildLayoutNode(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>());
  }
  
  private static bool CmpChildLayoutNode(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.LayoutNode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildLayoutNode(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.LayoutNode? value)
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
  
  private static DMDrawsDgms.Choose? GetChoose(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.ChooseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Choose>());
  }
  
  private static bool CmpChoose(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ChooseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Choose>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChoose(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.Choose? value)
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
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.LayoutNode openXmlElement)
  {
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.LayoutNode openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DMDrawsDgms.LayoutNode? CreateModelElement(DXDrawDgms.LayoutNode? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.LayoutNode();
      value.Name = GetName(openXmlElement);
      value.StyleLabel = GetStyleLabel(openXmlElement);
      value.ChildOrder = GetChildOrder(openXmlElement);
      value.MoveWith = GetMoveWith(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.VariableList = GetVariableList(openXmlElement);
      value.ForEach = GetForEach(openXmlElement);
      value.ChildLayoutNode = GetChildLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.LayoutNode? openXmlElement, DMDrawsDgms.LayoutNode? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpStyleLabel(openXmlElement, value.StyleLabel, diffs, objName))
        ok = false;
      if (!CmpChildOrder(openXmlElement, value.ChildOrder, diffs, objName))
        ok = false;
      if (!CmpMoveWith(openXmlElement, value.MoveWith, diffs, objName))
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
      if (!CmpVariableList(openXmlElement, value.VariableList, diffs, objName))
        ok = false;
      if (!CmpForEach(openXmlElement, value.ForEach, diffs, objName))
        ok = false;
      if (!CmpChildLayoutNode(openXmlElement, value.ChildLayoutNode, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.LayoutNode? value)
    where OpenXmlElementType: DXDrawDgms.LayoutNode, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetStyleLabel(openXmlElement, value?.StyleLabel);
      SetChildOrder(openXmlElement, value?.ChildOrder);
      SetMoveWith(openXmlElement, value?.MoveWith);
      SetAlgorithm(openXmlElement, value?.Algorithm);
      SetShape(openXmlElement, value?.Shape);
      SetPresentationOf(openXmlElement, value?.PresentationOf);
      SetConstraints(openXmlElement, value?.Constraints);
      SetRuleList(openXmlElement, value?.RuleList);
      SetVariableList(openXmlElement, value?.VariableList);
      SetForEach(openXmlElement, value?.ForEach);
      SetChildLayoutNode(openXmlElement, value?.ChildLayoutNode);
      SetChoose(openXmlElement, value?.Choose);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
