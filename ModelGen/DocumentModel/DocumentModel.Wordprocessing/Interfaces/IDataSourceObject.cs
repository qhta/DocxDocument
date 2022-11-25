namespace DocumentModel.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public interface IDataSourceObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  public System.String? UdlConnectionString { get ; set; }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public System.String? DataSourceTableName { get ; set; }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.IRelationshipType? SourceReference { get ; set; }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public System.UInt32? ColumnDelimiter { get ; set; }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeSourceKind? MailMergeSource { get ; set; }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public System.Boolean? FirstRowHeader { get ; set; }
  
}
