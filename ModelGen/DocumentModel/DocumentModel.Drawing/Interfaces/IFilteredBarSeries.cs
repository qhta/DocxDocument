namespace DocumentModel.Drawing;

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
