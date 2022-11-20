namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Major Gridlines.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface IMajorGridlines // : DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
