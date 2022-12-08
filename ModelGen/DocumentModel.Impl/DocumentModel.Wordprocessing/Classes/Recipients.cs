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
  
  public Collection<RecipientData>? RecipientDatas
  {
    get;
    set;
  }
  
}
