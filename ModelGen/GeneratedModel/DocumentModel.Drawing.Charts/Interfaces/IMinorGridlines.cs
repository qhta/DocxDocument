namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Minor Gridlines.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface IMinorGridlines // : DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
