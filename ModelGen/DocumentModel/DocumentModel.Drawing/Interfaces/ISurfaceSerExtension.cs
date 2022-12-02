namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public interface ISurfaceSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
