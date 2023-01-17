namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Else.
/// </summary>
public static class DiagramChooseElseConverter
{
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static DocumentModel.Drawings.Diagrams.Algorithm? GetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAlgorithm(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.Algorithm? value)
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
  
  private static DocumentModel.Drawings.Diagrams.Shape? GetShape(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.Shape? value)
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
  
  private static DocumentModel.Drawings.Diagrams.PresentationOf? GetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresentationOf(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.PresentationOf? value)
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
  
  private static DocumentModel.Drawings.Diagrams.Constraints? GetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConstraints(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.Constraints? value)
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
  
  private static DocumentModel.Drawings.Diagrams.RuleList? GetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.RuleListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRuleList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.RuleList? value)
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
  
  private static DocumentModel.Drawings.Diagrams.ForEach? GetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ForEachConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetForEach(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.ForEach? value)
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
  
  private static DocumentModel.Drawings.Diagrams.LayoutNode? GetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
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
  
  private static DocumentModel.Drawings.Diagrams.Choose? GetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ChooseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChoose(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.Choose? value)
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
  
  private static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.DiagramChooseElse? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramChooseElse? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse, new()
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
