namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Up Bars.
/// </summary>
[OpenXmlType(typeof(DXDC.UpBars))]
[DataContract]
[XmlRoot("UpBars", Namespace = "DocumentModel.Drawings.Charts")]
public partial class UpBars: ModelElement<DXDC.UpBars>
{
  /// <summary>
  /// Chart shape properties for the up bars.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.UpBars.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetProperty<ChartShapeProperties?>(GetUpdatableElement()?.ChartShapeProperties);
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;
}