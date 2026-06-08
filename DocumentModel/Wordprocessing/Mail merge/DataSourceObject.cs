namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Office Data ISource Object Settings.
/// </summary>
public class DataSourceObject: ModelElement
{
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  public string? UdlConnectionString { get; set; }

  /// <summary>
  ///   Data ISource ITable Name.
  /// </summary>
  public string? DataSourceTableName { get; set; }

  /// <summary>
  ///   ODSO Data ISource File Path.
  /// </summary>
  public RelationshipType? SourceReference { get; set; }

  /// <summary>
  ///   IColumn Delimiter for Data ISource.
  /// </summary>
  public UInt32? ColumnDelimiter { get; set; }

  /// <summary>
  ///   ODSO Data ISource Type.
  /// </summary>
  public MailMergeSourceKind? MailMergeSource { get; set; }

  /// <summary>
  ///   First IRow of Data ISource Contains IColumn Names.
  /// </summary>
  public bool? FirstRowHeader { get; set; }

  public Collection<FieldMapData>? FieldMapDatas { get; set; }

  public RelationshipType? RecipientDataReference { get; set; }
}
