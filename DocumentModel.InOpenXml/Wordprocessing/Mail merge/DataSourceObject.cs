namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents Office Data Source Object (ODSO) settings for mail merge in a WordprocessingML document.
/// This class provides properties for UDL connection strings, data source table names, file references, delimiters, source types, header row configuration, field mapping, and recipient data references, enabling advanced configuration and management of mail merge data sources.
/// </summary>
public partial class DataSourceObject : ModelElement<DXW.DataSourceObject>
{
    /// <summary>
    /// UDL connection string used to connect to the data source.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.DataSourceObject.UdlConnectionString))]
    public string? UdlConnectionString { get => _UdlConnectionString; set => UpdateField(ref _UdlConnectionString, value, nameof(UdlConnectionString)); }

    private string? _UdlConnectionString;
    /// <summary>
    /// Name of the data source table used for the mail merge.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.DataSourceObject.DataSourceTableName))]
    public string? DataSourceTableName { get => _DataSourceTableName; set => UpdateField(ref _DataSourceTableName, value, nameof(DataSourceTableName)); }

    private string? _DataSourceTableName;
    /// <summary>
    /// File path reference to the ODSO data source.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.DataSourceObject.SourceReference))]
    public SourceReference? SourceReference { get => _SourceReference; set => UpdateField(ref _SourceReference, value, nameof(SourceReference)); }

    private SourceReference? _SourceReference;
    /// <summary>
    /// Column delimiter used in the data source, specified as a Unicode value.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.DataSourceObject.ColumnDelimiter))]
    public UInt32? ColumnDelimiter { get => _ColumnDelimiter; set => UpdateField(ref _ColumnDelimiter, value, nameof(ColumnDelimiter)); }

    private UInt32? _ColumnDelimiter;
    /// <summary>
    /// Type of the ODSO data source (e.g., database, spreadsheet, text file).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.DataSourceObject.MailMergeSource))]
    public MailMergeSourceKind? MailMergeSource { get => _MailMergeSource; set => UpdateField(ref _MailMergeSource, value, nameof(MailMergeSource)); }

    private MailMergeSourceKind? _MailMergeSource;
    /// <summary>
    /// Indicates whether the first row of the data source contains column names.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.DataSourceObject.FirstRowHeader))]
    public bool? FirstRowHeader { get => _FirstRowHeader; set => UpdateField(ref _FirstRowHeader, value, nameof(FirstRowHeader)); }

    private bool? _FirstRowHeader;
    /// <summary>
    /// Collection of field map data, specifying how data source fields are mapped to merge fields.
    /// </summary>
    public FieldMapDataCollection? FieldMap { get => _FieldMap; set => UpdateField(ref _FieldMap, value, nameof(FieldMap)); }

    private FieldMapDataCollection? _FieldMap;
    /// <summary>
    /// Reference to recipient data, specifying an external file or data part containing recipient information.
    /// </summary>
    public RecipientDataReference? RecipientDataReference { get => _RecipientDataReference; set => UpdateField(ref _RecipientDataReference, value, nameof(RecipientDataReference)); }

    private RecipientDataReference? _RecipientDataReference;
}