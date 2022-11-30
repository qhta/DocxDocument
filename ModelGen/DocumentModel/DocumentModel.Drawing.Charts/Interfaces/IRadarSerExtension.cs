namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the RadarSerExtension Class.
/// </summary>
public interface IRadarSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
