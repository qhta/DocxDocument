namespace DocumentModel.Interop;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
public partial interface MailMergeDataSource : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The header source name.
  /// </summary>
  public string HeaderSourceName { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdMailMergeDataSource Type { get; }

  /// <summary>
  /// The header source type.
  /// </summary>
  public WdMailMergeDataSource HeaderSourceType { get; }

  /// <summary>
  /// The connect string.
  /// </summary>
  public string ConnectString { get; }

  /// <summary>
  /// The query string.
  /// </summary>
  public string QueryString { get; set; }

  /// <summary>
  /// The active record.
  /// </summary>
  public WdMailMergeActiveRecord ActiveRecord { get; set; }

  /// <summary>
  /// The first record.
  /// </summary>
  public int FirstRecord { get; set; }

  /// <summary>
  /// The last record.
  /// </summary>
  public int LastRecord { get; set; }

  /// <summary>
  /// The field names.
  /// </summary>
  public MailMergeFieldNames FieldNames { get; }

  /// <summary>
  /// The data fields.
  /// </summary>
  public MailMergeDataFields DataFields { get; }

  /// <summary>
  /// The record count.
  /// </summary>
  public int RecordCount { get; }

  /// <summary>
  /// The included.
  /// </summary>
  public bool Included { get; set; }

  /// <summary>
  /// The invalid address.
  /// </summary>
  public bool InvalidAddress { get; set; }

  /// <summary>
  /// The invalid comments.
  /// </summary>
  public string InvalidComments { get; set; }

  /// <summary>
  /// The mapped data fields.
  /// </summary>
  public MappedDataFields MappedDataFields { get; }

  /// <summary>
  /// The table name.
  /// </summary>
  public string TableName { get; }
}
