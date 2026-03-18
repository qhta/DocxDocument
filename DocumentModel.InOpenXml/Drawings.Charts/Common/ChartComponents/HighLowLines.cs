namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the HighLowLines Class.
/// </summary>
[OpenXmlType(typeof(DXDC.HighLowLines))]
public partial class HighLowLines : ModelElement<DXDC.HighLowLines>
{
  /// <summary>
  /// Chart shape properties for the high low lines.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HighLowLines.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }

  private ChartShapeProperties? _ChartShapeProperties;
}