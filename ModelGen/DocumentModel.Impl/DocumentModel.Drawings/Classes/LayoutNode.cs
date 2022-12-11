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
  
  public LayoutNodeImpl(): base() {}
  
  public LayoutNodeImpl(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
  public Algorithm? Algorithm
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PresentationOf? PresentationOf
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Constraints? Constraints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RuleList? RuleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public VariableList? VariableList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ForEach? ForEach
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LayoutNode? ChildLayoutNode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Choose? Choose
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
