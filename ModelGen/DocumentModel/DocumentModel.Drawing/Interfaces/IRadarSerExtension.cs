namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarSerExtension Class.
/// </summary>
public interface IRadarSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public IDataLabelsRange? DataLabelsRange { get ; set; }
  
  public ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
