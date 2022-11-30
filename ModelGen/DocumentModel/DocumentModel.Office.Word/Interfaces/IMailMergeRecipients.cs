namespace DocumentModel.Office.Word;

/// <summary>
/// Defines MailMergeRecipients.
/// </summary>
public interface IMailMergeRecipients // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.ISingleDataSourceRecord>? SingleDataSourceRecords { get ; set; }
  
}
