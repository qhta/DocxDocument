namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines MailMergeRecipients.
/// </summary>
public interface MailMergeRecipients: IModelElement
{
  public SingleDataSourceRecord? SingleDataSourceRecord { get; set; }
}