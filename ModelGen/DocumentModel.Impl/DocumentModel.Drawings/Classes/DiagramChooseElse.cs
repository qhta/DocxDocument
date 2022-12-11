namespace DocumentModel.Drawings;

/// <summary>
/// Else.
/// </summary>
public class DiagramChooseElseImpl: ModelElementImpl, DiagramChooseElse
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramChooseElseImpl(): base() {}
  
  public DiagramChooseElseImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse openXmlElement): base(openXmlElement)
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
  
  public ForEach? ForEach
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
