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
  
  public Collection<SingleDataSourceRecord>? SingleDataSourceRecords
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
