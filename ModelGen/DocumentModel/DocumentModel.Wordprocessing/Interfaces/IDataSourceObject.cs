namespace DocumentModel.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public interface IDataSourceObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  public String? UdlConnectionString { get ; set; }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public String? DataSourceTableName { get ; set; }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public IRelationshipType? SourceReference { get ; set; }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public UInt32? ColumnDelimiter { get ; set; }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public MailMergeSourceKind? MailMergeSource { get ; set; }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public Boolean? FirstRowHeader { get ; set; }
  
  public Collection<IFieldMapData>? FieldMapDatas { get ; set; }
  
  public IRelationshipType? RecipientDataReference { get ; set; }
  
}
