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
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDrawDgms.ForEach openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  private static String? GetReference(DXDrawDgms.ForEach openXmlElement)
  {
    return openXmlElement?.Reference?.Value;
  }
  
  private static void SetReference(DXDrawDgms.ForEach openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Reference = new StringValue { Value = value };
    else
      openXmlElement.Reference = null;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  private static DM.ListOf<DMDrawsDgms.AxisKind>? GetAxis(DXDrawDgms.ForEach openXmlElement)
  {
    return ListValueConverter.GetValue<DXDrawDgms.AxisValues, DMDrawsDgms.AxisKind>(openXmlElement?.Axis);
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
  
  private static void SetStep(DXDrawDgms.ForEach openXmlElement, DM.ListOf<Int32>? value)
  {
    if (value != null)
      openXmlElement.Step = ListValueConverter.CreateListValue<DX.Int32Value>(value);
    else
      openXmlElement.Step = null;
  }
  
  private static DMDrawsDgms.Algorithm? GetAlgorithm(DXDrawDgms.ForEach openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Algorithm>();
    if (itemElement != null)
      return DMXDrawsDgms.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Shape>();
    if (itemElement != null)
      return DMXDrawsDgms.ShapeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.PresentationOf>();
    if (itemElement != null)
      return DMXDrawsDgms.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Constraints>();
    if (itemElement != null)
      return DMXDrawsDgms.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.RuleList>();
    if (itemElement != null)
      return DMXDrawsDgms.RuleListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ForEach>();
    if (itemElement != null)
      return DMXDrawsDgms.ForEachConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Choose>();
    if (itemElement != null)
      return DMXDrawsDgms.ChooseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsDgms.ForEach? CreateModelElement(DXDrawDgms.ForEach? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ForEach();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ForEach? value)
    where OpenXmlElementType: DXDrawDgms.ForEach, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
