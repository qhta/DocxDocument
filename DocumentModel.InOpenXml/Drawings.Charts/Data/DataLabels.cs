namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of data labels for a chart series or data points.
///   Data labels display values, names, or other information directly on the chart, providing context and clarity for the data being visualized.
///   This class allows configuration of label formatting, display options, and additional label features.
/// </summary>
[OpenXmlType(typeof(DXDC.DataLabels))]
public partial class DataLabels: ModelElementCollection<DataLabel, DXDC.DataLabels, DXDC.DataLabel>
{
  /// <summary>
  ///   Indicates whether all data labels are deleted and should not be displayed.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Delete))]
  public bool? Delete { get => _Delete; set => UpdateField(ref _Delete, value, nameof(Delete)); }
  private bool? _Delete;
  /// <summary>
  ///   Number format applied to the values displayed in the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumberingFormat))]
  public NumberingFormat? NumberingFormat
  {
    get => _NumberingFormat;
    set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat));
  }
  private NumberingFormat? _NumberingFormat;
  /// <summary>
  ///   Visual and shape properties for the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }
  private ChartShapeProperties? _ChartShapeProperties;
  /// <summary>
  ///   Text formatting and style properties for the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.TextProperties))]
  public TextProperties? TextProperties
  {
    get => _TextProperties;
    set => UpdateField(ref _TextProperties, value, nameof(TextProperties));
  }
  private TextProperties? _TextProperties;
  /// <summary>
  ///   Position of the data labels relative to the data points.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabelPosition))]
  public XlDataLabelPosition? DataLabelPosition
  {
    get => _DataLabelPosition;
    set => UpdateField(ref _DataLabelPosition, value, nameof(DataLabelPosition));
  }
  private XlDataLabelPosition? _DataLabelPosition;
  /// <summary>
  ///   Indicates whether the legend key is shown in the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowLegendKey))]
  public bool? ShowLegendKey
  {
    get => _ShowLegendKey;
    set => UpdateField(ref _ShowLegendKey, value, nameof(ShowLegendKey));
  }
  private bool? _ShowLegendKey;
  /// <summary>
  ///   Indicates whether the value is shown in the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowValue))]
  public bool? ShowValue { get => _ShowValue; set => UpdateField(ref _ShowValue, value, nameof(ShowValue)); }
  private bool? _ShowValue;
  /// <summary>
  ///   Indicates whether the category name is shown in the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowCategoryName))]
  public bool? ShowCategoryName
  {
    get => _ShowCategoryName;
    set => UpdateField(ref _ShowCategoryName, value, nameof(ShowCategoryName));
  }
  private bool? _ShowCategoryName;
  /// <summary>
  ///   Indicates whether the series name is shown in the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowSeriesName))]
  public bool? ShowSeriesName
  {
    get => _ShowSeriesName;
    set => UpdateField(ref _ShowSeriesName, value, nameof(ShowSeriesName));
  }
  private bool? _ShowSeriesName;
  /// <summary>
  ///   Indicates whether the percentage value is shown in the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowPercent))]
  public bool? ShowPercent { get => _ShowPercent; set => UpdateField(ref _ShowPercent, value, nameof(ShowPercent)); }
  private bool? _ShowPercent;
  /// <summary>
  ///   Indicates whether the bubble size is shown in the data labels (for bubble charts).
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowBubbleSize))]
  public bool? ShowBubbleSize
  {
    get => _ShowBubbleSize;
    set => UpdateField(ref _ShowBubbleSize, value, nameof(ShowBubbleSize));
  }
  private bool? _ShowBubbleSize;
  /// <summary>
  ///   Separator string used between different parts of the data label content.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Separator))]
  public string? Separator { get => _Separator; set => UpdateField(ref _Separator, value, nameof(Separator)); }
  private string? _Separator;
  /// <summary>
  ///   Indicates whether leader lines are shown for the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowLeaderLines))]
  public bool? ShowLeaderLines
  {
    get => _ShowLeaderLines;
    set => UpdateField(ref _ShowLeaderLines, value, nameof(ShowLeaderLines));
  }
  private bool? _ShowLeaderLines;
  /// <summary>
  ///   Leader lines configuration for the data labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.LeaderLines))]
  public LeaderLines? LeaderLines
  {
    get => _LeaderLines;
    set => UpdateField(ref _LeaderLines, value, nameof(LeaderLines));
  }
  private LeaderLines? _LeaderLines;
  /// <summary>
  ///   Collection of extension elements for additional data label customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DLblsExtensionList))]
  public DLblsExtensionList? DLblsExtensionList
  {
    get => _DLblsExtensionList;
    set => UpdateField(ref _DLblsExtensionList, value, nameof(DLblsExtensionList));
  }
  private DLblsExtensionList? _DLblsExtensionList;
}