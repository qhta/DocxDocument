namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Minor Gridlines.
/// </summary>
[OpenXmlType(typeof(DXDC.MinorGridlines))]
public partial class MinorGridlines: ModelElement<DXDC.MinorGridlines>
{
  /// <summary>
  /// ChartShapeProperties of the minor gridlines.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;
}