namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents mail merge settings for a WordprocessingML document.
/// This class provides properties for configuring the main document type, data source, queries, destination, email settings, error reporting, and Office Data Source Object (ODSO) settings, enabling advanced mail merge operations and customization.
/// </summary>
[OpenXmlType(typeof(DXW.MailMerge))]
[XmlRoot("MailMerge", Namespace = "DocumentModel.Wordprocessing")]
public partial class MailMerge : ModelElement<DXW.MailMerge>
{
 /// <summary>
 /// Known properties that can be set in MailMerge.
 /// </summary>
 public static KnownProperties KnownProperties
 {
  get
  {
   if (_KnownProperties == null)
    _KnownProperties = new KnownProperties(typeof(MailMerge));
   return _KnownProperties;
  }
 }

 private static KnownProperties? _KnownProperties;
 /// <summary>
 /// Source document type for the mail merge (e.g., form letter, email, envelope).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.MainDocumentType))]
 public MailMergeMainDocType? MainDocumentType { get => _MainDocumentType; set => UpdateField(ref _MainDocumentType, value, nameof(MainDocumentType)); }

 private MailMergeMainDocType? _MainDocumentType;
 /// <summary>
 /// Indicates whether the query contains a link to an external query file.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.LinkToQuery))]
 public bool? LinkToQuery { get => _LinkToQuery; set => UpdateField(ref _LinkToQuery, value, nameof(LinkToQuery)); }

 private bool? _LinkToQuery;
 /// <summary>
 /// Data source type for the mail merge (e.g., database, spreadsheet, text file).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.DataType))]
 public MailMergeData? DataType { get => _DataType; set => UpdateField(ref _DataType, value, nameof(DataType)); }

 private MailMergeData? _DataType;
 /// <summary>
 /// Connection string used to connect to the data source.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.ConnectString))]
 public string? ConnectString { get => _ConnectString; set => UpdateField(ref _ConnectString, value, nameof(ConnectString)); }

 private string? _ConnectString;
 /// <summary>
 /// Query used to select records from the data source for merging.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.Query))]
 public string? Query { get => _Query; set => UpdateField(ref _Query, value, nameof(Query)); }

 private string? _Query;
 /// <summary>
 /// File path reference to the data source.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.DataSourceReference))]
 public DataSourceReference? DataSourceReference { get => _DataSourceReference; set => UpdateField(ref _DataSourceReference, value, nameof(DataSourceReference)); }

 private DataSourceReference? _DataSourceReference;
 /// <summary>
 /// File path reference to the header definition file.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.HeaderSource))]
 public HeaderSource? HeaderSource { get => _HeaderSource; set => UpdateField(ref _HeaderSource, value, nameof(HeaderSource)); }

 private HeaderSource? _HeaderSource;
 /// <summary>
 /// Indicates whether blank lines should be removed from merged documents.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.DoNotSuppressBlankLines))]
 public bool? DoNotSuppressBlankLines { get => _DoNotSuppressBlankLines; set => UpdateField(ref _DoNotSuppressBlankLines, value, nameof(DoNotSuppressBlankLines)); }

 private bool? _DoNotSuppressBlankLines;
 /// <summary>
 /// Destination for the merged document (e.g., new document, printer, email).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.Destination))]
 public MailMergeDestination? Destination { get => _Destination; set => UpdateField(ref _Destination, value, nameof(Destination)); }

 private MailMergeDestination? _Destination;
 /// <summary>
 /// Name of the column containing email addresses for email merges.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.AddressFieldName))]
 public string? AddressFieldName { get => _AddressFieldName; set => UpdateField(ref _AddressFieldName, value, nameof(AddressFieldName)); }

 private string? _AddressFieldName;
 /// <summary>
 /// Subject line for merged email or fax messages.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.MailSubject))]
 public string? MailSubject { get => _MailSubject; set => UpdateField(ref _MailSubject, value, nameof(MailSubject)); }

 private string? _MailSubject;
 /// <summary>
 /// Indicates whether the merged document should be sent as an email attachment.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.MailAsAttachment))]
 public bool? MailAsAttachment { get => _MailAsAttachment; set => UpdateField(ref _MailAsAttachment, value, nameof(MailAsAttachment)); }

 private bool? _MailAsAttachment;
 /// <summary>
 /// Indicates whether merged data should be displayed within the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.ViewMergedData))]
 public bool? ViewMergedData { get => _ViewMergedData; set => UpdateField(ref _ViewMergedData, value, nameof(ViewMergedData)); }

 private bool? _ViewMergedData;
 /// <summary>
 /// Record currently displayed in the merged document.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.ActiveRecord))]
 public Int32? ActiveRecord { get => _ActiveRecord; set => UpdateField(ref _ActiveRecord, value, nameof(ActiveRecord)); }

 private Int32? _ActiveRecord;
 /// <summary>
 /// Mail merge error reporting setting, specifying the error handling mode.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.CheckErrors))]
 public Int32? CheckErrors { get => _CheckErrors; set => UpdateField(ref _CheckErrors, value, nameof(CheckErrors)); }

 private Int32? _CheckErrors;
 /// <summary>
 /// Office Data Source Object (ODSO) settings for advanced mail merge configuration.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.MailMerge.DataSourceObject))]
 public DataSourceObject? DataSourceObject { get => _DataSourceObject; set => UpdateField(ref _DataSourceObject, value, nameof(DataSourceObject)); }

 private DataSourceObject? _DataSourceObject;
}