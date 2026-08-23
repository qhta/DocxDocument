namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Major Gridlines.
/// </summary>
[OpenXmlType(typeof(DXDC.MajorGridlines))]
[DataContract]
[XmlRoot("MajorGridlines", Namespace = "DocumentModel.Drawings.Charts")]
public partial class MajorGridlines: ModelElement<DXDC.MajorGridlines>
{
  /// <summary>
  /// ChartShapeProperties of the major gridlines.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetElement<ChartShapeProperties, DXDC.ChartShapeProperties>(GetUpdatableElement());
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;
}