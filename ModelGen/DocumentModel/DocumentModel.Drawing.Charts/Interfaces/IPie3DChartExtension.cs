namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public interface IPie3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
