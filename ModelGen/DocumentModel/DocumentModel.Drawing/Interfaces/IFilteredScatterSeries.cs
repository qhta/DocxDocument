namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public interface IFilteredScatterSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  public DocumentModel.Drawing.IScatterChartSeries? ScatterChartSeries { get ; set; }
  
}
