namespace DocumentModel.Wordprocessing;


/// <summary>
///   Mail Merge Settings.
/// </summary>
public partial class MailMerge
{
  
  /// <summary>
  ///   Source Document Type.
  /// </summary>
  public DMW.MailMergeDocumentKind? MainDocumentType { get; set; }
  
  
  /// <summary>
  ///   Query Contains Link to External Query File.
  /// </summary>
  public DMW.LinkToQuery? LinkToQuery { get; set; }
  
  
  /// <summary>
  ///   Data Source Type.
  /// </summary>
  public DMW.MailMergeDataKind? DataType { get; set; }
  
  
  /// <summary>
  ///   Data Source Connection String.
  /// </summary>
  public DMW.ConnectString? ConnectString { get; set; }
  
  
  /// <summary>
  ///   Query For Data Source Records To Merge.
  /// </summary>
  public DMW.Query? Query { get; set; }
  
  
  /// <summary>
  ///   Data Source File Path.
  /// </summary>
  public DMW.DataSourceReference? DataSourceReference { get; set; }
  
  
  /// <summary>
  ///   Header Definition File Path.
  /// </summary>
  public DMW.HeaderSource? HeaderSource { get; set; }
  
  
  /// <summary>
  ///   Remove Blank Lines from Merged Documents.
  /// </summary>
  public DMW.DoNotSuppressBlankLines? DoNotSuppressBlankLines { get; set; }
  
  
  /// <summary>
  ///   Merged Document Destination.
  /// </summary>
  public DMW.MailMergeDestinationKind? Destination { get; set; }
  
  
  /// <summary>
  ///   Column Containing E-mail Address.
  /// </summary>
  public DMW.AddressFieldName? AddressFieldName { get; set; }
  
  
  /// <summary>
  ///   Merged E-mail or Fax Subject Line.
  /// </summary>
  public DMW.MailSubject? MailSubject { get; set; }
  
  
  /// <summary>
  ///   Merged Document To E-Mail Attachment.
  /// </summary>
  public DMW.MailAsAttachment? MailAsAttachment { get; set; }
  
  
  /// <summary>
  ///   View Merged Data Within Document.
  /// </summary>
  public DMW.ViewMergedData? ViewMergedData { get; set; }
  
  
  /// <summary>
  ///   Record Currently Displayed In Merged Document.
  /// </summary>
  public DMW.ActiveRecord? ActiveRecord { get; set; }
  
  
  /// <summary>
  ///   Mail Merge Error Reporting Setting.
  /// </summary>
  public DMW.CheckErrors? CheckErrors { get; set; }
  
  
  /// <summary>
  ///   Office Data Source Object Settings.
  /// </summary>
  public DMW.DataSourceObject? DataSourceObject { get; set; }
  
}
