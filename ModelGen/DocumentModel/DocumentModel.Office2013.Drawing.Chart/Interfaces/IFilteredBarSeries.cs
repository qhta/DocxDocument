namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public interface IFilteredBarSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public IBarChartSeries? BarChartSeries { get ; set; }
  
}
