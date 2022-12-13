namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public class RecipientsImpl: ModelElementImpl, Recipients
{
  public DocumentFormat.OpenXml.Wordprocessing.Recipients? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Recipients?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RecipientsImpl(): base() {}
  
  public RecipientsImpl(DocumentFormat.OpenXml.Wordprocessing.Recipients openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.RecipientData? RecipientData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
