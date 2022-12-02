namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartLinesType Class.
/// </summary>
public interface IChartLinesType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
