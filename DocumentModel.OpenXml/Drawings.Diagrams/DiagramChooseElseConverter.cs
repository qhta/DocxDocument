namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Else.
/// </summary>
public static class DiagramChooseElseConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDD.DiagramChooseElse openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDD.DiagramChooseElse openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDD.DiagramChooseElse openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDD.Algorithm? GetAlgorithm(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Algorithm>();
    if (element != null)
      return DMXDD.AlgorithmConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAlgorithm(DXDD.DiagramChooseElse openXmlElement, DMDD.Algorithm? value, DiffList? diffs, string? objName)
  {
    return DMXDD.AlgorithmConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Algorithm>(), value, diffs, objName);
  }
  
  private static void SetAlgorithm(DXDD.DiagramChooseElse openXmlElement, DMDD.Algorithm? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Algorithm>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.AlgorithmConverter.CreateOpenXmlElement<DXDD.Algorithm>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.Shape? GetShape(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Shape>();
    if (element != null)
      return DMXDD.ShapeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShape(DXDD.DiagramChooseElse openXmlElement, DMDD.Shape? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ShapeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Shape>(), value, diffs, objName);
  }
  
  private static void SetShape(DXDD.DiagramChooseElse openXmlElement, DMDD.Shape? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ShapeConverter.CreateOpenXmlElement<DXDD.Shape>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.PresentationOf? GetPresentationOf(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.PresentationOf>();
    if (element != null)
      return DMXDD.PresentationOfConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresentationOf(DXDD.DiagramChooseElse openXmlElement, DMDD.PresentationOf? value, DiffList? diffs, string? objName)
  {
    return DMXDD.PresentationOfConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.PresentationOf>(), value, diffs, objName);
  }
  
  private static void SetPresentationOf(DXDD.DiagramChooseElse openXmlElement, DMDD.PresentationOf? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.PresentationOf>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.PresentationOfConverter.CreateOpenXmlElement<DXDD.PresentationOf>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.Constraints? GetConstraints(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Constraints>();
    if (element != null)
      return DMXDD.ConstraintsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpConstraints(DXDD.DiagramChooseElse openXmlElement, DMDD.Constraints? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ConstraintsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Constraints>(), value, diffs, objName);
  }
  
  private static void SetConstraints(DXDD.DiagramChooseElse openXmlElement, DMDD.Constraints? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Constraints>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ConstraintsConverter.CreateOpenXmlElement<DXDD.Constraints>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.RuleList? GetRuleList(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.RuleList>();
    if (element != null)
      return DMXDD.RuleListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRuleList(DXDD.DiagramChooseElse openXmlElement, DMDD.RuleList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.RuleListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.RuleList>(), value, diffs, objName);
  }
  
  private static void SetRuleList(DXDD.DiagramChooseElse openXmlElement, DMDD.RuleList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.RuleList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.RuleListConverter.CreateOpenXmlElement<DXDD.RuleList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.ForEach? GetForEach(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ForEach>();
    if (element != null)
      return DMXDD.ForEachConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpForEach(DXDD.DiagramChooseElse openXmlElement, DMDD.ForEach? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ForEachConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ForEach>(), value, diffs, objName);
  }
  
  private static void SetForEach(DXDD.DiagramChooseElse openXmlElement, DMDD.ForEach? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ForEach>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ForEachConverter.CreateOpenXmlElement<DXDD.ForEach>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.LayoutNode? GetLayoutNode(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.LayoutNode>();
    if (element != null)
      return DMXDD.LayoutNodeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayoutNode(DXDD.DiagramChooseElse openXmlElement, DMDD.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDD.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.LayoutNode>(), value, diffs, objName);
  }
  
  private static void SetLayoutNode(DXDD.DiagramChooseElse openXmlElement, DMDD.LayoutNode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.LayoutNode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.LayoutNodeConverter.CreateOpenXmlElement<DXDD.LayoutNode>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.Choose? GetChoose(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Choose>();
    if (element != null)
      return DMXDD.ChooseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChoose(DXDD.DiagramChooseElse openXmlElement, DMDD.Choose? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ChooseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Choose>(), value, diffs, objName);
  }
  
  private static void SetChoose(DXDD.DiagramChooseElse openXmlElement, DMDD.Choose? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Choose>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ChooseConverter.CreateOpenXmlElement<DXDD.Choose>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.ExtensionList? GetExtensionList(DXDD.DiagramChooseElse openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.DiagramChooseElse openXmlElement, DMDD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDD.DiagramChooseElse openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DiagramChooseElse? CreateModelElement(DXDD.DiagramChooseElse? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramChooseElse();
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
  
  public static bool CompareModelElement(DXDD.DiagramChooseElse? openXmlElement, DMDD.DiagramChooseElse? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.DiagramChooseElse value)
    where OpenXmlElementType: DXDD.DiagramChooseElse, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.DiagramChooseElse openXmlElement, DMDD.DiagramChooseElse value)
  {
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
  }
}
