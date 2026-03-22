namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Drop Lines.
/// </summary>
[OpenXmlType(typeof(DXDC.DropLines))]
public partial class DropLines: ModelElement<DXDC.DropLines>
{
  /// <summary>
  /// Chart shape properties for the drop lines.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.DropLines.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }
  private ChartShapeProperties? _ChartShapeProperties;
}