namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public interface IMailMergeRecipients // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ISingleDataSourceRecord>? SingleDataSourceRecords { get ; set; }
  
}
