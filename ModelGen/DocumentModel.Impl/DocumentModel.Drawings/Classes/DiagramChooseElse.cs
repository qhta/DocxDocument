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
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  public Collection<Algorithm>? Algorithms
  {
    get;
    set;
  }
  
  public Collection<Shape4>? Shapes
  {
    get;
    set;
  }
  
  public Collection<PresentationOf>? PresentationOfs
  {
    get;
    set;
  }
  
  public Collection<Constraints>? Constraintses
  {
    get;
    set;
  }
  
  public Collection<RuleList>? RuleLists
  {
    get;
    set;
  }
  
  public Collection<ForEach>? ForEachs
  {
    get;
    set;
  }
  
  public Collection<LayoutNode>? LayoutNodes
  {
    get;
    set;
  }
  
  public Collection<Choose>? Chooses
  {
    get;
    set;
  }
  
  public Collection<ExtensionList3>? ExtensionLists
  {
    get;
    set;
  }
  
}
