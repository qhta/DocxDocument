namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public class MailMergeRecipientsImpl: ModelElementImpl, MailMergeRecipients
{
  public DocumentFormat.OpenXml.Office.Word.MailMergeRecipients? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.MailMergeRecipients?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MailMergeRecipientsImpl(): base() {}
  
  public MailMergeRecipientsImpl(DocumentFormat.OpenXml.Office.Word.MailMergeRecipients openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public SingleDataSourceRecord? SingleDataSourceRecord
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
