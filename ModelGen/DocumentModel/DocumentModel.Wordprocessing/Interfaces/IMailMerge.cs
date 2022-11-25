namespace DocumentModel.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public interface IMailMerge // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDocumentKind? MainDocumentType { get ; set; }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  public System.Boolean? LinkToQuery { get ; set; }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDataKind? DataType { get ; set; }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  public System.String? ConnectString { get ; set; }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  public System.String? Query { get ; set; }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.IRelationshipType? DataSourceReference { get ; set; }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.IRelationshipType? HeaderSource { get ; set; }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  public System.Boolean? DoNotSuppressBlankLines { get ; set; }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDestinationKind? Destination { get ; set; }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  public System.String? AddressFieldName { get ; set; }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  public System.String? MailSubject { get ; set; }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  public System.Boolean? MailAsAttachment { get ; set; }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  public System.Boolean? ViewMergedData { get ; set; }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  public System.Int32? ActiveRecord { get ; set; }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  public System.Int32? CheckErrors { get ; set; }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public DocumentModel.Wordprocessing.IDataSourceObject? DataSourceObject { get ; set; }
  
}
