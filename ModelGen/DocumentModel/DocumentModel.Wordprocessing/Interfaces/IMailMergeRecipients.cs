namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public interface IMailMergeRecipients // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ISingleDataSourceRecord>? SingleDataSourceRecords { get ; set; }
  
}
