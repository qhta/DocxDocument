namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public interface IFilteredSeriesTitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Drawing.IChartText? ChartText { get ; set; }
  
}
