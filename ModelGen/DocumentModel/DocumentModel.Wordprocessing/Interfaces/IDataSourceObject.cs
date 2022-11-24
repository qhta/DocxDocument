namespace DocumentModel.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public interface IDataSourceObject // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// UDL Connection String.
  /// </summary>
  public IUdlConnectionString? UdlConnectionString { get ; set; }
  
  /// <summary>
  /// Data Source Table Name.
  /// </summary>
  public IDataSourceTableName? DataSourceTableName { get ; set; }
  
  /// <summary>
  /// ODSO Data Source File Path.
  /// </summary>
  public ISourceReference? SourceReference { get ; set; }
  
  /// <summary>
  /// Column Delimiter for Data Source.
  /// </summary>
  public IColumnDelimiter? ColumnDelimiter { get ; set; }
  
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues>? MailMergeSource { get ; set; }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public IFirstRowHeader? FirstRowHeader { get ; set; }
  
}
