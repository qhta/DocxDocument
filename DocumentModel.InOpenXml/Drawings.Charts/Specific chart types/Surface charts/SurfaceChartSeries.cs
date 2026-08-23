namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a surface chart, including index, order, text, shape properties, picture options, axis data, values, 3D bubble option, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.SurfaceChartSeries))]
[DataContract]
[XmlRoot("SurfaceChartSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class SurfaceChartSeries: ModelElement<DXDC.SurfaceChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.Index))]
  public UInt32? Index
  {
    get => _Index ??= GetProperty<UInt32?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private UInt32? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.Order))]
  public UInt32? Order
  {
    get => _Order ??= GetProperty<UInt32?>(GetUpdatableElement()?.Order);
    set => UpdateField(ref _Order, value, nameof(Order));
  }

  private UInt32? _Order;

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.SeriesText))]
  public SeriesText? SeriesText
  {
    get => _SeriesText ??= GetProperty<SeriesText?>(GetUpdatableElement()?.SeriesText);
    set => UpdateField(ref _SeriesText, value, nameof(SeriesText));
  }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetProperty<ChartShapeProperties?>(GetUpdatableElement()?.ChartShapeProperties);
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Picture options for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions ??= GetProperty<PictureOptions?>(GetUpdatableElement()?.PictureOptions);
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  ///   Category axis data for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.CategoryAxisData))]
  public CategoryAxisData? CategoryAxisData
  {
    get => _CategoryAxisData ??= GetProperty<CategoryAxisData?>(GetUpdatableElement()?.CategoryAxisData);
    set => UpdateField(ref _CategoryAxisData, value, nameof(CategoryAxisData));
  }

  private CategoryAxisData? _CategoryAxisData;

  /// <summary>
  ///   Values for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.Values))]
  public Values? Values
  {
    get => _Values ??= GetProperty<Values?>(GetUpdatableElement()?.Values);
    set => UpdateField(ref _Values, value, nameof(Values));
  }

  private Values? _Values;

  /// <summary>
  ///   Indicates whether bubbles are rendered in 3D.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.Bubble3D))]
  public bool? Bubble3D
  {
    get => _Bubble3D ??= GetProperty<bool?>(GetUpdatableElement()?.Bubble3D);
    set => UpdateField(ref _Bubble3D, value, nameof(Bubble3D));
  }

  private bool? _Bubble3D;

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChartSeries.SurfaceSerExtensionList))]
  public SurfaceSerExtensionList? SurfaceSerExtensionList
  {
    get => _SurfaceSerExtensionList ??=
      GetProperty<SurfaceSerExtensionList?>(GetUpdatableElement()?.SurfaceSerExtensionList);
    set => UpdateField(ref _SurfaceSerExtensionList, value, nameof(SurfaceSerExtensionList));
  }

  private SurfaceSerExtensionList? _SurfaceSerExtensionList;
}