namespace DocumentModel.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMailMergeSource))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFieldMapData))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFirstRowHeader))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISourceReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRecipientDataReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUdlConnectionString))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDataSourceTableName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColumnDelimiter))]
public interface IDataSourceObject // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public IMailMergeSource? MailMergeSource { get ; set; }
  
  /// <summary>
  /// First Row of Data Source Contains Column Names.
  /// </summary>
  public IFirstRowHeader? FirstRowHeader { get ; set; }
  
}
