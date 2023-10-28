namespace DocumentModel.Wordprocessing;


/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public partial class DataSourceObject
{
  
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  public DMW.UdlConnectionString? UdlConnectionString { get; set; }
  
  
  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  public DMW.DataSourceTableName? DataSourceTableName { get; set; }
  
  
  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  public DMW.SourceReference? SourceReference { get; set; }
  
  
  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  public DMW.ColumnDelimiter? ColumnDelimiter { get; set; }
  
  
  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  public DMW.MailMergeSourceKind? MailMergeSource { get; set; }
  
  
  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  public DMW.FirstRowHeader? FirstRowHeader { get; set; }
  
  public DMW.RecipientDataReference? RecipientDataReference { get; set; }
  
}
