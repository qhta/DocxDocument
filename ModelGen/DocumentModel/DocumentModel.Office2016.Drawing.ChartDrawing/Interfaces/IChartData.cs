namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface IChartData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExternalData? ExternalData { get ; set; }
  
}
