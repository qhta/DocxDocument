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
  
  private static void SetName(DXDrawDgms.DiagramChooseElse openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>();
    if (itemElement != null)
      return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Shape>();
    if (itemElement != null)
      return DMXDrawsDgms.ShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>();
    if (itemElement != null)
      return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>();
    if (itemElement != null)
      return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>();
    if (itemElement != null)
      return DMXDrawsDgms.RuleListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>();
    if (itemElement != null)
      return DMXDrawsDgms.ForEachConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Choose>();
    if (itemElement != null)
      return DMXDrawsDgms.ChooseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
