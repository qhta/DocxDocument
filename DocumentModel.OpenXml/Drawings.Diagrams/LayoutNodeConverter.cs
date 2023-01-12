namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Node.
/// </summary>
public static class LayoutNodeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public static String? GetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    return openXmlElement?.StyleLabel?.Value;
  }
  
  public static void SetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StyleLabel = new StringValue { Value = value };
      else
        openXmlElement.StyleLabel = null;
  }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ChildOrderKind? GetChildOrder(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DocumentModel.Drawings.Diagrams.ChildOrderKind>(openXmlElement?.ChildOrder?.Value);
  }
  
  public static void SetChildOrder(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ChildOrderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChildOrder = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues, DocumentModel.Drawings.Diagrams.ChildOrderKind>(value);
  }
  
  /// <summary>
  /// Move With
  /// </summary>
  public static String? GetMoveWith(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    return openXmlElement?.MoveWith?.Value;
  }
  
  public static void SetMoveWith(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MoveWith = new StringValue { Value = value };
      else
        openXmlElement.MoveWith = null;
  }
  
  public static DocumentModel.Drawings.Diagrams.Algorithm? GetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Algorithm? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.AlgorithmConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? GetShape(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.PresentationOf? GetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.PresentationOf? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.PresentationOfConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraints? GetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Constraints? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ConstraintsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.RuleList? GetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.RuleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.RuleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.RuleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.VariableList? GetVariableList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.VariableListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetVariableList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.VariableList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.VariableListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ForEach? GetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ForEachConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ForEach? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ForEachConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? GetChildLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Choose? GetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ChooseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.Choose? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ChooseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.LayoutNode? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetStyleLabel(openXmlElement, value?.StyleLabel);
      SetChildOrder(openXmlElement, value?.ChildOrder);
      SetMoveWith(openXmlElement, value?.MoveWith);
      return openXmlElement;
    }
    return default;
  }
}
