namespace DocumentModel.Drawings;

/// <summary>
/// List of extensions to the CT_DiagramDefintions type..
/// </summary>
public class DiagramDefinitionExtensionListImpl: ModelElementImpl, DiagramDefinitionExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DiagramDefinitionExtension>? DiagramDefinitionExtensions
  {
    get;
    set;
  }
  
}
