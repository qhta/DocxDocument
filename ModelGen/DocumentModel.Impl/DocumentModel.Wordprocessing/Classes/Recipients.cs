namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Recipients.
/// </summary>
public partial class RecipientsImpl: ModelElementImpl, Recipients
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Recipients? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Recipients?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RecipientsImpl(): base() {}
  
  public RecipientsImpl(DocumentFormat.OpenXml.Wordprocessing.Recipients openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.RecipientData? RecipientData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientData>();
        if (item != null)
          return new DocumentModel.Wordprocessing.RecipientDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.RecipientDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
