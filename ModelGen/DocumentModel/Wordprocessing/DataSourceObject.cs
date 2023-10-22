namespace DocumentModel.Wordprocessing;


/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public partial class DataSourceObject
{
  
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  public DocumentModel.Wordprocessing.UdlConnectionString? UdlConnectionString { get; set; }
  
  
  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  public DocumentModel.Wordprocessing.DataSourceTableName? DataSourceTableName { get; set; }
  
  
  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.SourceReference? SourceReference { get; set; }
  
  
  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  public DocumentModel.Wordprocessing.ColumnDelimiter? ColumnDelimiter { get; set; }
  
  
  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeSourceKind? MailMergeSource { get; set; }
  
  
  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  public DocumentModel.Wordprocessing.FirstRowHeader? FirstRowHeader { get; set; }
  
  public DocumentModel.Wordprocessing.RecipientDataReference? RecipientDataReference { get; set; }
  
}
