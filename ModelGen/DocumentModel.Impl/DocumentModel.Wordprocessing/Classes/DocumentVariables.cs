namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Variables.
/// </summary>
public class DocumentVariablesImpl: ModelElementImpl, DocumentVariables
{
  public DocumentFormat.OpenXml.Wordprocessing.DocumentVariables? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentVariables?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DocumentVariable>? Items
  {
    get;
    set;
  }
  
}
