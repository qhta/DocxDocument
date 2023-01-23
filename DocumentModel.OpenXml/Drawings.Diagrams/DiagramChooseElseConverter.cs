namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Else.
/// </summary>
public static class DiagramChooseElseConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXDrawDgms.DiagramChooseElse openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXDrawDgms.DiagramChooseElse openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>());
  }
  
  private static bool CmpAlgorithm(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.AlgorithmConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlgorithm(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Algorithm? value)
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
  
  private static DMDrawsDgms.Shape? GetShape(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.ShapeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape>());
  }
  
  private static bool CmpShape(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ShapeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Shape>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Shape? value)
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
  
  private static DMDrawsDgms.PresentationOf? GetPresentationOf(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>());
  }
  
  private static bool CmpPresentationOf(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.PresentationOfConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresentationOf(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.PresentationOf? value)
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
  
  private static DMDrawsDgms.Constraints? GetConstraints(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>());
  }
  
  private static bool CmpConstraints(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ConstraintsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConstraints(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Constraints? value)
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
  
  private static DMDrawsDgms.RuleList? GetRuleList(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.RuleListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>());
  }
  
  private static bool CmpRuleList(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.RuleListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRuleList(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.RuleList? value)
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
  
  private static DMDrawsDgms.ForEach? GetForEach(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.ForEachConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>());
  }
  
  private static bool CmpForEach(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ForEachConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetForEach(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.ForEach? value)
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
  
  private static DMDrawsDgms.LayoutNode? GetLayoutNode(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>());
  }
  
  private static bool CmpLayoutNode(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutNode(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.LayoutNode? value)
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
  
  private static DMDrawsDgms.Choose? GetChoose(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.ChooseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Choose>());
  }
  
  private static bool CmpChoose(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ChooseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.Choose>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChoose(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.Choose? value)
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
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.DiagramChooseElse openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DMDrawsDgms.DiagramChooseElse? CreateModelElement(DXDrawDgms.DiagramChooseElse? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.DiagramChooseElse();
      value.Name = GetName(openXmlElement);
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
  
  public static bool CompareModelElement(DXDrawDgms.DiagramChooseElse? openXmlElement, DMDrawsDgms.DiagramChooseElse? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.DiagramChooseElse? value)
    where OpenXmlElementType: DXDrawDgms.DiagramChooseElse, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
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
