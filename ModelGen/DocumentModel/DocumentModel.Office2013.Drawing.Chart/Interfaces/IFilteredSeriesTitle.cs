namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public interface IFilteredSeriesTitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IChartText? ChartText { get ; set; }
  
}
