namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public static class LayoutNodeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDD.LayoutNode openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDD.LayoutNode openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDD.LayoutNode openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Style Label
  /// </summary>
  private static String? GetStyleLabel(DXDD.LayoutNode openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StyleLabel);
  }
  
  private static bool CmpStyleLabel(DXDD.LayoutNode openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StyleLabel, value, diffs, objName, "StyleLabel");
  }
  
  private static void SetStyleLabel(DXDD.LayoutNode openXmlElement, String? value)
  {
    openXmlElement.StyleLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Child Order
  /// </summary>
  private static DMDD.ChildOrderKind? GetChildOrder(DXDD.LayoutNode openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DMDD.ChildOrderKind>(openXmlElement?.ChildOrder?.Value);
  }
  
  private static bool CmpChildOrder(DXDD.LayoutNode openXmlElement, DMDD.ChildOrderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DMDD.ChildOrderKind>(openXmlElement?.ChildOrder?.Value, value, diffs, objName);
  }
  
  private static void SetChildOrder(DXDD.LayoutNode openXmlElement, DMDD.ChildOrderKind? value)
  {
    openXmlElement.ChildOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DMDD.ChildOrderKind>(value);
  }
  
  /// <summary>
  /// Move With
  /// </summary>
  private static String? GetMoveWith(DXDD.LayoutNode openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MoveWith);
  }
  
  private static bool CmpMoveWith(DXDD.LayoutNode openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MoveWith, value, diffs, objName, "MoveWith");
  }
  
  private static void SetMoveWith(DXDD.LayoutNode openXmlElement, String? value)
  {
    openXmlElement.MoveWith = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDD.Algorithm? GetAlgorithm(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Algorithm>();
    if (element != null)
      return DMXDD.AlgorithmConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlgorithm(DXDD.LayoutNode openXmlElement, DMDD.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDD.AlgorithmConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Algorithm>(), value, diffs, objName);
  }
  
  private static void SetAlgorithm(DXDD.LayoutNode openXmlElement, DMDD.Algorithm? value)
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
  
  private static DMDD.Shape? GetShape(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Shape>();
    if (element != null)
      return DMXDD.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDD.LayoutNode openXmlElement, DMDD.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXDD.LayoutNode openXmlElement, DMDD.Shape? value)
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
  
  private static DMDD.PresentationOf? GetPresentationOf(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.PresentationOf>();
    if (element != null)
      return DMXDD.PresentationOfConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresentationOf(DXDD.LayoutNode openXmlElement, DMDD.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDD.PresentationOfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.PresentationOf>(), value, diffs, objName);
  }
  
  private static void SetPresentationOf(DXDD.LayoutNode openXmlElement, DMDD.PresentationOf? value)
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
  
  private static DMDD.Constraints? GetConstraints(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Constraints>();
    if (element != null)
      return DMXDD.ConstraintsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConstraints(DXDD.LayoutNode openXmlElement, DMDD.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ConstraintsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Constraints>(), value, diffs, objName);
  }
  
  private static void SetConstraints(DXDD.LayoutNode openXmlElement, DMDD.Constraints? value)
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
  
  private static DMDD.RuleList? GetRuleList(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.RuleList>();
    if (element != null)
      return DMXDD.RuleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRuleList(DXDD.LayoutNode openXmlElement, DMDD.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.RuleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.RuleList>(), value, diffs, objName);
  }
  
  private static void SetRuleList(DXDD.LayoutNode openXmlElement, DMDD.RuleList? value)
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
  
  private static DMDD.VariableList? GetVariableList(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.VariableList>();
    if (element != null)
      return DMXDD.VariableListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVariableList(DXDD.LayoutNode openXmlElement, DMDD.VariableList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.VariableListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.VariableList>(), value, diffs, objName);
  }
  
  private static void SetVariableList(DXDD.LayoutNode openXmlElement, DMDD.VariableList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.VariableList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.VariableListConverter.CreateOpenXmlElement<DXDD.VariableList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.ForEach? GetForEach(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ForEach>();
    if (element != null)
      return DMXDD.ForEachConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpForEach(DXDD.LayoutNode openXmlElement, DMDD.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ForEachConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ForEach>(), value, diffs, objName);
  }
  
  private static void SetForEach(DXDD.LayoutNode openXmlElement, DMDD.ForEach? value)
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
  
  private static DMDD.LayoutNode? GetChildLayoutNode(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.LayoutNode>();
    if (element != null)
      return DMXDD.LayoutNodeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildLayoutNode(DXDD.LayoutNode openXmlElement, DMDD.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDD.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.LayoutNode>(), value, diffs, objName);
  }
  
  private static void SetChildLayoutNode(DXDD.LayoutNode openXmlElement, DMDD.LayoutNode? value)
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
  
  private static DMDD.Choose? GetChoose(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Choose>();
    if (element != null)
      return DMXDD.ChooseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChoose(DXDD.LayoutNode openXmlElement, DMDD.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ChooseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Choose>(), value, diffs, objName);
  }
  
  private static void SetChoose(DXDD.LayoutNode openXmlElement, DMDD.Choose? value)
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
  
  private static DMDD.ExtensionList? GetExtensionList(DXDD.LayoutNode openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.LayoutNode openXmlElement, DMDD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDD.LayoutNode openXmlElement, DMDD.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? CreateModelElement(DXDD.LayoutNode? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.LayoutNode();
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
  
  public static bool CompareModelElement(DXDD.LayoutNode? openXmlElement, DMDD.LayoutNode? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.LayoutNode value)
    where OpenXmlElementType: DXDD.LayoutNode, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.LayoutNode openXmlElement, DMDD.LayoutNode value)
  {
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
  }
}
