namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a data label for a chart data point or series.
///   Data labels display values, names, or other information directly on the chart, providing context and clarity for the data being visualized.
///   This class allows configuration of label content, formatting, position, and display options.
/// </summary>
[OpenXmlType(typeof(DXDC.DataLabel))]
[DataContract]
[XmlRoot("DataLabel", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataLabel: ModelElement<DXDC.DataLabel>
{
  /// <summary>
  ///   Index of the data label within the series or collection.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.DataLabel.Index))]
  public UInt32? Index
  {
    get => _Index ??= GetProperty<UInt32?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private UInt32? _Index;

  /// <summary>
  ///   Indicates whether the data label is deleted and should not be displayed.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Delete))]
  public bool? Delete
  {
    get => _Delete ??= GetElement<bool, DXDC.Delete>(GetUpdatableElement());
    set => UpdateField(ref _Delete, value, nameof(Delete));
  }

  private bool? _Delete;

  /// <summary>
  ///   Layout configuration for the data label, controlling its position and alignment.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Layout))]
  public Layout? Layout
  {
    get => _Layout ??= GetElement<Layout, DXDC.Layout>(GetUpdatableElement());
    set => UpdateField(ref _Layout, value, nameof(Layout));
  }

  private Layout? _Layout;

  /// <summary>
  ///   Text content and formatting for the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartText))]
  public ChartText? ChartText
  {
    get => _ChartText ??= GetElement<ChartText, DXDC.ChartText>(GetUpdatableElement());
    set => UpdateField(ref _ChartText, value, nameof(ChartText));
  }

  private ChartText? _ChartText;

  /// <summary>
  ///   Number format applied to the value displayed in the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumberingFormat))]
  public NumberingFormat? NumberingFormat
  {
    get => _NumberingFormat ??= GetElement<NumberingFormat, DXDC.NumberingFormat>(GetUpdatableElement());
    set => UpdateField(ref _NumberingFormat, value, nameof(NumberingFormat));
  }

  private NumberingFormat? _NumberingFormat;

  /// <summary>
  ///   Visual and shape properties for the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetElement<ChartShapeProperties, DXDC.ChartShapeProperties>(GetUpdatableElement());
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Text formatting and style properties for the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.TextProperties))]
  public TextProperties? TextProperties
  {
    get => _TextProperties ??= GetElement<TextProperties, DXDC.TextProperties>(GetUpdatableElement());
    set => UpdateField(ref _TextProperties, value, nameof(TextProperties));
  }

  private TextProperties? _TextProperties;

  /// <summary>
  ///   Position of the data label relative to the data point.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabelPosition))]
  public XlDataLabelPosition? DataLabelPosition
  {
    get => _DataLabelPosition ??= GetElement<XlDataLabelPosition, DXDC.DataLabelPosition>(GetUpdatableElement());
    set => UpdateField(ref _DataLabelPosition, value, nameof(DataLabelPosition));
  }

  private XlDataLabelPosition? _DataLabelPosition;

  /// <summary>
  ///   Indicates whether the legend key is shown in the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowLegendKey))]
  public bool? ShowLegendKey
  {
    get => _ShowLegendKey ??= GetElement<bool, DXDC.ShowLegendKey>(GetUpdatableElement());
    set => UpdateField(ref _ShowLegendKey, value, nameof(ShowLegendKey));
  }

  private bool? _ShowLegendKey;

  /// <summary>
  ///   Indicates whether the value is shown in the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowValue))]
  public bool? ShowValue
  {
    get => _ShowValue ??= GetElement<bool, DXDC.ShowValue>(GetUpdatableElement());
    set => UpdateField(ref _ShowValue, value, nameof(ShowValue));
  }

  private bool? _ShowValue;

  /// <summary>
  ///   Indicates whether the category name is shown in the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowCategoryName))]
  public bool? ShowCategoryName
  {
    get => _ShowCategoryName ??= GetElement<bool, DXDC.ShowCategoryName>(GetUpdatableElement());
    set => UpdateField(ref _ShowCategoryName, value, nameof(ShowCategoryName));
  }

  private bool? _ShowCategoryName;

  /// <summary>
  ///   Indicates whether the series name is shown in the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowSeriesName))]
  public bool? ShowSeriesName
  {
    get => _ShowSeriesName ??= GetElement<bool, DXDC.ShowSeriesName>(GetUpdatableElement());
    set => UpdateField(ref _ShowSeriesName, value, nameof(ShowSeriesName));
  }

  private bool? _ShowSeriesName;

  /// <summary>
  ///   Indicates whether the percentage value is shown in the data label.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowPercent))]
  public bool? ShowPercent
  {
    get => _ShowPercent ??= GetElement<bool, DXDC.ShowPercent>(GetUpdatableElement());
    set => UpdateField(ref _ShowPercent, value, nameof(ShowPercent));
  }

  private bool? _ShowPercent;

  /// <summary>
  ///   Indicates whether the bubble size is shown in the data label (for bubble charts).
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ShowBubbleSize))]
  public bool? ShowBubbleSize
  {
    get => _ShowBubbleSize ??= GetElement<bool, DXDC.ShowBubbleSize>(GetUpdatableElement());
    set => UpdateField(ref _ShowBubbleSize, value, nameof(ShowBubbleSize));
  }

  private bool? _ShowBubbleSize;

  /// <summary>
  ///   Separator string used between different parts of the data label content.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Separator))]
  public string? Separator
  {
    get => _Separator ??= GetElement<string, DXDC.Separator>(GetUpdatableElement());
    set => UpdateField(ref _Separator, value, nameof(Separator));
  }

  private string? _Separator;

  /// <summary>
  ///   Collection of extension elements for additional data label customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DLblExtensionList))]
  public DLblExtensionList? DLblExtensionList
  {
    get => _DLblExtensionList ??= GetElement<DLblExtensionList, DXDC.DLblExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _DLblExtensionList, value, nameof(DLblExtensionList));
  }

  private DLblExtensionList? _DLblExtensionList;
}