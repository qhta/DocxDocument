namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public interface IAreaChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
