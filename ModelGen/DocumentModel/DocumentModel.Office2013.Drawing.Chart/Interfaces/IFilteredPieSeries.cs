namespace DocumentModel.Office2013.Drawing.Chart;

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
