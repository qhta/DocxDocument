namespace DocumentModel.Wordprocessing;


/// <summary>
///   Mail Merge Settings.
/// </summary>
public partial class MailMerge
{
  
  /// <summary>
  ///   Source Document Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDocumentKind? MainDocumentType { get; set; }
  
  
  /// <summary>
  ///   Query Contains Link to External Query File.
  /// </summary>
  public DocumentModel.Wordprocessing.LinkToQuery? LinkToQuery { get; set; }
  
  
  /// <summary>
  ///   Data Source Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDataKind? DataType { get; set; }
  
  
  /// <summary>
  ///   Data Source Connection String.
  /// </summary>
  public DocumentModel.Wordprocessing.ConnectString? ConnectString { get; set; }
  
  
  /// <summary>
  ///   Query For Data Source Records To Merge.
  /// </summary>
  public DocumentModel.Wordprocessing.Query? Query { get; set; }
  
  
  /// <summary>
  ///   Data Source File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.DataSourceReference? DataSourceReference { get; set; }
  
  
  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  public DocumentModel.Wordprocessing.HeaderSource? HeaderSource { get; set; }
  
  
  /// <summary>
  ///   Remove Blank Lines from Merged Documents.
  /// </summary>
  public DocumentModel.Wordprocessing.DoNotSuppressBlankLines? DoNotSuppressBlankLines { get; set; }
  
  
  /// <summary>
  ///   Merged Document Destination.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeDestinationKind? Destination { get; set; }
  
  
  /// <summary>
  ///   Column Containing E-mail Address.
  /// </summary>
  public DocumentModel.Wordprocessing.AddressFieldName? AddressFieldName { get; set; }
  
  
  /// <summary>
  ///   Merged E-mail or Fax Subject Line.
  /// </summary>
  public DocumentModel.Wordprocessing.MailSubject? MailSubject { get; set; }
  
  
  /// <summary>
  ///   Merged Document To E-Mail Attachment.
  /// </summary>
  public DocumentModel.Wordprocessing.MailAsAttachment? MailAsAttachment { get; set; }
  
  
  /// <summary>
  ///   View Merged Data Within Document.
  /// </summary>
  public DocumentModel.Wordprocessing.ViewMergedData? ViewMergedData { get; set; }
  
  
  /// <summary>
  ///   Record Currently Displayed In Merged Document.
  /// </summary>
  public DocumentModel.Wordprocessing.ActiveRecord? ActiveRecord { get; set; }
  
  
  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckErrors? CheckErrors { get; set; }
  
  
  /// <summary>
  ///   Office Data Source Object Settings.
  /// </summary>
  public DocumentModel.Wordprocessing.DataSourceObject? DataSourceObject { get; set; }
  
}
