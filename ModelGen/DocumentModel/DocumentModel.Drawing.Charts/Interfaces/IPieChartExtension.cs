namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public interface IPieChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
