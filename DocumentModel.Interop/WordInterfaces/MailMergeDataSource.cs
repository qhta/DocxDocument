namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource?view=word-pia"/>
public partial interface MailMergeDataSource : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The header source name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcename?view=word-pia"/>
  public string HeaderSourceName { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.type?view=word-pia"/>
  public WdMailMergeDataSource Type { get; }

  /// <summary>
  /// The header source type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcetype?view=word-pia"/>
  public WdMailMergeDataSource HeaderSourceType { get; }

  /// <summary>
  /// The connect string.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.connectstring?view=word-pia"/>
  public string ConnectString { get; }

  /// <summary>
  /// The query string.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.querystring?view=word-pia"/>
  public string QueryString { get; set; }

  /// <summary>
  /// The active record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.activerecord?view=word-pia"/>
  public WdMailMergeActiveRecord ActiveRecord { get; set; }

  /// <summary>
  /// The first record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.firstrecord?view=word-pia"/>
  public int FirstRecord { get; set; }

  /// <summary>
  /// The last record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.lastrecord?view=word-pia"/>
  public int LastRecord { get; set; }

  /// <summary>
  /// The field names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.fieldnames?view=word-pia"/>
  public MailMergeFieldNames FieldNames { get; }

  /// <summary>
  /// The data fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.datafields?view=word-pia"/>
  public MailMergeDataFields DataFields { get; }

  /// <summary>
  /// The record count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.recordcount?view=word-pia"/>
  public int RecordCount { get; }

  /// <summary>
  /// The included.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.included?view=word-pia"/>
  public bool Included { get; set; }

  /// <summary>
  /// The invalid address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidaddress?view=word-pia"/>
  public bool InvalidAddress { get; set; }

  /// <summary>
  /// The invalid comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidcomments?view=word-pia"/>
  public string InvalidComments { get; set; }

  /// <summary>
  /// The mapped data fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.mappeddatafields?view=word-pia"/>
  public MappedDataFields MappedDataFields { get; }

  /// <summary>
  /// The table name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.tablename?view=word-pia"/>
  public string TableName { get; }
}
