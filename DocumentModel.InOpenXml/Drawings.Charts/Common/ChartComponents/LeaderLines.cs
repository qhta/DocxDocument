namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Leader Lines.
/// </summary>
[OpenXmlType(typeof(DXDC.LeaderLines))]
public partial class LeaderLines : ModelElement<DXDC.LeaderLines>
{
  /// <summary>
  /// Chart shape properties for the leader lines.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LeaderLines.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }

  private ChartShapeProperties? _ChartShapeProperties;
}