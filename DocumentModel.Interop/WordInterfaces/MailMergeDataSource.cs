namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource?view=word-pia"/>
public partial interface MailMergeDataSource : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the header source name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcename?view=word-pia"/>
  public string HeaderSourceName { get; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.type?view=word-pia"/>
  public WdMailMergeDataSource Type { get; }

  /// <summary>
  /// Returns the header source type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcetype?view=word-pia"/>
  public WdMailMergeDataSource HeaderSourceType { get; }

  /// <summary>
  /// Returns the connect string.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.connectstring?view=word-pia"/>
  public string ConnectString { get; }

  /// <summary>
  /// Returns or sets the query string.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.querystring?view=word-pia"/>
  public string QueryString { get; set; }

  /// <summary>
  /// Returns or sets the active record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.activerecord?view=word-pia"/>
  public WdMailMergeActiveRecord ActiveRecord { get; set; }

  /// <summary>
  /// Returns or sets the first record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.firstrecord?view=word-pia"/>
  public int FirstRecord { get; set; }

  /// <summary>
  /// Returns or sets the last record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.lastrecord?view=word-pia"/>
  public int LastRecord { get; set; }

  /// <summary>
  /// Returns the field names.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.fieldnames?view=word-pia"/>
  public MailMergeFieldNames FieldNames { get; }

  /// <summary>
  /// Returns the data fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.datafields?view=word-pia"/>
  public MailMergeDataFields DataFields { get; }

  /// <summary>
  /// Returns the record count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.recordcount?view=word-pia"/>
  public int RecordCount { get; }

  /// <summary>
  /// Returns or sets whether included.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.included?view=word-pia"/>
  public bool Included { get; set; }

  /// <summary>
  /// Returns or sets whether invalid address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidaddress?view=word-pia"/>
  public bool InvalidAddress { get; set; }

  /// <summary>
  /// Returns or sets the invalid comments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidcomments?view=word-pia"/>
  public string InvalidComments { get; set; }

  /// <summary>
  /// Returns the mapped data fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.mappeddatafields?view=word-pia"/>
  public MappedDataFields MappedDataFields { get; }

  /// <summary>
  /// Returns the table name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.tablename?view=word-pia"/>
  public string TableName { get; }
}
