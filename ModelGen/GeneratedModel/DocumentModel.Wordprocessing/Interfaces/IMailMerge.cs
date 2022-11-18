namespace DocumentModel.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IActiveRecord))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICheckErrors))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDataType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDestination))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMainDocumentType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDataSourceObject))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILinkToQuery))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoNotSuppressBlankLines))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMailAsAttachment))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IViewMergedData))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDataSourceReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHeaderSource))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IConnectString))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IQuery))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAddressFieldName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMailSubject))]
public interface IMailMerge // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public IMainDocumentType? MainDocumentType { get ; set; }
  
  /// <summary>
  /// Query Contains Link to External Query File.
  /// </summary>
  public ILinkToQuery? LinkToQuery { get ; set; }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public IDataType? DataType { get ; set; }
  
  /// <summary>
  /// Data Source Connection String.
  /// </summary>
  public IConnectString? ConnectString { get ; set; }
  
  /// <summary>
  /// Query For Data Source Records To Merge.
  /// </summary>
  public DocumentModel.Wordprocessing.IQuery? Query { get ; set; }
  
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
  public IDestination? Destination { get ; set; }
  
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
