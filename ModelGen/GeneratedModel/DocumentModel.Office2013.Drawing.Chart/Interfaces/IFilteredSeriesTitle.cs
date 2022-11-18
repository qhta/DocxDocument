namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IChartText))]
public interface IFilteredSeriesTitle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IChartText? ChartText { get ; set; }
  
}
