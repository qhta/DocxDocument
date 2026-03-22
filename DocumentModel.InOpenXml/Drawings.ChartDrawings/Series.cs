namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the Series Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.Series))]
public class Series: ModelElement<DXO16DCD.Series>
{
  /// <summary>
  /// Specifies the layout id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.LayoutId))]
  public SeriesLayout? LayoutId { get => _LayoutId; set => UpdateField(ref _LayoutId, value, nameof(LayoutId)); }
  private SeriesLayout? _LayoutId;
  /// <summary>
  /// Specifies the hidden.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.Hidden))]
  public bool? Hidden { get => _Hidden; set => UpdateField(ref _Hidden, value, nameof(Hidden)); }
  private bool? _Hidden;
  /// <summary>
  /// Specifies the owner idx.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.OwnerIdx))]
  public UInt32? OwnerIdx { get => _OwnerIdx; set => UpdateField(ref _OwnerIdx, value, nameof(OwnerIdx)); }
  private UInt32? _OwnerIdx;
  /// <summary>
  /// Specifies the unique id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.UniqueId))]
  public string? UniqueId { get => _UniqueId; set => UpdateField(ref _UniqueId, value, nameof(UniqueId)); }
  private string? _UniqueId;
  /// <summary>
  /// Specifies the format idx.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.FormatIdx))]
  public UInt32? FormatIdx { get => _FormatIdx; set => UpdateField(ref _FormatIdx, value, nameof(FormatIdx)); }
  private UInt32? _FormatIdx;
  /// <summary>
  /// Specifies the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.Text))]
  public Text? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }
  private Text? _Text;
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }
  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the value colors.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.ValueColors))]
  public ValueColors? ValueColors
  {
    get => _ValueColors;
    set => UpdateField(ref _ValueColors, value, nameof(ValueColors));
  }
  private ValueColors? _ValueColors;
  /// <summary>
  /// Specifies the value color positions.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Series.ValueColorPositions))]
  public ValueColorPositions? ValueColorPositions
  {
    get => _ValueColorPositions;
    set => UpdateField(ref _ValueColorPositions, value, nameof(ValueColorPositions));
  }
  private ValueColorPositions? _ValueColorPositions;
  /// <summary>
  /// Specifies the data points.
  /// </summary>
  public DataPoints? DataPoints { get => _DataPoints; set => UpdateField(ref _DataPoints, value, nameof(DataPoints)); }
  private DataPoints? _DataPoints;
  /// <summary>
  /// Specifies the data labels.
  /// </summary>
  public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }
  private DataLabels? _DataLabels;
  /// <summary>
  /// Specifies the data id.
  /// </summary>
  public UInt32? DataId { get => _DataId; set => UpdateField(ref _DataId, value, nameof(DataId)); }
  private UInt32? _DataId;
  /// <summary>
  /// Specifies the series layout properties.
  /// </summary>
  public SeriesLayoutProperties? SeriesLayoutProperties
  {
    get => _SeriesLayoutProperties;
    set => UpdateField(ref _SeriesLayoutProperties, value, nameof(SeriesLayoutProperties));
  }
  private SeriesLayoutProperties? _SeriesLayoutProperties;
  /// <summary>
  /// Specifies the axis ids.
  /// </summary>
  public StringList? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
  private StringList? _AxisIds;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}