namespace DocumentModel.Drawings;

/// <summary>
/// Layout Node.
/// </summary>
public class LayoutNodeImpl: ModelElementImpl, LayoutNode
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Style Label
  /// </summary>
  public String? StyleLabel
  {
    get => (String?)OpenXmlElement?.StyleLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StyleLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Child Order
  /// </summary>
  public ChildOrderKind? ChildOrder
  {
    get => (ChildOrderKind?)OpenXmlElement?.ChildOrder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChildOrder = (DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues?)value;
    }
  }
  
  /// <summary>
  /// Move With
  /// </summary>
  public String? MoveWith
  {
    get => (String?)OpenXmlElement?.MoveWith?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MoveWith = (System.String?)value;
    }
  }
  
  public Collection<Algorithm>? Algorithms
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Shape2>? Shapes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<PresentationOf>? PresentationOfs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Constraints>? Constraintses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<RuleList>? RuleLists
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<VariableList>? VariableLists
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ForEach>? ForEachs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<LayoutNode>? LayoutNodes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Choose>? Chooses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ExtensionList1>? ExtensionLists
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
