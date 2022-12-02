namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public interface IFilteredAreaSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public DocumentModel.Drawing.IAreaChartSeries? AreaChartSeries { get ; set; }
  
}
