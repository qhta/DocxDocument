namespace DocumentModel.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public interface IMailMerge // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues>? MainDocumentType { get ; set; }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  public ILinkToQuery? LinkToQuery { get ; set; }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues>? DataType { get ; set; }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  public IConnectString? ConnectString { get ; set; }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  public IQuery? Query { get ; set; }
  
  /// <summary>
  /// Data Source File Path.
  /// </summary>
  public IDataSourceReference? DataSourceReference { get ; set; }
  
  /// <summary>
  /// Header Definition File Path.
  /// </summary>
  public IHeaderSource? HeaderSource { get ; set; }
  
  /// <summary>
  /// Remove Blank Lines from Merged Documents.
  /// </summary>
  public IDoNotSuppressBlankLines? DoNotSuppressBlankLines { get ; set; }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues>? Destination { get ; set; }
  
  /// <summary>
  /// Column Containing E-mail Address.
  /// </summary>
  public IAddressFieldName? AddressFieldName { get ; set; }
  
  /// <summary>
  /// Merged E-mail or Fax Subject Line.
  /// </summary>
  public IMailSubject? MailSubject { get ; set; }
  
  /// <summary>
  /// Merged Document To E-Mail Attachment.
  /// </summary>
  public IMailAsAttachment? MailAsAttachment { get ; set; }
  
  /// <summary>
  /// View Merged Data Within Document.
  /// </summary>
  public IViewMergedData? ViewMergedData { get ; set; }
  
  /// <summary>
  /// Record Currently Displayed In Merged Document.
  /// </summary>
  public IActiveRecord? ActiveRecord { get ; set; }
  
  /// <summary>
  /// Mail Merge Error Reporting Setting.
  /// </summary>
  public ICheckErrors? CheckErrors { get ; set; }
  
  /// <summary>
  /// Office Data Source Object Settings.
  /// </summary>
  public IDataSourceObject? DataSourceObject { get ; set; }
  
}
