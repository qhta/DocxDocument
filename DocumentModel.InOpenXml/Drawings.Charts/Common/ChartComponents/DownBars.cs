namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Down Bars.
/// </summary>
[OpenXmlType(typeof(DXDC.DownBars))]
[DataContract]
[XmlRoot("DownBars", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DownBars: ModelElement<DXDC.DownBars>
{
  /// <summary>
  /// Chart shape properties for the down bars.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.DownBars.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetProperty<ChartShapeProperties?>(GetUpdatableElement()?.ChartShapeProperties);
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;
}