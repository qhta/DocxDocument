namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a complete chart visualization with its associated components.
/// </summary>
/// <remarks>
///   This class defines the top-level container for a chart
///   drawing that encompasses all the visual and structural elements of a chart. A chart combines a title,
///   a plot area containing the data visualization and axes, a legend for identifying data series, and
///   support for custom extensions. This class represents the complete chart object as it appears in
///   Office documents, providing a unified structure for various chart types including bar charts, line charts,
///   pie charts, scatter plots, histograms, and more. The chart serves as the root element that coordinates
///   all chart components and defines their relationships, enabling complex data visualizations with
///   consistent formatting and layout. Charts can be embedded in documents, presentations, and spreadsheets,
///   providing powerful data visualization capabilities across the Office suite.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Chart))]
[DataContract]
[XmlRoot("Chart", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Chart: ModelElement<DXO16DCD.Chart>
{
  /// <summary>
  /// Specifies the chart title.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Chart.ChartTitle))]
  public ChartTitle? ChartTitle
  {
    get => _ChartTitle ??= GetProperty<ChartTitle?>(GetUpdatableElement()?.ChartTitle);
    set => UpdateField(ref _ChartTitle, value, nameof(ChartTitle));
  }

  private ChartTitle? _ChartTitle;

  /// <summary>
  /// Specifies the plot area.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Chart.PlotArea))]
  public PlotArea? PlotArea
  {
    get => _PlotArea ??= GetProperty<PlotArea?>(GetUpdatableElement()?.PlotArea);
    set => UpdateField(ref _PlotArea, value, nameof(PlotArea));
  }

  private PlotArea? _PlotArea;

  /// <summary>
  /// Specifies the legend.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Chart.Legend))]
  public Legend? Legend
  {
    get => _Legend ??= GetProperty<Legend?>(GetUpdatableElement()?.Legend);
    set => UpdateField(ref _Legend, value, nameof(Legend));
  }

  private Legend? _Legend;

  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Chart.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}