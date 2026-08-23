namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents Office Data Source Object (ODSO) settings for mail merge in a WordprocessingML document.
/// This class provides properties for UDL connection strings, data source table names, file references, delimiters, source types, header row configuration, field mapping, and recipient data references, enabling advanced configuration and management of mail merge data sources.
/// </summary>
[OpenXmlType(typeof(DXW.DataSourceObject))]
[DataContract]
[XmlRoot("DataSourceObject", Namespace = "DocumentModel.Wordprocessing")]
public partial class DataSourceObject: ModelElement<DXW.DataSourceObject>
{
  /// <summary>
  /// UDL connection string used to connect to the data source.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DataSourceObject.UdlConnectionString))]
  public string? UdlConnectionString
  {
    get => _UdlConnectionString ??= GetProperty<string?>(GetUpdatableElement()?.UdlConnectionString);
    set => UpdateField(ref _UdlConnectionString, value, nameof(UdlConnectionString));
  }

  private string? _UdlConnectionString;

  /// <summary>
  /// Name of the data source table used for the mail merge.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DataSourceObject.DataSourceTableName))]
  public string? DataSourceTableName
  {
    get => _DataSourceTableName ??= GetProperty<string?>(GetUpdatableElement()?.DataSourceTableName);
    set => UpdateField(ref _DataSourceTableName, value, nameof(DataSourceTableName));
  }

  private string? _DataSourceTableName;

  /// <summary>
  /// File path reference to the ODSO data source.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DataSourceObject.SourceReference))]
  public SourceReference? SourceReference
  {
    get => _SourceReference ??= GetProperty<SourceReference?>(GetUpdatableElement()?.SourceReference);
    set => UpdateField(ref _SourceReference, value, nameof(SourceReference));
  }

  private SourceReference? _SourceReference;

  /// <summary>
  /// Column delimiter used in the data source, specified as a Unicode value.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DataSourceObject.ColumnDelimiter))]
  public UInt32? ColumnDelimiter
  {
    get => _ColumnDelimiter ??= GetProperty<UInt32?>(GetUpdatableElement()?.ColumnDelimiter);
    set => UpdateField(ref _ColumnDelimiter, value, nameof(ColumnDelimiter));
  }

  private UInt32? _ColumnDelimiter;

  /// <summary>
  /// Type of the ODSO data source (e.g., database, spreadsheet, text file).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DataSourceObject.MailMergeSource))]
  public MailMergeSource? MailMergeSource
  {
    get => _MailMergeSource ??= GetProperty<MailMergeSource?>(GetUpdatableElement()?.MailMergeSource);
    set => UpdateField(ref _MailMergeSource, value, nameof(MailMergeSource));
  }

  private MailMergeSource? _MailMergeSource;

  /// <summary>
  /// Indicates whether the first row of the data source contains column names.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DataSourceObject.FirstRowHeader))]
  public bool? FirstRowHeader
  {
    get => _FirstRowHeader ??= GetProperty<bool?>(GetUpdatableElement()?.FirstRowHeader);
    set => UpdateField(ref _FirstRowHeader, value, nameof(FirstRowHeader));
  }

  private bool? _FirstRowHeader;

  /// <summary>
  /// Collection of field map data, specifying how data source fields are mapped to merge fields.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FieldMapData))]
  public FieldMapData? FieldMap
  {
    get => _FieldMap ??= GetElement<FieldMapData, DXW.FieldMapData>(GetUpdatableElement());
    set => UpdateField(ref _FieldMap, value, nameof(FieldMap));
  }

  private FieldMapData? _FieldMap;

  /// <summary>
  /// Reference to recipient data, specifying an external file or data part containing recipient information.
  /// </summary>
  [OpenXmlElement(typeof(DXW.RecipientDataReference))]
  public RecipientDataReference? RecipientDataReference
  {
    get => _recipientDataReference ??=
      GetElement<RecipientDataReference, DXW.RecipientDataReference>(GetUpdatableElement());
    set => UpdateField(ref _recipientDataReference, value, nameof(RecipientDataReference));
  }

  private RecipientDataReference? _recipientDataReference;
}