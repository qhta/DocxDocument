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
  
  public DocumentVariablesImpl(): base() {}
  
  public DocumentVariablesImpl(DocumentFormat.OpenXml.Wordprocessing.DocumentVariables openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentVariable>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
