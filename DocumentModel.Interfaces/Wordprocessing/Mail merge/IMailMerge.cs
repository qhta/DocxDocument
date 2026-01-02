namespace DocumentModel.Wordprocessing;

/// <summary>
///   Mail Merge Settings.
/// </summary>
public interface IMailMerge: IModelElement
{
  /// <summary>
  ///   Source Document Type.
  /// </summary>
  public MailMergeDocumentKind? MainDocumentType { get; set; }
  /// <summary>
  ///   Query Contains Link to External Query File.
  /// </summary>
  public bool? LinkToQuery { get; set; }
  /// <summary>
  ///   Data Source Type.
  /// </summary>
  public MailMergeDataKind? DataType { get; set; }
  /// <summary>
  ///   Data Source Connection String.
  /// </summary>
  public string? ConnectString { get; set; }
  /// <summary>
  ///   Query For Data Source Records To Merge.
  /// </summary>
  public string? Query { get; set; }
  /// <summary>
  ///   Data Source File Path.
  /// </summary>
  public IRelationshipType? DataSourceReference { get; set; }
  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  public IRelationshipType? HeaderSource { get; set; }
  /// <summary>
  ///   Remove Blank Lines from Merged Documents.
  /// </summary>
  public bool? DoNotSuppressBlankLines { get; set; }
  /// <summary>
  ///   Merged Document Destination.
  /// </summary>
  public MailMergeDestinationKind? Destination { get; set; }
  /// <summary>
  ///   IColumn Containing E-mail Address.
  /// </summary>
  public string? AddressFieldName { get; set; }
  /// <summary>
  ///   Merged E-mail or Fax Subject Line.
  /// </summary>
  public string? MailSubject { get; set; }
  /// <summary>
  ///   Merged Document To E-Mail Attachment.
  /// </summary>
  public bool? MailAsAttachment { get; set; }
  /// <summary>
  ///   View Merged Data Within Document.
  /// </summary>
  public bool? ViewMergedData { get; set; }
  /// <summary>
  ///   Record Currently Displayed In Merged Document.
  /// </summary>
  public Int32? ActiveRecord { get; set; }
  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  public Int32? CheckErrors { get; set; }
  /// <summary>
  ///   Office Data Source Object Settings.
  /// </summary>
  public IDataSourceObject? DataSourceObject { get; set; }
}