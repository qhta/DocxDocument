namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource?view=word-pia"/>
public partial interface IMailMergeDataSource : IModelObject
{
  /// <summary>
  /// Returns the name of the mail merge data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the name of the source used for header fields.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcename?view=word-pia"/>
  public string HeaderSourceName { get; }

  /// <summary>
  /// Returns the type of the mail merge data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.type?view=word-pia"/>
  public IMailMergeDataSource Type { get; }

  /// <summary>
  /// Returns the type of source used for header fields.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcetype?view=word-pia"/>
  public IMailMergeDataSource HeaderSourceType { get; }

  /// <summary>
  /// Returns the connection string for the mail merge data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.connectstring?view=word-pia"/>
  public string ConnectString { get; }

  /// <summary>
  /// Returns or sets the query string used to retrieve records.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.querystring?view=word-pia"/>
  public string QueryString { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the active record in the data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.activerecord?view=word-pia"/>
  public MailMergeActiveRecord ActiveRecord { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the first record number for the merge.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.firstrecord?view=word-pia"/>
  public int FirstRecord { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the last record number for the merge.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.lastrecord?view=word-pia"/>
  public int LastRecord { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the mail merge field names collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.fieldnames?view=word-pia"/>
  public IMailMergeFieldNames FieldNames { get; }

  /// <summary>
  /// Returns the mail merge data fields collection for the active record.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.datafields?view=word-pia"/>
  public IMailMergeDataFields DataFields { get; }

  /// <summary>
  /// Returns the number of records in the data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.recordcount?view=word-pia"/>
  public int RecordCount { get; }

  /// <summary>
  /// Returns or sets whether the current record is included in the merge.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.included?view=word-pia"/>
  public bool Included { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether the current record has an invalid address.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidaddress?view=word-pia"/>
  public bool InvalidAddress { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets comments about why the current record is invalid.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidcomments?view=word-pia"/>
  public string InvalidComments { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the mapped data fields collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.mappeddatafields?view=word-pia"/>
  public IMappedDataFields MappedDataFields { get; }

  /// <summary>
  /// Returns the source table name for the mail merge data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.tablename?view=word-pia"/>
  public string TableName { get; }
}
