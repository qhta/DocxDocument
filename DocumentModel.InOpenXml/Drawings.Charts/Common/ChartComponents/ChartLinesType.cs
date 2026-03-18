namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ChartLinesType Class.
/// </summary>
[OpenXmlType(typeof(DXDC.ChartLinesType))]
public partial class ChartLinesType<T> : ModelElement<T> where T : DXDC.ChartLinesType
{
  /// <summary>
  ///   Chart shape properties of the chart lines.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ChartLinesType.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;
}

/// <summary>
///  Concrete implementation of ChartLinesType for the DXDC.ChartLinesType.
/// </summary>
[OpenXmlType(typeof(DXDC.ChartLinesType))]
public class ChartLinesType: ModelElement<DXDC.ChartLinesType>
{

}
