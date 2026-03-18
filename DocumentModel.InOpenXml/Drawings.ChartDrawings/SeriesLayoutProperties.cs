namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the SeriesLayoutProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.SeriesLayoutProperties))]
public class SeriesLayoutProperties: ModelElement<DXO16DCD.SeriesLayoutProperties>
{
  /// <summary>
  /// Specifies the parent label layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesLayoutProperties.ParentLabelLayout))]
  public ParentLabelLayout? ParentLabelLayout
  {
    get => _ParentLabelLayout;
    set => UpdateField(ref _ParentLabelLayout, value, nameof(ParentLabelLayout));
  }

  private ParentLabelLayout? _ParentLabelLayout;

  /// <summary>
  /// Specifies the region label layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesLayoutProperties.RegionLabelLayout))]
  public RegionLabelLayoutEnum? RegionLabelLayout
  {
    get => _RegionLabelLayout;
    set => UpdateField(ref _RegionLabelLayout, value, nameof(RegionLabelLayout));
  }

  private RegionLabelLayoutEnum? _RegionLabelLayout;

  /// <summary>
  /// Specifies the series element visibilities.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.SeriesLayoutProperties.SeriesElementVisibilities))]
  public SeriesElementVisibilities? SeriesElementVisibilities
  {
    get => _SeriesElementVisibilities;
    set => UpdateField(ref _SeriesElementVisibilities, value, nameof(SeriesElementVisibilities));
  }

  private SeriesElementVisibilities? _SeriesElementVisibilities;

  /// <summary>
  /// Specifies the aggregation.
  /// </summary>
  public bool? Aggregation { get => _Aggregation; set => UpdateField(ref _Aggregation, value, nameof(Aggregation)); }

  private bool? _Aggregation;

  /// <summary>
  /// Specifies the binning.
  /// </summary>
  public Binning? Binning { get => _Binning; set => UpdateField(ref _Binning, value, nameof(Binning)); }

  private Binning? _Binning;

  /// <summary>
  /// Specifies the geography.
  /// </summary>
  public Geography? Geography { get => _Geography; set => UpdateField(ref _Geography, value, nameof(Geography)); }

  private Geography? _Geography;

  /// <summary>
  /// Specifies the statistics.
  /// </summary>
  public Statistics? Statistics { get => _Statistics; set => UpdateField(ref _Statistics, value, nameof(Statistics)); }

  private Statistics? _Statistics;

  /// <summary>
  /// Specifies the subtotals.
  /// </summary>
  public Subtotals? Subtotals { get => _Subtotals; set => UpdateField(ref _Subtotals, value, nameof(Subtotals)); }

  private Subtotals? _Subtotals;

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