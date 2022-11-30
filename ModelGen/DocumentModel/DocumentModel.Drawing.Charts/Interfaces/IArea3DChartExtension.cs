namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public interface IArea3DChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
