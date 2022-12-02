namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public interface IFilteredPieSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public IPieChartSeries? PieChartSeries { get ; set; }
  
}
