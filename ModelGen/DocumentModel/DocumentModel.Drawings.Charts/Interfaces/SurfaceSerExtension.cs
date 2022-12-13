namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceSerExtension Class.
/// </summary>
public interface SurfaceSerExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredSeriesTitle? FilteredSeriesTitle { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredCategoryTitle? FilteredCategoryTitle { get ; set; }
  
  public DocumentModel.Drawings13.Charts.CategoryFilterExceptions? CategoryFilterExceptions { get ; set; }
  
}
