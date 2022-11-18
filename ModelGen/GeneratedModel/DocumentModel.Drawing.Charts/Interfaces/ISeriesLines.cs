namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SeriesLines Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface ISeriesLines // : DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
