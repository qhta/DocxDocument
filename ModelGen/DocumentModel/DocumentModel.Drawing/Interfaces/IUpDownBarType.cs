namespace DocumentModel.Drawing;

/// <summary>
/// Defines the UpDownBarType Class.
/// </summary>
public interface IUpDownBarType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
