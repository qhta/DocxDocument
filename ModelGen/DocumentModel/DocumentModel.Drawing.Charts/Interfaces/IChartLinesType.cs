namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ChartLinesType Class.
/// </summary>
public interface IChartLinesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
