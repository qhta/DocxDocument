namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public interface IFilteredScatterSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IScatterChartSeries? ScatterChartSeries { get ; set; }
  
}
