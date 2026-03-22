namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.PlotAreaRegion))]
public class PlotAreaRegion: ModelElement<DXO16DCD.PlotAreaRegion>
{
  /// <summary>
  /// Specifies the plot surface.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PlotAreaRegion.PlotSurface))]
  public PlotSurface? PlotSurface
  {
    get => _PlotSurface;
    set => UpdateField(ref _PlotSurface, value, nameof(PlotSurface));
  }
  private PlotSurface? _PlotSurface;
  /// <summary>
  /// Specifies the series.
  /// </summary>
  public Series? Series { get => _Series; set => UpdateField(ref _Series, value, nameof(Series)); }
  private Series? _Series;
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