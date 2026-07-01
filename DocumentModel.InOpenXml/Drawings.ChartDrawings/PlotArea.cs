namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the PlotArea Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.PlotArea))]
[DataContract]
[XmlRoot("PlotArea", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class PlotArea : ModelElement<DXO16DCD.PlotArea>
{
  /// <summary>
  /// Specifies the plot area region.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PlotArea.PlotAreaRegion))]
  public PlotAreaRegion? PlotAreaRegion { get => _PlotAreaRegion; set => UpdateField(ref _PlotAreaRegion, value, nameof(PlotAreaRegion)); }

  private PlotAreaRegion? _PlotAreaRegion;
  /// <summary>
  /// Specifies the axes.
  /// </summary>
  public AxisList? Axes { get => _axes; set => UpdateField(ref _axes, value, nameof(Axes)); }

  private AxisList? _axes;
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}