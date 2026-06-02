namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource?view=word-pia"/>
public partial interface IMailMergeDataSource : IInteropObject
{
  /// <summary>
  /// Returns the name of the mail merge data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the name of the source used for header fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcename?view=word-pia"/>
  public string HeaderSourceName { get; }

  /// <summary>
  /// Returns the type of the mail merge data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.type?view=word-pia"/>
  public WdMailMergeDataSource Type { get; }

  /// <summary>
  /// Returns the type of source used for header fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.headersourcetype?view=word-pia"/>
  public WdMailMergeDataSource HeaderSourceType { get; }

  /// <summary>
  /// Returns the connection string for the mail merge data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.connectstring?view=word-pia"/>
  public string ConnectString { get; }

  /// <summary>
  /// Returns or sets the query string used to retrieve records.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.querystring?view=word-pia"/>
  public string QueryString { get; set; }

  /// <summary>
  /// Returns or sets the active record in the data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.activerecord?view=word-pia"/>
  public WdMailMergeActiveRecord ActiveRecord { get; set; }

  /// <summary>
  /// Returns or sets the first record number for the merge.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.firstrecord?view=word-pia"/>
  public int FirstRecord { get; set; }

  /// <summary>
  /// Returns or sets the last record number for the merge.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.lastrecord?view=word-pia"/>
  public int LastRecord { get; set; }

  /// <summary>
  /// Returns the mail merge field names collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.fieldnames?view=word-pia"/>
  public MailMergeFieldNames FieldNames { get; }

  /// <summary>
  /// Returns the mail merge data fields collection for the active record.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.datafields?view=word-pia"/>
  public MailMergeDataFields DataFields { get; }

  /// <summary>
  /// Returns the number of records in the data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.recordcount?view=word-pia"/>
  public int RecordCount { get; }

  /// <summary>
  /// Returns or sets whether the current record is included in the merge.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.included?view=word-pia"/>
  public bool Included { get; set; }

  /// <summary>
  /// Returns or sets whether the current record has an invalid address.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidaddress?view=word-pia"/>
  public bool InvalidAddress { get; set; }

  /// <summary>
  /// Returns or sets comments about why the current record is invalid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.invalidcomments?view=word-pia"/>
  public string InvalidComments { get; set; }

  /// <summary>
  /// Returns the mapped data fields collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.mappeddatafields?view=word-pia"/>
  public MappedDataFields MappedDataFields { get; }

  /// <summary>
  /// Returns the source table name for the mail merge data source.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.tablename?view=word-pia"/>
  public string TableName { get; }


  #region methods

/// <summary>
  /// Finds a record in the mail merge data source using Word 2000-compatible behavior.
  /// </summary>
  /// <param name="FindText">Specifies the text to find.</param>
  /// <param name="Field">Specifies the field to search.</param>
  /// <returns>true if the record is found; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergedatasource.findrecord2000?view=word-pia"/>
  public bool FindRecord2000(string FindText, string Field);

  #endregion methods
}
