namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public interface ISurfaceSerExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public DocumentModel.Drawing.IFilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Drawing.ICategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
