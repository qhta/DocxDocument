namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public interface MailMergeRecipients
{
  public Collection<SingleDataSourceRecord>? SingleDataSourceRecords { get ; set; }
  
}
