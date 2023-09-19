namespace DocumentModel.Wordprocessing;


/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public partial class DataSourceObject
{
  
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  public String? UdlConnectionString { get; set; }
  
  
  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  public String? DataSourceTableName { get; set; }
  
  
  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.RelationshipType? SourceReference { get; set; }
  
  
  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  public UInt32? ColumnDelimiter { get; set; }
  
  
  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeSourceValues? MailMergeSource { get; set; }
  
  
  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  public Boolean? FirstRowHeader { get; set; }
  
  public DocumentModel.Wordprocessing.RelationshipType? RecipientDataReference { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.FieldMapData>? Items { get; set; }
  
}
