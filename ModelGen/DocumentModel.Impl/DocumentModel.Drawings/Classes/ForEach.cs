namespace DocumentModel.Drawings;

/// <summary>
/// For Each.
/// </summary>
public class ForEachImpl: ModelElementImpl, ForEach
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ForEach? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ForEach?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ForEachImpl(): base() {}
  
  public ForEachImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach openXmlElement): base(openXmlElement)
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
  /// Reference
  /// </summary>
  public String? Reference
  {
    get => (String?)OpenXmlElement?.Reference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Reference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisKind>? Axis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementKind>? PointType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<Boolean>? HideLastTrans
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<Int32>? Start
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<UInt32>? Count
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<Int32>? Step
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  
  public ForEach? ChildForEach
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LayoutNode? LayoutNode
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
