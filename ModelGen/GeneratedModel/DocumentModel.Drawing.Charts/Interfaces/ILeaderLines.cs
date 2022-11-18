namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Leader Lines.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface ILeaderLines // : DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
