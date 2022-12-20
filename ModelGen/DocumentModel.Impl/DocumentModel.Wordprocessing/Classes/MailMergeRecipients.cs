namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public partial class MailMergeRecipientsImpl: ModelElementImpl, MailMergeRecipients
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Word.MailMergeRecipients? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.MailMergeRecipients?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MailMergeRecipientsImpl(): base() {}
  
  public MailMergeRecipientsImpl(DocumentFormat.OpenXml.Office.Word.MailMergeRecipients openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.SingleDataSourceRecord? SingleDataSourceRecord
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
        if (item != null)
          return new DocumentModel.Wordprocessing.SingleDataSourceRecordImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.SingleDataSourceRecordImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
