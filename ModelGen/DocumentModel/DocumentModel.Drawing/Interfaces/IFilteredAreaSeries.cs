namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public interface IFilteredAreaSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public IAreaChartSeries? AreaChartSeries { get ; set; }
  
}
