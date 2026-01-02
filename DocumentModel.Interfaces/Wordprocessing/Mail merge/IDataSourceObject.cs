namespace DocumentModel.Wordprocessing;

/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public interface IDataSourceObject: IModelElement
{
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  public string? UdlConnectionString { get; set; }
  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  public string? DataSourceTableName { get; set; }
  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  public IRelationshipType? SourceReference { get; set; }
  /// <summary>
  ///   IColumn Delimiter for Data Source.
  /// </summary>
  public UInt32? ColumnDelimiter { get; set; }
  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  public MailMergeSourceKind? MailMergeSource { get; set; }
  /// <summary>
  ///   First Row of Data Source Contains IColumn Names.
  /// </summary>
  public bool? FirstRowHeader { get; set; }
  /// <summary>
  /// Collection of Field Map Data.
  /// </summary>
  public IFieldMapDataCollection? FieldMap { get; set; }
  /// <summary>
  /// Recipient Data Reference.
  /// </summary>
  public IRelationshipType? RecipientDataReference { get; set; }
}