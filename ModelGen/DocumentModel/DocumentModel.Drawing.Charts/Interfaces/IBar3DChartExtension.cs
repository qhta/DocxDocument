namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public interface IBar3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
