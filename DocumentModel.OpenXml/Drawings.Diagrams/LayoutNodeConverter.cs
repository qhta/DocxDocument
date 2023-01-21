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
  
  private static void SetMoveWith(DXDrawDgms.LayoutNode openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MoveWith = new StringValue { Value = value };
    else
      openXmlElement.MoveWith = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.LayoutNode openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>();
    if (itemElement != null)
      return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Shape>();
    if (itemElement != null)
      return DMXDrawsDgms.ShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>();
    if (itemElement != null)
      return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>();
    if (itemElement != null)
      return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>();
    if (itemElement != null)
      return DMXDrawsDgms.RuleListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.VariableList>();
    if (itemElement != null)
      return DMXDrawsDgms.VariableListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>();
    if (itemElement != null)
      return DMXDrawsDgms.ForEachConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Choose>();
    if (itemElement != null)
      return DMXDrawsDgms.ChooseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
