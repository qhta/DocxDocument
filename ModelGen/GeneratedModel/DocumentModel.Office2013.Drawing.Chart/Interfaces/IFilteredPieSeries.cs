namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IPieChartSeries))]
public interface IFilteredPieSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IPieChartSeries? PieChartSeries { get ; set; }
  
}
