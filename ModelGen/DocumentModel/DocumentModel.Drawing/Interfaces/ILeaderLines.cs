namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LeaderLines Class.
/// </summary>
public interface ILeaderLines // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
}
