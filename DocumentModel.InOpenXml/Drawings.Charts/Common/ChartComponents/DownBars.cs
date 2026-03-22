namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Down Bars.
/// </summary>
[OpenXmlType(typeof(DXDC.DownBars))]
public partial class DownBars: ModelElement<DXDC.DownBars>
{
  /// <summary>
  /// Chart shape properties for the down bars.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.DownBars.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }
  private ChartShapeProperties? _ChartShapeProperties;
}