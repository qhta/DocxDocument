namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the recipients for a mail merge operation in a WordprocessingML document.
/// This interface provides a property for a single data source record, enabling advanced configuration and management of recipient data for mail merge processes.
/// </summary>
public interface MailMergeRecipients: IElementCollection<SingleDataSourceRecord>
{
}