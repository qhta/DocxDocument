namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the PlotSurface Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.PlotSurface))]
[XmlRoot("PlotSurface", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class PlotSurface : ModelElement<DXO16DCD.PlotSurface>
{
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PlotSurface.ShapeProperties))]
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PlotSurface.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}