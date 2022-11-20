namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IScatterChartSeries))]
public interface IFilteredScatterSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IScatterChartSeries? ScatterChartSeries { get ; set; }
  
}
