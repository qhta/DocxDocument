namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the recipients for a mail merge operation in a WordprocessingML document.
/// This class provides a property for a single data source record, enabling advanced configuration and management of recipient data for mail merge processes.
/// </summary>
[OpenXmlType(typeof(SingleDataSourceRecord))]
public class MailMergeRecipients : ModelElementCollection<SingleDataSourceRecord, DXOW.MailMergeRecipients, DXOW.SingleDataSourceRecord>
{
}