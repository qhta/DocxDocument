namespace DocumentModel.Drawings;

/// <summary>
/// Rule List.
/// </summary>
public class RuleListImpl: ModelElementImpl, RuleList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.RuleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.RuleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RuleListImpl(): base() {}
  
  public RuleListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Rule>? Rules
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
