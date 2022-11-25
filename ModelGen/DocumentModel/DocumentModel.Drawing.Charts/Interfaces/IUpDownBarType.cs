namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the UpDownBarType Class.
/// </summary>
public interface IUpDownBarType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
