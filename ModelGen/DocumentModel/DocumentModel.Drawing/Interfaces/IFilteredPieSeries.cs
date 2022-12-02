namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public interface IFilteredPieSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public DocumentModel.Drawing.IPieChartSeries? PieChartSeries { get ; set; }
  
}
