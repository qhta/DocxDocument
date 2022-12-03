namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public interface MailMergeRecipients // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<SingleDataSourceRecord>? SingleDataSourceRecords { get ; set; }
  
}
