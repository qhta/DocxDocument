namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents Office Data Source Object (ODSO) settings for mail merge in a WordprocessingML document.
/// This interface provides properties for UDL connection strings, data source table names, file references, delimiters, source types, header row configuration, field mapping, and recipient data references, enabling advanced configuration and management of mail merge data sources.
/// </summary>
public class DataSourceObject: ModelElement<DXW.DataSourceObject>
{
  
  /// <summary>
  /// UDL connection string used to connect to the data source.
  /// </summary>
  public string? UdlConnectionString { get; set; }
  
  /// <summary>
  /// Name of the data source table used for the mail merge.
  /// </summary>
  public string? DataSourceTableName { get; set; }
  
  /// <summary>
  /// File path reference to the ODSO data source.
  /// </summary>
  public SourceReference? SourceReference { get; set; }
  
  /// <summary>
  /// Column delimiter used in the data source, specified as a Unicode value.
  /// </summary>
  public UInt32? ColumnDelimiter { get; set; }
  
  /// <summary>
  /// Type of the ODSO data source (e.g., database, spreadsheet, text file).
  /// </summary>
  public MailMergeSourceKind? MailMergeSource { get; set; }
  
  /// <summary>
  /// Indicates whether the first row of the data source contains column names.
  /// </summary>
  public bool? FirstRowHeader { get; set; }
  
  /// <summary>
  /// Collection of field map data, specifying how data source fields are mapped to merge fields.
  /// </summary>
  public FieldMapDataCollection? FieldMap { get; set; }
  
  /// <summary>
  /// Reference to recipient data, specifying an external file or data part containing recipient information.
  /// </summary>
  public RecipientDataReference? RecipientDataReference { get; set; }
}