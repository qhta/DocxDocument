namespace DocumentModel.Drawings;

/// <summary>
/// Constraint List.
/// </summary>
public class ConstraintsImpl: ModelElementImpl, Constraints
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Constraints? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Constraints?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Constraint>? Items
  {
    get;
    set;
  }
  
}
