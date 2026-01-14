namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents mail merge settings for a WordprocessingML document.
/// This interface provides properties for configuring the main document type, data source, queries, destination, email settings, error reporting, and Office Data Source Object (ODSO) settings, enabling advanced mail merge operations and customization.
/// </summary>
public class MailMerge: ModelElement
{
  /// <summary>
  /// Source document type for the mail merge (e.g., form letter, email, envelope).
  /// </summary>
  public MailMergeDocumentKind? MainDocumentType { get; set; }
  
  /// <summary>
  /// Indicates whether the query contains a link to an external query file.
  /// </summary>
  public bool? LinkToQuery { get; set; }
  
  /// <summary>
  /// Data source type for the mail merge (e.g., database, spreadsheet, text file).
  /// </summary>
  public MailMergeDataKind? DataType { get; set; }
  
  /// <summary>
  /// Connection string used to connect to the data source.
  /// </summary>
  public string? ConnectString { get; set; }
  
  /// <summary>
  /// Query used to select records from the data source for merging.
  /// </summary>
  public string? Query { get; set; }
  
  /// <summary>
  /// File path reference to the data source.
  /// </summary>
  public RelationshipType? DataSourceReference { get; set; }
  
  /// <summary>
  /// File path reference to the header definition file.
  /// </summary>
  public RelationshipType? HeaderSource { get; set; }
  
  /// <summary>
  /// Indicates whether blank lines should be removed from merged documents.
  /// </summary>
  public bool? DoNotSuppressBlankLines { get; set; }
  
  /// <summary>
  /// Destination for the merged document (e.g., new document, printer, email).
  /// </summary>
  public MailMergeDestinationKind? Destination { get; set; }
  
  /// <summary>
  /// Name of the column containing email addresses for email merges.
  /// </summary>
  public string? AddressFieldName { get; set; }
  
  /// <summary>
  /// Subject line for merged email or fax messages.
  /// </summary>
  public string? MailSubject { get; set; }
  
  /// <summary>
  /// Indicates whether the merged document should be sent as an email attachment.
  /// </summary>
  public bool? MailAsAttachment { get; set; }
  
  /// <summary>
  /// Indicates whether merged data should be displayed within the document.
  /// </summary>
  public bool? ViewMergedData { get; set; }
  
  /// <summary>
  /// Record currently displayed in the merged document.
  /// </summary>
  public Int32? ActiveRecord { get; set; }
  
  /// <summary>
  /// Mail merge error reporting setting, specifying the error handling mode.
  /// </summary>
  public Int32? CheckErrors { get; set; }
  
  /// <summary>
  /// Office Data Source Object (ODSO) settings for advanced mail merge configuration.
  /// </summary>
  public DataSourceObject? DataSourceObject { get; set; }
}