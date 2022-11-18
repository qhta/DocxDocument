namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IBarChartSeries))]
public interface IFilteredBarSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IBarChartSeries? BarChartSeries { get ; set; }
  
}
