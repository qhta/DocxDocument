namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public interface IScatterChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredScatterSeries? FilteredScatterSeries { get ; set; }
  
}
