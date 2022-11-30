namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public interface ILine3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
