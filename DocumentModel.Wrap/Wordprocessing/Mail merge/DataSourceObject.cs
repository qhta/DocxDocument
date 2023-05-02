namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public class DataSourceObject: ModelElement
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
  public RelationshipType? SourceReference { get; set; }

  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  public UInt32? ColumnDelimiter { get; set; }

  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  public MailMergeSourceKind? MailMergeSource { get; set; }

  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  public bool? FirstRowHeader { get; set; }

  public Collection<FieldMapData>? FieldMapDatas { get; set; }

  public RelationshipType? RecipientDataReference { get; set; }
}