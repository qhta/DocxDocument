namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Drop Lines.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public interface IDropLines // : DocumentFormat.OpenXml.Drawing.Charts.ChartLinesType
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
