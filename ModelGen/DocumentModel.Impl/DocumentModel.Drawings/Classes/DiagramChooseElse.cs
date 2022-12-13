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
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Algorithm? Algorithm
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.PresentationOf? PresentationOf
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Constraints? Constraints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.RuleList? RuleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ForEach? ForEach
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LayoutNode? LayoutNode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Choose? Choose
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
