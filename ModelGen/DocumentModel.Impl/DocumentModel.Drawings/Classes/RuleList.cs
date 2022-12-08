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
  
  public Collection<Rule>? Rules
  {
    get;
    set;
  }
  
}
